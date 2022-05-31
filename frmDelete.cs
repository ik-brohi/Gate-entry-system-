using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GateEnterySystem
{
    public partial class frmDelete : Form
    {
        string txt;
        int txtLength;
        public frmDelete()
        {
            InitializeComponent();
            txtDelete.MaxLength = 13;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(txtDelete.Text)))
            {
                MessageBox.Show("Must Enter a valid CNIC Number to Delete a record");
            }
            else
            {
                btnDelete.Enabled = false;
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\92318\source\repos\GateEnterySystem\GateEntryDataBase.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                string query = "Select * from TBL_ENTRY where CNIC=@CNIC ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("CNIC", txtDelete.Text);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Close();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    girdViewSearch.DataSource = dt;
                    btnDelete.Enabled = true;
                    girdViewSearch.Show();
                    btnDelete.Show();
                }
                else
                {
                    MessageBox.Show("No Record found!");
                    girdViewSearch.Hide();
                    btnDelete.Hide();
                }
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want To Delete The Record From Database Permanently? You Will Not Be Able To See It Again!", "Deleting Entry", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (txtDelete.Text.Length == 13)
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\92318\source\repos\GateEnterySystem\GateEntryDataBase.mdf;Integrated Security=True;Connect Timeout=30");
                    con.Open();
                    string query = "Delete TBL_ENTRY where CNIC=@CNIC ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("CNIC", txtDelete.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Entry Deleted Successfully!");
                }
                else
                {
                    MessageBox.Show("Wrong CNIC Number or Record Doesnot Exist! ");
                }
            }
            else
            {
                MessageBox.Show("You Have Not Deleted the Entry");
            }
        }

        private void txtDelete_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmEntry frm1 = new frmEntry();
            this.Hide();
            frm1.Show();
            
        }

        private void txtDelete_TextChanged(object sender, EventArgs e)
        {
            if (txtDelete.Text.Length >= 13)
            {
                MessageBox.Show("You can only Enter CNIC Number of 13 Digits!");
            }
        }

        private void frmDelete_Load(object sender, EventArgs e)
        {
            txt = lblDelete.Text;
            lblDelete.Text = " ";
            timer1.Start();
            girdViewSearch.Hide();
            btnDelete.Hide();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.DeepPink, ButtonBorderStyle.Dotted);

        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {

            using (SolidBrush a = new SolidBrush(Color.Pink))
                e.Graphics.FillRectangle(a, e.ClipRectangle);





        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            if (txtLength < txt.Length)
            {
                lblDelete.Text = lblDelete.Text + txt.ElementAt(txtLength);
                txtLength++;
            }
            else
            {
                lblDelete.Text = " ";
                lblDelete.ForeColor = Color.Red;
                txtLength = 0;
            }
        }
    }
}
