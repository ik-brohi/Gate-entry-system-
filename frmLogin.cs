using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace GateEnterySystem
{
    public partial class frmLogin : Form
    {
        private string txt;
        private int txtLength=0;
        public frmLogin()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            txtPassword.MaxLength =6;
            txtUsername.MaxLength =15;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
            if (txtLength < txt.Length)
            {
                lbltitle.Text = lbltitle.Text + txt.ElementAt(txtLength);
                txtLength++;
            }
            else
            {
                lbltitle.Text = " ";
                lbltitle.ForeColor = Color.Green;
                txtLength = 0;
                
                
            }
        }
        string usern;
        string pass;
        private void frmGateEntry_Load(object sender, EventArgs e)
        {   this.pictureBox1.Show();
            txt = lbltitle.Text;
            lbltitle.Text = " ";
            timer1.Start();
            txtUsername.Text = GateEnterySystem.Properties.Settings.Default.UserName;
            txtPassword.Text = GateEnterySystem.Properties.Settings.Default.Password;



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

        private void lbltitle_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {   
            
            
         }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            frmSignup frmsignup = new frmSignup();
            this.Hide();
            frmsignup.Show();


        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\92318\source\repos\GateEnterySystem\GateEntryDataBase.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "Select * from GATEENTRY where username='" + txtUsername.Text.Trim() + "' and Password ='" + txtPassword.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                this.Hide();
                frmEntry ef = new frmEntry();
                ef.Show();
            }
            else
            {
                MessageBox.Show("Wrong password or username!");
            }
            if (checkBox1.Checked)
            {
                GateEnterySystem.Properties.Settings.Default.UserName = txtUsername.Text;
                GateEnterySystem.Properties.Settings.Default.Password = txtPassword.Text;
                GateEnterySystem.Properties.Settings.Default.Save();

            }
            


        }

        private void lnklblforgetpassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmForgetpassword frmforgetpassword = new frmForgetpassword();
            this.Hide();
            frmforgetpassword.Show();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
