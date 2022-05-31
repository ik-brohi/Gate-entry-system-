namespace GateEnterySystem
{
    partial class frmUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdate));
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.girdViewUpdate = new System.Windows.Forms.DataGridView();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblTime = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnUpdateEntry = new System.Windows.Forms.Button();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.txtCnic = new System.Windows.Forms.TextBox();
            this.rdoOut = new System.Windows.Forms.RadioButton();
            this.rdoIn = new System.Windows.Forms.RadioButton();
            this.lblEntryDandT = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblReason = new System.Windows.Forms.Label();
            this.lblFullname = new System.Windows.Forms.Label();
            this.lblCnic = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblHome = new System.Windows.Forms.Label();
            this.groupBoxUpdate = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.girdViewUpdate)).BeginInit();
            this.groupBoxUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Aqua;
            this.lblSearch.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.Red;
            this.lblSearch.Location = new System.Drawing.Point(291, 22);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(512, 29);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Enter  Entry  Number  To  Update  Record";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Location = new System.Drawing.Point(706, 60);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 34);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(286, 68);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(383, 22);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // girdViewUpdate
            // 
            this.girdViewUpdate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.girdViewUpdate.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.girdViewUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.girdViewUpdate.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.girdViewUpdate.Location = new System.Drawing.Point(12, 110);
            this.girdViewUpdate.Name = "girdViewUpdate";
            this.girdViewUpdate.RowHeadersWidth = 51;
            this.girdViewUpdate.RowTemplate.Height = 24;
            this.girdViewUpdate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.girdViewUpdate.Size = new System.Drawing.Size(1142, 94);
            this.girdViewUpdate.TabIndex = 3;
            this.girdViewUpdate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.girdViewUpdate_MouseClick);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.AccessibleName = "updatePage";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(379, 356);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(405, 28);
            this.dateTimePicker2.TabIndex = 35;
            this.dateTimePicker2.Visible = false;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // lblTime
            // 
            this.lblTime.AccessibleName = "updatePage";
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTime.Font = new System.Drawing.Font("Showcard Gothic", 9.75F);
            this.lblTime.ForeColor = System.Drawing.Color.Red;
            this.lblTime.Location = new System.Drawing.Point(232, 583);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(184, 21);
            this.lblTime.TabIndex = 34;
            this.lblTime.Text = "UPDATE Entry Time :";
            this.lblTime.Visible = false;
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.AccessibleName = "updatePage";
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.GreenYellow;
            this.dateTimePicker1.CustomFormat = "hh:mm&dd:mm:yyyy";
            this.dateTimePicker1.Location = new System.Drawing.Point(510, 522);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(405, 22);
            this.dateTimePicker1.TabIndex = 33;
            this.dateTimePicker1.Value = new System.DateTime(2022, 2, 8, 12, 30, 0, 0);
            this.dateTimePicker1.Visible = false;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnUpdateEntry
            // 
            this.btnUpdateEntry.AccessibleName = "updatePage";
            this.btnUpdateEntry.BackColor = System.Drawing.Color.Magenta;
            this.btnUpdateEntry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateEntry.Enabled = false;
            this.btnUpdateEntry.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEntry.ForeColor = System.Drawing.Color.White;
            this.btnUpdateEntry.Location = new System.Drawing.Point(746, 396);
            this.btnUpdateEntry.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateEntry.Name = "btnUpdateEntry";
            this.btnUpdateEntry.Size = new System.Drawing.Size(151, 51);
            this.btnUpdateEntry.TabIndex = 32;
            this.btnUpdateEntry.Text = " Update  Entry";
            this.btnUpdateEntry.UseVisualStyleBackColor = false;
            this.btnUpdateEntry.Visible = false;
            this.btnUpdateEntry.Click += new System.EventHandler(this.btnUpdateEntry_Click);
            // 
            // txtReason
            // 
            this.txtReason.AccessibleName = "updatePage";
            this.txtReason.Location = new System.Drawing.Point(510, 465);
            this.txtReason.Margin = new System.Windows.Forms.Padding(4);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(405, 22);
            this.txtReason.TabIndex = 31;
            this.txtReason.Visible = false;
            this.txtReason.TextChanged += new System.EventHandler(this.txtReason_TextChanged);
            this.txtReason.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReason_KeyPress);
            // 
            // txtContact
            // 
            this.txtContact.AccessibleName = "updatePage";
            this.txtContact.Location = new System.Drawing.Point(510, 407);
            this.txtContact.Margin = new System.Windows.Forms.Padding(4);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(405, 22);
            this.txtContact.TabIndex = 30;
            this.txtContact.Visible = false;
            this.txtContact.TextChanged += new System.EventHandler(this.txtContact_TextChanged);
            this.txtContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContact_KeyPress);
            // 
            // txtFullname
            // 
            this.txtFullname.AccessibleName = "updatePage";
            this.txtFullname.Location = new System.Drawing.Point(510, 354);
            this.txtFullname.Margin = new System.Windows.Forms.Padding(4);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(405, 22);
            this.txtFullname.TabIndex = 29;
            this.txtFullname.Visible = false;
            this.txtFullname.TextChanged += new System.EventHandler(this.txtFullname_TextChanged);
            this.txtFullname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFullname_KeyPress);
            // 
            // txtCnic
            // 
            this.txtCnic.AccessibleName = "updatePage";
            this.txtCnic.Location = new System.Drawing.Point(510, 290);
            this.txtCnic.Margin = new System.Windows.Forms.Padding(4);
            this.txtCnic.Name = "txtCnic";
            this.txtCnic.Size = new System.Drawing.Size(405, 22);
            this.txtCnic.TabIndex = 28;
            this.txtCnic.Visible = false;
            this.txtCnic.TextChanged += new System.EventHandler(this.txtCnic_TextChanged);
            this.txtCnic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCnic_KeyPress);
            // 
            // rdoOut
            // 
            this.rdoOut.AccessibleName = "updatePage";
            this.rdoOut.AutoSize = true;
            this.rdoOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rdoOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoOut.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoOut.ForeColor = System.Drawing.Color.Red;
            this.rdoOut.Location = new System.Drawing.Point(379, 396);
            this.rdoOut.Margin = new System.Windows.Forms.Padding(4);
            this.rdoOut.Name = "rdoOut";
            this.rdoOut.Size = new System.Drawing.Size(65, 25);
            this.rdoOut.TabIndex = 27;
            this.rdoOut.Text = "OUT";
            this.rdoOut.UseVisualStyleBackColor = false;
            this.rdoOut.Visible = false;
            this.rdoOut.CheckedChanged += new System.EventHandler(this.rdoOut_CheckedChanged);
            // 
            // rdoIn
            // 
            this.rdoIn.AccessibleName = "updatePage";
            this.rdoIn.AutoSize = true;
            this.rdoIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rdoIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoIn.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoIn.ForeColor = System.Drawing.Color.Red;
            this.rdoIn.Location = new System.Drawing.Point(105, 396);
            this.rdoIn.Margin = new System.Windows.Forms.Padding(4);
            this.rdoIn.Name = "rdoIn";
            this.rdoIn.Size = new System.Drawing.Size(48, 25);
            this.rdoIn.TabIndex = 26;
            this.rdoIn.Text = "IN";
            this.rdoIn.UseVisualStyleBackColor = false;
            this.rdoIn.Visible = false;
            this.rdoIn.CheckedChanged += new System.EventHandler(this.rdoIn_CheckedChanged);
            // 
            // lblEntryDandT
            // 
            this.lblEntryDandT.AccessibleName = "updatePage";
            this.lblEntryDandT.AutoSize = true;
            this.lblEntryDandT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblEntryDandT.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntryDandT.ForeColor = System.Drawing.Color.Red;
            this.lblEntryDandT.Location = new System.Drawing.Point(232, 533);
            this.lblEntryDandT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEntryDandT.Name = "lblEntryDandT";
            this.lblEntryDandT.Size = new System.Drawing.Size(186, 21);
            this.lblEntryDandT.TabIndex = 25;
            this.lblEntryDandT.Text = "UPDATE Entry Date :";
            this.lblEntryDandT.Visible = false;
            this.lblEntryDandT.Click += new System.EventHandler(this.lblEntryDandT_Click);
            // 
            // lblContact
            // 
            this.lblContact.AccessibleName = "updatePage";
            this.lblContact.AutoSize = true;
            this.lblContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblContact.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.ForeColor = System.Drawing.Color.Red;
            this.lblContact.Location = new System.Drawing.Point(232, 418);
            this.lblContact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(233, 21);
            this.lblContact.TabIndex = 24;
            this.lblContact.Text = "UPDATE Contact Number :";
            this.lblContact.Visible = false;
            this.lblContact.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblReason
            // 
            this.lblReason.AccessibleName = "updatePage";
            this.lblReason.AutoSize = true;
            this.lblReason.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblReason.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReason.ForeColor = System.Drawing.Color.Red;
            this.lblReason.Location = new System.Drawing.Point(232, 476);
            this.lblReason.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(207, 21);
            this.lblReason.TabIndex = 23;
            this.lblReason.Text = "UPDATE Entry Reason :";
            this.lblReason.Visible = false;
            this.lblReason.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblFullname
            // 
            this.lblFullname.AccessibleName = "updatePage";
            this.lblFullname.AutoSize = true;
            this.lblFullname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblFullname.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullname.ForeColor = System.Drawing.Color.Red;
            this.lblFullname.Location = new System.Drawing.Point(232, 365);
            this.lblFullname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(174, 21);
            this.lblFullname.TabIndex = 22;
            this.lblFullname.Text = "UPDATE Full Name :";
            this.lblFullname.Visible = false;
            this.lblFullname.Click += new System.EventHandler(this.lblFullname_Click);
            // 
            // lblCnic
            // 
            this.lblCnic.AccessibleName = "updatePage";
            this.lblCnic.AutoSize = true;
            this.lblCnic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblCnic.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnic.ForeColor = System.Drawing.Color.Red;
            this.lblCnic.Location = new System.Drawing.Point(232, 301);
            this.lblCnic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCnic.Name = "lblCnic";
            this.lblCnic.Size = new System.Drawing.Size(124, 21);
            this.lblCnic.TabIndex = 21;
            this.lblCnic.Text = "UPDATE CNIC :";
            this.lblCnic.Visible = false;
            this.lblCnic.Click += new System.EventHandler(this.lblCnic_Click);
            // 
            // btnHome
            // 
            this.btnHome.AccessibleDescription = "";
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Location = new System.Drawing.Point(23, 22);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(104, 64);
            this.btnHome.TabIndex = 36;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblHome.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.Color.Red;
            this.lblHome.Location = new System.Drawing.Point(35, 81);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(75, 26);
            this.lblHome.TabIndex = 37;
            this.lblHome.Text = "Home ";
            this.lblHome.Click += new System.EventHandler(this.lblHome_Click);
            // 
            // groupBoxUpdate
            // 
            this.groupBoxUpdate.AccessibleName = "updatePage";
            this.groupBoxUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxUpdate.BackgroundImage")));
            this.groupBoxUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxUpdate.Controls.Add(this.btnUpdateEntry);
            this.groupBoxUpdate.Controls.Add(this.dateTimePicker2);
            this.groupBoxUpdate.Controls.Add(this.rdoIn);
            this.groupBoxUpdate.Controls.Add(this.rdoOut);
            this.groupBoxUpdate.Font = new System.Drawing.Font("Showcard Gothic", 9.75F);
            this.groupBoxUpdate.ForeColor = System.Drawing.Color.White;
            this.groupBoxUpdate.Location = new System.Drawing.Point(131, 226);
            this.groupBoxUpdate.Name = "groupBoxUpdate";
            this.groupBoxUpdate.Size = new System.Drawing.Size(904, 455);
            this.groupBoxUpdate.TabIndex = 38;
            this.groupBoxUpdate.TabStop = false;
            this.groupBoxUpdate.Text = "Click The Row above To Update The Record";
            this.groupBoxUpdate.Visible = false;
            this.groupBoxUpdate.Enter += new System.EventHandler(this.groupBoxUpdate_Enter);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1141, 755);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 687);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1141, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Stencil", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(996, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 44;
            this.label1.Text = "label1";
            // 
            // frmUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1167, 781);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtFullname);
            this.Controls.Add(this.txtCnic);
            this.Controls.Add(this.lblEntryDandT);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.lblFullname);
            this.Controls.Add(this.lblCnic);
            this.Controls.Add(this.girdViewUpdate);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.groupBoxUpdate);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "frmUpdate";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Entry";
            this.Load += new System.EventHandler(this.frmUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.girdViewUpdate)).EndInit();
            this.groupBoxUpdate.ResumeLayout(false);
            this.groupBoxUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView girdViewUpdate;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblHome;
        public System.Windows.Forms.DateTimePicker dateTimePicker2;
        public System.Windows.Forms.Label lblTime;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.Button btnUpdateEntry;
        public System.Windows.Forms.TextBox txtReason;
        public System.Windows.Forms.TextBox txtContact;
        public System.Windows.Forms.TextBox txtFullname;
        public System.Windows.Forms.TextBox txtCnic;
        public System.Windows.Forms.RadioButton rdoOut;
        public System.Windows.Forms.RadioButton rdoIn;
        public System.Windows.Forms.Label lblEntryDandT;
        public System.Windows.Forms.Label lblContact;
        public System.Windows.Forms.Label lblReason;
        public System.Windows.Forms.Label lblFullname;
        public System.Windows.Forms.Label lblCnic;
        public System.Windows.Forms.GroupBox groupBoxUpdate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}