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
    public partial class frmForgetpassword : Form
    {
        string txt;
        int txtLength;
        public frmForgetpassword()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\92318\source\repos\GateEnterySystem\GateEntryDataBase.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string query = "Select * from GATEENTRY where USERNAME=@USERNAME ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("USERNAME", txtSearch.Text);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {

                dr.Close();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                lblPassword.Show();
                txtPassword.Show();
                lblConfirmpassword.Show();
                txtConfirmpassword.Show();
                btnSave.Enabled = true;

            }
            else
            {
                MessageBox.Show("No User Found! Create A New Account By Clicking Sign Up Button");
                lblPassword.Hide();
                txtPassword.Hide();
                lblConfirmpassword.Hide();
                txtConfirmpassword.Hide();



            }
            con.Close();
        }

        private void frmForgetpassword_Load(object sender, EventArgs e)
        {
            txt = lbltitle.Text;
            lbltitle.Text = " ";
            timer1.Start();
            lblPassword.Hide();
            txtPassword.Hide();
            lblConfirmpassword.Hide();
            txtConfirmpassword.Hide();
            btnSave.Enabled = false;
            txtPassword.MaxLength = 6;
            txtConfirmpassword.MaxLength = 6;


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\92318\source\repos\GateEnterySystem\GateEntryDataBase.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string query = "Update GATEENTRY set PASSWORD=@PASSWORD where USERNAME=@USERNAME ";
            if (txtPassword.Text == txtConfirmpassword.Text)
            {


                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@USERNAME", txtSearch.Text);
                cmd.Parameters.AddWithValue("@PASSWORD", txtConfirmpassword.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Password Successfully Changed! Now Login With New Password!");
                frmLogin frmlg = new frmLogin();
                this.Hide();
                frmlg.Show();


            }
            else
            {
                MessageBox.Show("Password Doesn't Match!");
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            frmSignup frmsignup = new frmSignup();
            this.Hide();
            frmsignup.Show();
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
