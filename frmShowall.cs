using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagedList;

namespace GateEnterySystem
{
    public partial class frmShowall : Form
    {
        private string txt;
        private int txtLength = 0;
        public frmShowall()
        {
            InitializeComponent();
        }
        int currentPage = 1;
        int pageSize = 100;
        private void frmShowall_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gateEntryDataBaseDataSet2.TBL_ENTRY' table. You can move, or remove it, as needed.
            this.tBL_ENTRYTableAdapter.Fill(this.gateEntryDataBaseDataSet2.TBL_ENTRY);
            txt = lblShowall.Text;
            lblShowall.Text = " ";
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            if (txtLength < txt.Length)
            {
                lblShowall.Text = lblShowall.Text + txt.ElementAt(txtLength);
                txtLength++;
            }
            else
            {
                lblShowall.Text = " ";
                lblShowall.ForeColor = Color.DarkRed;
                txtLength = 0;


            }
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmEntry frm1 = new frmEntry();
            this.Hide();
            frm1.Show();
        }



        
    }
}
