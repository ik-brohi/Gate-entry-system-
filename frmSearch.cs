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
    public partial class frmSearch : Form
    {
        private string txt;
        private int txtLength = 0;
        public frmSearch()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            if (txtLength < txt.Length)
            {
                lblSearch.Text = lblSearch.Text + txt.ElementAt(txtLength);
                txtLength++;
            }
            else
            {
                lblSearch.Text = " ";
                lblSearch.ForeColor = Color.Orange;
                txtLength = 0;


            }
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            txt = lblSearch.Text;
            lblSearch.Text = " ";
            timer1.Start();
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
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\92318\source\repos\GateEnterySystem\GateEntryDataBase.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string query = "Select * from TBL_ENTRY where CNIC=@CNIC ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("CNIC", txtSearch.Text);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                
                dr.Close();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                girdViewSearch.DataSource = dt;
                girdViewSearch.Show();
            }
            else
            {
                MessageBox.Show("No Record found!");
                girdViewSearch.Hide();

            }
            con.Close();


        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
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

        private void lblHome_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
