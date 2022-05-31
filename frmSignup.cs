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
    public partial class frmSignup : Form
    {
        public frmSignup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        string txt;
        int txtLength;
        private void frmSignup_Load(object sender, EventArgs e)
        {
            txt = lbltitle.Text;
            lbltitle.Text = " ";
            timer1.Start();
            txtUsername.MaxLength = 15;
            txtPassword.MaxLength = 6;
            txtConfirmpass.MaxLength = 6;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtConfirmpass.Text)
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\92318\source\repos\GateEnterySystem\GateEntryDataBase.mdf;Integrated Security=True;Connect Timeout=30");
                    con.Open();
                    string query = "insert into GATEENTRY values (@USERNAME,@PASSWORD) ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@USERNAME", txtUsername.Text);
                    cmd.Parameters.AddWithValue("PASSWORD", txtPassword.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("YOUR ACCOUNT HAS BEEN CREATED SUCCESSFULLY NOW YOU CAN LOGIN!");
                    frmLogin frmlogin = new frmLogin();
                    this.Hide();
                    frmlogin.Show();
                }
                catch (Exception ex)
                {


                    MessageBox.Show("User Already exist! If you Forget your Password Click Already Have An Account And Reset Your Password! ");

                }
            }
            else
            {
                MessageBox.Show("Password Does Not Match! Please Enter Again");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin frmlogin = new frmLogin();
            this.Hide();
            frmlogin.Show();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();


            if (txtLength < txt.Length)
            {
                lbltitle.Text = lbltitle.Text + txt.ElementAt(txtLength);
                txtLength++;
            }
            else
            {
                lbltitle.Text = " ";
                lbltitle.ForeColor = Color.Red;
                txtLength = 0;
            }
        }
    }
}
