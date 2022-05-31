namespace GateEnterySystem
{
    partial class frmEntry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntry));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblEntry = new System.Windows.Forms.Label();
            this.lblCnic = new System.Windows.Forms.Label();
            this.lblFullname = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEntryDandT = new System.Windows.Forms.Label();
            this.rdoIn = new System.Windows.Forms.RadioButton();
            this.rdoOut = new System.Windows.Forms.RadioButton();
            this.txtEntryNo = new System.Windows.Forms.TextBox();
            this.txtCnic = new System.Windows.Forms.TextBox();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.btnAddentry = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aDDENTRYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETEENTRYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETEONEENTRYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETEALLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uPDATEENTRYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sEARCHENTRYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sHOWONEENTRYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sHOWALLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblTime = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.White;
            this.lblWelcome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWelcome.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Red;
            this.lblWelcome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblWelcome.Location = new System.Drawing.Point(367, 111);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(422, 31);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome To Gate Entry System";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblEntry
            // 
            this.lblEntry.AutoSize = true;
            this.lblEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblEntry.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntry.ForeColor = System.Drawing.Color.Red;
            this.lblEntry.Location = new System.Drawing.Point(242, 182);
            this.lblEntry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEntry.Name = "lblEntry";
            this.lblEntry.Size = new System.Drawing.Size(146, 21);
            this.lblEntry.TabIndex = 2;
            this.lblEntry.Text = "Entry Number :";
            // 
            // lblCnic
            // 
            this.lblCnic.AutoSize = true;
            this.lblCnic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblCnic.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnic.ForeColor = System.Drawing.Color.Red;
            this.lblCnic.Location = new System.Drawing.Point(242, 248);
            this.lblCnic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCnic.Name = "lblCnic";
            this.lblCnic.Size = new System.Drawing.Size(56, 21);
            this.lblCnic.TabIndex = 3;
            this.lblCnic.Text = "CNIC :";
            this.lblCnic.Click += new System.EventHandler(this.lblCnic_Click);
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = true;
            this.lblFullname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblFullname.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullname.ForeColor = System.Drawing.Color.Red;
            this.lblFullname.Location = new System.Drawing.Point(242, 312);
            this.lblFullname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(106, 21);
            this.lblFullname.TabIndex = 4;
            this.lblFullname.Text = "Full Name :";
            this.lblFullname.Click += new System.EventHandler(this.lblFullname_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(242, 423);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Entry Reason :";
            this.label4.Click += new System.EventHandler(this.lblEntryreason_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(242, 365);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Contact Number :";
            this.label5.Click += new System.EventHandler(this.lblContact_Click);
            // 
            // lblEntryDandT
            // 
            this.lblEntryDandT.AutoSize = true;
            this.lblEntryDandT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblEntryDandT.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntryDandT.ForeColor = System.Drawing.Color.Red;
            this.lblEntryDandT.Location = new System.Drawing.Point(242, 480);
            this.lblEntryDandT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEntryDandT.Name = "lblEntryDandT";
            this.lblEntryDandT.Size = new System.Drawing.Size(118, 21);
            this.lblEntryDandT.TabIndex = 7;
            this.lblEntryDandT.Text = "Entry Date :";
            this.lblEntryDandT.Click += new System.EventHandler(this.lblEntryDandT_Click);
            // 
            // rdoIn
            // 
            this.rdoIn.AutoSize = true;
            this.rdoIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rdoIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoIn.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoIn.ForeColor = System.Drawing.Color.Red;
            this.rdoIn.Location = new System.Drawing.Point(246, 572);
            this.rdoIn.Margin = new System.Windows.Forms.Padding(4);
            this.rdoIn.Name = "rdoIn";
            this.rdoIn.Size = new System.Drawing.Size(48, 25);
            this.rdoIn.TabIndex = 8;
            this.rdoIn.TabStop = true;
            this.rdoIn.Text = "IN";
            this.rdoIn.UseVisualStyleBackColor = false;
            this.rdoIn.CheckedChanged += new System.EventHandler(this.rdoIn_CheckedChanged);
            // 
            // rdoOut
            // 
            this.rdoOut.AutoSize = true;
            this.rdoOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rdoOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoOut.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoOut.ForeColor = System.Drawing.Color.Red;
            this.rdoOut.Location = new System.Drawing.Point(469, 572);
            this.rdoOut.Margin = new System.Windows.Forms.Padding(4);
            this.rdoOut.Name = "rdoOut";
            this.rdoOut.Size = new System.Drawing.Size(65, 25);
            this.rdoOut.TabIndex = 9;
            this.rdoOut.TabStop = true;
            this.rdoOut.Text = "OUT";
            this.rdoOut.UseVisualStyleBackColor = false;
            this.rdoOut.CheckedChanged += new System.EventHandler(this.rdoOut_CheckedChanged);
            // 
            // txtEntryNo
            // 
            this.txtEntryNo.Location = new System.Drawing.Point(469, 172);
            this.txtEntryNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtEntryNo.Name = "txtEntryNo";
            this.txtEntryNo.Size = new System.Drawing.Size(405, 22);
            this.txtEntryNo.TabIndex = 10;
            this.txtEntryNo.TextChanged += new System.EventHandler(this.txtEntryNo_TextChanged);
            this.txtEntryNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEntryNo_KeyPress);
            // 
            // txtCnic
            // 
            this.txtCnic.Location = new System.Drawing.Point(469, 238);
            this.txtCnic.Margin = new System.Windows.Forms.Padding(4);
            this.txtCnic.Name = "txtCnic";
            this.txtCnic.Size = new System.Drawing.Size(405, 22);
            this.txtCnic.TabIndex = 11;
            this.txtCnic.TextChanged += new System.EventHandler(this.txtCnic_TextChanged);
            this.txtCnic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCnic_KeyPress);
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(469, 302);
            this.txtFullname.Margin = new System.Windows.Forms.Padding(4);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(405, 22);
            this.txtFullname.TabIndex = 12;
            this.txtFullname.TextChanged += new System.EventHandler(this.txtFullname_TextChanged);
            this.txtFullname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFullname_KeyPress);
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(469, 355);
            this.txtContact.Margin = new System.Windows.Forms.Padding(4);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(405, 22);
            this.txtContact.TabIndex = 13;
            this.txtContact.TextChanged += new System.EventHandler(this.txtContact_TextChanged);
            this.txtContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContact_KeyPress);
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(469, 413);
            this.txtReason.Margin = new System.Windows.Forms.Padding(4);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(405, 22);
            this.txtReason.TabIndex = 14;
            this.txtReason.TextChanged += new System.EventHandler(this.txtReason_TextChanged);
            // 
            // btnAddentry
            // 
            this.btnAddentry.BackColor = System.Drawing.Color.Yellow;
            this.btnAddentry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddentry.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddentry.ForeColor = System.Drawing.Color.Red;
            this.btnAddentry.Location = new System.Drawing.Point(1000, 530);
            this.btnAddentry.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddentry.Name = "btnAddentry";
            this.btnAddentry.Size = new System.Drawing.Size(129, 75);
            this.btnAddentry.TabIndex = 16;
            this.btnAddentry.Text = "Add Entry";
            this.btnAddentry.UseVisualStyleBackColor = false;
            this.btnAddentry.Click += new System.EventHandler(this.btnAddentry_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDENTRYToolStripMenuItem,
            this.dELETEENTRYToolStripMenuItem,
            this.uPDATEENTRYToolStripMenuItem,
            this.sEARCHENTRYToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(10, 10);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1147, 29);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // aDDENTRYToolStripMenuItem
            // 
            this.aDDENTRYToolStripMenuItem.AutoToolTip = true;
            this.aDDENTRYToolStripMenuItem.BackColor = System.Drawing.Color.Magenta;
            this.aDDENTRYToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 9.75F);
            this.aDDENTRYToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.aDDENTRYToolStripMenuItem.Name = "aDDENTRYToolStripMenuItem";
            this.aDDENTRYToolStripMenuItem.Size = new System.Drawing.Size(117, 25);
            this.aDDENTRYToolStripMenuItem.Text = "ADD ENTRY";
            this.aDDENTRYToolStripMenuItem.Click += new System.EventHandler(this.aDDENTRYToolStripMenuItem_Click);
            // 
            // dELETEENTRYToolStripMenuItem
            // 
            this.dELETEENTRYToolStripMenuItem.AutoToolTip = true;
            this.dELETEENTRYToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.dELETEENTRYToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dELETEONEENTRYToolStripMenuItem,
            this.dELETEALLToolStripMenuItem});
            this.dELETEENTRYToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 9.75F);
            this.dELETEENTRYToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.dELETEENTRYToolStripMenuItem.Name = "dELETEENTRYToolStripMenuItem";
            this.dELETEENTRYToolStripMenuItem.Size = new System.Drawing.Size(140, 25);
            this.dELETEENTRYToolStripMenuItem.Text = "DELETE ENTRY";
            // 
            // dELETEONEENTRYToolStripMenuItem
            // 
            this.dELETEONEENTRYToolStripMenuItem.BackColor = System.Drawing.Color.Lime;
            this.dELETEONEENTRYToolStripMenuItem.Name = "dELETEONEENTRYToolStripMenuItem";
            this.dELETEONEENTRYToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.dELETEONEENTRYToolStripMenuItem.Text = "DELETE ONE ENTRY";
            this.dELETEONEENTRYToolStripMenuItem.Click += new System.EventHandler(this.dELETEONEENTRYToolStripMenuItem_Click);
            // 
            // dELETEALLToolStripMenuItem
            // 
            this.dELETEALLToolStripMenuItem.BackColor = System.Drawing.Color.Yellow;
            this.dELETEALLToolStripMenuItem.Name = "dELETEALLToolStripMenuItem";
            this.dELETEALLToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.dELETEALLToolStripMenuItem.Text = "DELETE ALL";
            this.dELETEALLToolStripMenuItem.Click += new System.EventHandler(this.dELETEALLToolStripMenuItem_Click);
            // 
            // uPDATEENTRYToolStripMenuItem
            // 
            this.uPDATEENTRYToolStripMenuItem.AutoToolTip = true;
            this.uPDATEENTRYToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.uPDATEENTRYToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 9.75F);
            this.uPDATEENTRYToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.uPDATEENTRYToolStripMenuItem.Name = "uPDATEENTRYToolStripMenuItem";
            this.uPDATEENTRYToolStripMenuItem.Size = new System.Drawing.Size(146, 25);
            this.uPDATEENTRYToolStripMenuItem.Text = "UPDATE ENTRY";
            this.uPDATEENTRYToolStripMenuItem.Click += new System.EventHandler(this.uPDATEENTRYToolStripMenuItem_Click);
            // 
            // sEARCHENTRYToolStripMenuItem
            // 
            this.sEARCHENTRYToolStripMenuItem.AutoToolTip = true;
            this.sEARCHENTRYToolStripMenuItem.BackColor = System.Drawing.Color.Yellow;
            this.sEARCHENTRYToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sHOWONEENTRYToolStripMenuItem,
            this.sHOWALLToolStripMenuItem});
            this.sEARCHENTRYToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 9.75F);
            this.sEARCHENTRYToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.sEARCHENTRYToolStripMenuItem.Name = "sEARCHENTRYToolStripMenuItem";
            this.sEARCHENTRYToolStripMenuItem.Size = new System.Drawing.Size(144, 25);
            this.sEARCHENTRYToolStripMenuItem.Text = "SEARCH ENTRY";
            // 
            // sHOWONEENTRYToolStripMenuItem
            // 
            this.sHOWONEENTRYToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.sHOWONEENTRYToolStripMenuItem.Name = "sHOWONEENTRYToolStripMenuItem";
            this.sHOWONEENTRYToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.sHOWONEENTRYToolStripMenuItem.Text = "SHOW ONE ENTRY";
            this.sHOWONEENTRYToolStripMenuItem.Click += new System.EventHandler(this.sHOWONEENTRYToolStripMenuItem_Click);
            // 
            // sHOWALLToolStripMenuItem
            // 
            this.sHOWALLToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sHOWALLToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sHOWALLToolStripMenuItem.Name = "sHOWALLToolStripMenuItem";
            this.sHOWALLToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.sHOWALLToolStripMenuItem.Text = "SHOW ALL";
            this.sHOWALLToolStripMenuItem.Click += new System.EventHandler(this.sHOWALLToolStripMenuItem_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.GreenYellow;
            this.dateTimePicker1.CustomFormat = "hh:mm&dd:mm:yyyy";
            this.dateTimePicker1.Location = new System.Drawing.Point(469, 470);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(405, 22);
            this.dateTimePicker1.TabIndex = 18;
            this.dateTimePicker1.Value = new System.DateTime(2022, 2, 8, 12, 30, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTime.Font = new System.Drawing.Font("Showcard Gothic", 9.75F);
            this.lblTime.ForeColor = System.Drawing.Color.Red;
            this.lblTime.Location = new System.Drawing.Point(242, 530);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(116, 21);
            this.lblTime.TabIndex = 19;
            this.lblTime.Text = "Entry Time :";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(469, 520);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(405, 22);
            this.dateTimePicker2.TabIndex = 20;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            this.dateTimePicker2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dateTimePicker2_MouseDown);
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Location = new System.Drawing.Point(987, 49);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(142, 113);
            this.btnLogout.TabIndex = 21;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Stencil", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(23, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1144, 665);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(10, 614);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1144, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // frmEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1167, 688);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnAddentry);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtFullname);
            this.Controls.Add(this.txtCnic);
            this.Controls.Add(this.txtEntryNo);
            this.Controls.Add(this.rdoOut);
            this.Controls.Add(this.rdoIn);
            this.Controls.Add(this.lblEntryDandT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblFullname);
            this.Controls.Add(this.lblCnic);
            this.Controls.Add(this.lblEntry);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmEntry";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Person Entry Page";
            this.Load += new System.EventHandler(this.frmEntry_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblEntry;
        private System.Windows.Forms.Label lblCnic;
        private System.Windows.Forms.Label lblFullname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblEntryDandT;
        private System.Windows.Forms.RadioButton rdoIn;
        private System.Windows.Forms.RadioButton rdoOut;
        private System.Windows.Forms.TextBox txtEntryNo;
        private System.Windows.Forms.TextBox txtCnic;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Button btnAddentry;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aDDENTRYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dELETEENTRYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uPDATEENTRYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sEARCHENTRYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sHOWONEENTRYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sHOWALLToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ToolStripMenuItem dELETEONEENTRYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dELETEALLToolStripMenuItem;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}