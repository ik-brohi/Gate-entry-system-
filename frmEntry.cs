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
using System.Data.Sql;



namespace GateEnterySystem
{
    public partial class frmEntry : Form
    {
        string txt;
        int txtLength;
        string inout;
        public frmEntry()
        {
            frmShowall frshowall; 
            InitializeComponent();
            frshowall = new frmShowall();
            txtEntryNo.MaxLength = 10;
            txtCnic.MaxLength = 13;
            txtFullname.MaxLength = 40;
            txtReason.MaxLength = 50;
            txtContact.MaxLength = 11;
            
        }  

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
         
            timer1.Start();
            if (txtLength < txt.Length)
            {
                lblWelcome.Text = lblWelcome.Text + txt.ElementAt(txtLength);
                txtLength++;
            }
            else
            {
                lblWelcome.Text = " ";
                lblWelcome.ForeColor = Color.SpringGreen;
                txtLength = 0;

            }
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

        private void frmEntry_Load(object sender, EventArgs e)
        {
            txt = lblWelcome.Text;
            lblWelcome.Text = " ";
            timer1.Start();
            
        }

        private void lblEntryreason_Click(object sender, EventArgs e)
        {

        }

        private void lblContact_Click(object sender, EventArgs e)
        {

        }

        private void aDDENTRYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEntry f = new frmEntry();
            this.Hide();
            f.Show();
        }

        private void btnAddentry_Click(object sender, EventArgs e)
        {   if ((string.IsNullOrWhiteSpace(txtEntryNo.Text)) && (string.IsNullOrWhiteSpace(txtCnic.Text)) && (string.IsNullOrWhiteSpace(txtFullname.Text)) && (string.IsNullOrWhiteSpace(txtContact.Text)) && (string.IsNullOrWhiteSpace(txtReason.Text)) && ((!rdoIn.Checked) ||(!rdoOut.Checked)))
            {
                MessageBox.Show("You cannot leave any field empty or unchecked!");
            }
            else
            { 
                
                
                if (txtCnic.Text.Length == 13)
                {   if (txtFullname.Text.Length > 2)
                    {
                        if ( txtContact.Text.Length == 11)
                        {
                            if (txtReason.Text.Length > 4)
                            {
                                try
                                {
                                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\92318\source\repos\GateEnterySystem\GateEntryDataBase.mdf;Integrated Security=True;Connect Timeout=30");
                                    con.Open();
                                    string query = "insert into TBL_ENTRY values (@ENTRYNUMBER,@CNIC,@FULLNAME,@CONTACTNUMBER,@ENTRYREASON,@ENTRYDATEANDTIME,@ENTRYINOUT,@ENTRYTIME) ";
                                    SqlCommand cmd = new SqlCommand(query, con);
                                    cmd.Parameters.AddWithValue("@ENTRYNUMBER", int.Parse(txtEntryNo.Text));
                                    cmd.Parameters.AddWithValue("@CNIC", txtCnic.Text);
                                    cmd.Parameters.AddWithValue("@FULLNAME", txtFullname.Text);
                                    cmd.Parameters.AddWithValue("@CONTACTNUMBER", txtContact.Text);
                                    cmd.Parameters.AddWithValue("@ENTRYREASON", txtReason.Text);
                                    cmd.Parameters.AddWithValue("@ENTRYDATEANDTIME", dateTimePicker1.Text);
                                    cmd.Parameters.AddWithValue("@ENTRYINOUT", inout);
                                    cmd.Parameters.AddWithValue("@ENTRYTIME", dateTimePicker2.Text);
                                    cmd.ExecuteNonQuery();

                                    con.Close();

                                    MessageBox.Show("Entry Added Successfully!");
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Wrong Entry Number! Entry Number already exist!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Entry Reason Must Be More Then equal to 5 characters! ");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid Contact Number! Contact Number Must be 11 Characters long!");
                            
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Full Name Short Name is not allowed!");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid CNIC Number! CNIC Must be 13 digits long!");
                }
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rdoIn_CheckedChanged(object sender, EventArgs e)
        {
            inout = "IN";
        }

        private void rdoOut_CheckedChanged(object sender, EventArgs e)
        {
            inout = "OUT";
        }

        private void sHOWALLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowall frshowall = new frmShowall();
            this.Hide();
            frshowall.Show();

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\92318\source\repos\GateEnterySystem\GateEntryDataBase.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string query = "Select * from TBL_ENTRY "; 
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            frshowall.dataGridView1.DataSource = dt;
           
            
        }

        private void sHOWONEENTRYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearch frmSearch = new frmSearch();
            this.Hide();
            frmSearch.Show();
        }

        private void dELETEONEENTRYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDelete frmdelete = new frmDelete();
            this.Hide();
            frmdelete.Show();
        }

        private void dELETEALLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want To Delete All Records From Database Permanently? You Will Not Be Able To See Them Again!", "Deleting Entry", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\92318\source\repos\GateEnterySystem\GateEntryDataBase.mdf;Integrated Security=True;Connect Timeout=30"))
                using (SqlCommand cmd = new SqlCommand("TRUNCATE TABLE TBL_ENTRY ", con))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("All Records Deleted Successfully!");

                }

            }
            else
            {
                MessageBox.Show("You Have Not Deleted All Records From DataBase!");
            }


        }

        private void dateTimePicker2_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void uPDATEENTRYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdate frmupdate = new frmUpdate();
            this.Hide();
            frmupdate.Show();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void txtReason_TextChanged(object sender, EventArgs e)
        {
            if (txtReason.Text.Length >= 50)
            {
                MessageBox.Show("You can only Enter an Entry Reason with 50 characters maximum");
            }
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {
            if (txtContact.Text.Length >= 11)
            {
                MessageBox.Show("You can only Enter Contact Number of 11 Digits!");
            }
        }

        private void txtFullname_TextChanged(object sender, EventArgs e)
        {
            if (txtFullname.Text.Length >= 40)
            {
                MessageBox.Show("You can only Enter a Name with 40 characters maximum");
            }
        }

        private void txtCnic_TextChanged(object sender, EventArgs e)
        {
            if (txtCnic.Text.Length >= 13)
            {
                MessageBox.Show("You can only Enter CNIC Number of 13 Digits!");
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblEntryDandT_Click(object sender, EventArgs e)
        {

        }

        private void lblFullname_Click(object sender, EventArgs e)
        {

        }

        private void lblCnic_Click(object sender, EventArgs e)
        {

        }

        private void txtEntryNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            
        }

        private void txtCnic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFullname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEntryNo_TextChanged(object sender, EventArgs e)
        {
            if(txtEntryNo.Text.Length >=10)
            {
                MessageBox.Show("You can only add Entry Number in the range of 1 to 9999999999");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin frmlogn = new frmLogin();
            this.Hide();
            frmlogn.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
