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
    
    public partial class frmUpdate : Form
    {
        string txt;
        int txtLength;
        string inout;
        
        public frmUpdate()
        {   
            InitializeComponent();
            txtSearch.MaxLength = 10;
            txtCnic.MaxLength = 13;
            txtFullname.MaxLength = 40;
            txtReason.MaxLength = 50;
            txtContact.MaxLength = 11;
        }
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\92318\source\repos\GateEnterySystem\GateEntryDataBase.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string query = "Select * from TBL_ENTRY where ENTRYNUMBER=@ENTRYNUMBER ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("ENTRYNUMBER", txtSearch.Text);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {

                dr.Close();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                girdViewUpdate.DataSource = dt;
                girdViewUpdate.Show();
                btnUpdateEntry.Enabled = true;
                txtCnic.Show();
                txtFullname.Show();
                txtContact.Show();
                dateTimePicker1.Show();
                dateTimePicker2.Show();
                txtReason.Show();
                lblCnic.Show();
                lblFullname.Show();
                lblContact.Show();
                lblReason.Show();
                lblEntryDandT.Show();
                lblTime.Show();
                rdoIn.Show();
                rdoOut.Show();
                btnUpdateEntry.Show();
                groupBoxUpdate.Show();

                
               
               
                cmd.ExecuteNonQuery();

            }
            else
            {
                MessageBox.Show("No Record found!");
                girdViewUpdate.Hide();
                txtCnic.Hide();
                txtFullname.Hide();
                txtContact.Hide();
                dateTimePicker1.Hide();
                dateTimePicker2.Hide();
                txtReason.Hide();
                lblCnic.Hide();
                lblFullname.Hide();
                lblContact.Hide();
                lblReason.Hide();
                lblEntryDandT.Hide();
                lblTime.Hide();
                rdoIn.Hide();
                rdoOut.Hide();
                btnUpdateEntry.Hide();
                groupBoxUpdate.Hide();

            }
        }

        private void frmUpdate_Load(object sender, EventArgs e)
        {
            txt = lblSearch.Text;
            lblSearch.Text = " ";
            timer1.Start();
            girdViewUpdate.Hide();
            groupBoxUpdate.Hide();
            
            
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

        private void btnUpdateEntry_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(txtCnic.Text)) && (string.IsNullOrWhiteSpace(txtFullname.Text)) && (string.IsNullOrWhiteSpace(txtContact.Text)) && (string.IsNullOrWhiteSpace(txtReason.Text)) && ((!rdoIn.Checked) || (!rdoOut.Checked)))
            {
                MessageBox.Show("You cannot leave any field empty or unchecked!");
            }
            else
            {
                if (txtCnic.Text.Length == 13)
                {
                    if ( txtFullname.Text.Length > 2)
                    {
                        if (txtContact.Text.Length == 11)
                        {
                            if (txtReason.Text.Length > 4)
                            {
                               try
                               {

                                 SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\92318\source\repos\GateEnterySystem\GateEntryDataBase.mdf;Integrated Security=True;Connect Timeout=30");
                                 con.Open();
                                 string query = "Update TBL_ENTRY set CNIC=@CNIC,FULLNAME=@FULLNAME,CONTACTNUMBER=@CONTACTNUMBER,ENTRYREASON=@ENTRYREASON,ENTRYDATEANDTIME=@ENTRYDATEANDTIME,ENTRYINOUT=@ENTRYINOUT,ENTRYTIME=@ENTRYTIME where ENTRYNUMBER=@ENTRYNUMBER ";
                                 SqlCommand cmd = new SqlCommand(query, con);
                                 cmd.Parameters.AddWithValue("@ENTRYNUMBER", int.Parse(txtSearch.Text));
                                 cmd.Parameters.AddWithValue("@CNIC", txtCnic.Text);
                                 cmd.Parameters.AddWithValue("@FULLNAME", txtFullname.Text);
                                 cmd.Parameters.AddWithValue("@CONTACTNUMBER", txtContact.Text);
                                 cmd.Parameters.AddWithValue("@ENTRYREASON", txtReason.Text);
                                 cmd.Parameters.AddWithValue("@ENTRYDATEANDTIME", dateTimePicker1.Text);
                                 cmd.Parameters.AddWithValue("@ENTRYINOUT", inout);
                                 cmd.Parameters.AddWithValue("@ENTRYTIME", dateTimePicker2.Text);
                                 cmd.ExecuteNonQuery();

                                 con.Close();

                                 MessageBox.Show("Entry Updated Successfully!");
                               }
                               catch (Exception ex)
                               {
                                 MessageBox.Show("You cannot leave the In Out unchecked!");
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

        private void rdoOut_CheckedChanged(object sender, EventArgs e)
        {
            inout = "OUT";
        }

        private void rdoIn_CheckedChanged(object sender, EventArgs e)
        {
            inout = "IN";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length >= 10)
            {
                MessageBox.Show("You can only Search Entry Number in the range of 1 to 9999999999");
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmEntry frm1 = new frmEntry();
            this.Hide();
            frm1.Show();
        }

        private void lblHome_Click(object sender, EventArgs e)
        {

        }

        private void girdViewUpdate_MouseClick(object sender, MouseEventArgs e)
        {
            txtCnic.Text = girdViewUpdate.SelectedRows[0].Cells[1].Value.ToString();
            txtFullname.Text = girdViewUpdate.SelectedRows[0].Cells[2].Value.ToString();
            txtContact.Text = girdViewUpdate.SelectedRows[0].Cells[3].Value.ToString();
            txtReason.Text = girdViewUpdate.SelectedRows[0].Cells[4].Value.ToString();
            dateTimePicker1.Text=girdViewUpdate.SelectedRows[0].Cells[5].Value.ToString();
            dateTimePicker2.Text = girdViewUpdate.SelectedRows[0].Cells[7].Value.ToString();
            if (girdViewUpdate.SelectedRows[0].Cells[6].Value.ToString()=="IN")
            {
               rdoIn.Checked = true;
            }
            else
            {
                rdoOut.Checked = true;
            }
        }

        private void groupBoxUpdate_Enter(object sender, EventArgs e)
        {
            
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
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

        private void lblEntryDandT_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblFullname_Click(object sender, EventArgs e)
        {

        }

        private void lblCnic_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtReason_KeyPress(object sender, KeyPressEventArgs e)
        {

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
                lblSearch.ForeColor = Color.OrangeRed;
                txtLength = 0;

            }
        }
    }
}
