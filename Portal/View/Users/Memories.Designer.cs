namespace Portal.View.Users
{
    partial class Memories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Memories));
            this.DGV = new System.Windows.Forms.DataGridView();
            this.Header = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblId = new System.Windows.Forms.Label();
            this.History = new System.Windows.Forms.PictureBox();
            this.LbluserId = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TSM = new System.Windows.Forms.RichTextBox();
            this.TMN = new System.Windows.Forms.TextBox();
            this.LblSMS = new System.Windows.Forms.Label();
            this.LblPhone = new System.Windows.Forms.Label();
            this.BDel = new System.Windows.Forms.Button();
            this.BEdit = new System.Windows.Forms.Button();
            this.BSave = new System.Windows.Forms.Button();
            this.BImport = new System.Windows.Forms.Button();
            this.Count = new System.Windows.Forms.Label();
            this.LblCC = new System.Windows.Forms.Label();
            this.CMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.maxmizesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NI = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.History)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            this.CMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(12, 258);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(500, 274);
            this.DGV.TabIndex = 103;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick);
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Header.Controls.Add(this.pictureBox1);
            this.Header.Controls.Add(this.LblId);
            this.Header.Controls.Add(this.History);
            this.Header.Controls.Add(this.LbluserId);
            this.Header.Controls.Add(this.LblName);
            this.Header.Controls.Add(this.pictureBox2);
            this.Header.Controls.Add(this.Close);
            this.Header.Controls.Add(this.panel1);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(524, 50);
            this.Header.TabIndex = 102;
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            this.Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Header_MouseMove);
            this.Header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Header_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Clients.Properties.Resources.back_96px;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(392, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 80;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LblId
            // 
            this.LblId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LblId.AutoSize = true;
            this.LblId.BackColor = System.Drawing.Color.Transparent;
            this.LblId.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblId.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.LblId.ForeColor = System.Drawing.Color.MediumOrchid;
            this.LblId.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblId.Location = new System.Drawing.Point(295, 16);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(21, 24);
            this.LblId.TabIndex = 79;
            this.LblId.Text = "0";
            this.LblId.Visible = false;
            // 
            // History
            // 
            this.History.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.History.BackColor = System.Drawing.Color.Transparent;
            this.History.Cursor = System.Windows.Forms.Cursors.Hand;
            this.History.Image = global::Clients.Properties.Resources.processor_96px;
            this.History.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.History.Location = new System.Drawing.Point(12, 10);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(39, 37);
            this.History.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.History.TabIndex = 78;
            this.History.TabStop = false;
            this.History.Click += new System.EventHandler(this.History_Click);
            // 
            // LbluserId
            // 
            this.LbluserId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LbluserId.AutoSize = true;
            this.LbluserId.BackColor = System.Drawing.Color.Transparent;
            this.LbluserId.Cursor = System.Windows.Forms.Cursors.Default;
            this.LbluserId.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.LbluserId.ForeColor = System.Drawing.Color.MediumOrchid;
            this.LbluserId.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LbluserId.Location = new System.Drawing.Point(268, 16);
            this.LbluserId.Name = "LbluserId";
            this.LbluserId.Size = new System.Drawing.Size(21, 24);
            this.LbluserId.TabIndex = 77;
            this.LbluserId.Text = "0";
            this.LbluserId.Visible = false;
            // 
            // LblName
            // 
            this.LblName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LblName.AutoSize = true;
            this.LblName.BackColor = System.Drawing.Color.Transparent;
            this.LblName.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.LblName.ForeColor = System.Drawing.Color.MediumOrchid;
            this.LblName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblName.Location = new System.Drawing.Point(55, 16);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(207, 24);
            this.LblName.TabIndex = 74;
            this.LblName.Text = "SMS Employee Portal";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(437, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 74;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Image = ((System.Drawing.Image)(resources.GetObject("Close.Image")));
            this.Close.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Close.Location = new System.Drawing.Point(482, 10);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(39, 37);
            this.Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Close.TabIndex = 72;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 3);
            this.panel1.TabIndex = 71;
            // 
            // TSM
            // 
            this.TSM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TSM.Enabled = false;
            this.TSM.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSM.Location = new System.Drawing.Point(185, 99);
            this.TSM.MaxLength = 480;
            this.TSM.Name = "TSM";
            this.TSM.Size = new System.Drawing.Size(327, 67);
            this.TSM.TabIndex = 108;
            this.TSM.Text = "";
            this.TSM.TextChanged += new System.EventHandler(this.TSM_TextChanged);
            this.TSM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TSM_KeyPress);
            // 
            // TMN
            // 
            this.TMN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TMN.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMN.Location = new System.Drawing.Point(185, 57);
            this.TMN.MaxLength = 50;
            this.TMN.Multiline = true;
            this.TMN.Name = "TMN";
            this.TMN.Size = new System.Drawing.Size(327, 29);
            this.TMN.TabIndex = 107;
            this.TMN.TextChanged += new System.EventHandler(this.TMN_TextChanged);
            // 
            // LblSMS
            // 
            this.LblSMS.AutoSize = true;
            this.LblSMS.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.LblSMS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LblSMS.Location = new System.Drawing.Point(3, 105);
            this.LblSMS.Name = "LblSMS";
            this.LblSMS.Size = new System.Drawing.Size(176, 24);
            this.LblSMS.TabIndex = 105;
            this.LblSMS.Text = "Memory Stampa : ";
            // 
            // LblPhone
            // 
            this.LblPhone.AutoSize = true;
            this.LblPhone.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.LblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LblPhone.Location = new System.Drawing.Point(3, 57);
            this.LblPhone.Name = "LblPhone";
            this.LblPhone.Size = new System.Drawing.Size(160, 24);
            this.LblPhone.TabIndex = 106;
            this.LblPhone.Text = "Memory Name : ";
            // 
            // BDel
            // 
            this.BDel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BDel.FlatAppearance.BorderSize = 0;
            this.BDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BDel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BDel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BDel.Image = global::Clients.Properties.Resources.delete_32px;
            this.BDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BDel.Location = new System.Drawing.Point(250, 206);
            this.BDel.Name = "BDel";
            this.BDel.Size = new System.Drawing.Size(107, 46);
            this.BDel.TabIndex = 111;
            this.BDel.Text = "Delete";
            this.BDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BDel.UseVisualStyleBackColor = true;
            this.BDel.Visible = false;
            this.BDel.Click += new System.EventHandler(this.BDel_Click);
            // 
            // BEdit
            // 
            this.BEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BEdit.FlatAppearance.BorderSize = 0;
            this.BEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEdit.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BEdit.Image = global::Clients.Properties.Resources.edit_property_32px;
            this.BEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BEdit.Location = new System.Drawing.Point(156, 206);
            this.BEdit.Name = "BEdit";
            this.BEdit.Size = new System.Drawing.Size(88, 46);
            this.BEdit.TabIndex = 110;
            this.BEdit.Text = "Edit";
            this.BEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BEdit.UseVisualStyleBackColor = true;
            this.BEdit.Visible = false;
            this.BEdit.Click += new System.EventHandler(this.BEdit_Click);
            // 
            // BSave
            // 
            this.BSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BSave.Enabled = false;
            this.BSave.FlatAppearance.BorderSize = 0;
            this.BSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSave.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BSave.Image = global::Clients.Properties.Resources.save_32px;
            this.BSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BSave.Location = new System.Drawing.Point(52, 206);
            this.BSave.Name = "BSave";
            this.BSave.Size = new System.Drawing.Size(98, 46);
            this.BSave.TabIndex = 109;
            this.BSave.Text = "Save";
            this.BSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BSave.UseVisualStyleBackColor = true;
            this.BSave.Click += new System.EventHandler(this.BSave_Click);
            // 
            // BImport
            // 
            this.BImport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BImport.FlatAppearance.BorderSize = 0;
            this.BImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BImport.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BImport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BImport.Image = global::Clients.Properties.Resources.import_32px;
            this.BImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BImport.Location = new System.Drawing.Point(363, 206);
            this.BImport.Name = "BImport";
            this.BImport.Size = new System.Drawing.Size(113, 46);
            this.BImport.TabIndex = 104;
            this.BImport.Text = "Import";
            this.BImport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BImport.UseVisualStyleBackColor = true;
            this.BImport.Click += new System.EventHandler(this.BImport_Click);
            // 
            // Count
            // 
            this.Count.AutoSize = true;
            this.Count.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.Count.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Count.Location = new System.Drawing.Point(191, 176);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(21, 24);
            this.Count.TabIndex = 113;
            this.Count.Text = "0";
            // 
            // LblCC
            // 
            this.LblCC.AutoSize = true;
            this.LblCC.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.LblCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LblCC.Location = new System.Drawing.Point(12, 176);
            this.LblCC.Name = "LblCC";
            this.LblCC.Size = new System.Drawing.Size(173, 24);
            this.LblCC.TabIndex = 112;
            this.LblCC.Text = "Character Count :";
            // 
            // CMS
            // 
            this.CMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.CMS.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maxmizesToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.CMS.Name = "CMS";
            this.CMS.Size = new System.Drawing.Size(160, 52);
            // 
            // maxmizesToolStripMenuItem
            // 
            this.maxmizesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.maxmizesToolStripMenuItem.Image = global::Clients.Properties.Resources.maximize_window_96px;
            this.maxmizesToolStripMenuItem.Name = "maxmizesToolStripMenuItem";
            this.maxmizesToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.maxmizesToolStripMenuItem.Text = "Maxmizes";
            this.maxmizesToolStripMenuItem.Click += new System.EventHandler(this.maxmizesToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.closeToolStripMenuItem.Image = global::Clients.Properties.Resources.cancel_96px;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // NI
            // 
            this.NI.ContextMenuStrip = this.CMS;
            this.NI.Icon = ((System.Drawing.Icon)(resources.GetObject("NI.Icon")));
            this.NI.Text = "Portal";
            this.NI.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NI_MouseClick);
            // 
            // Memories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(188)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(524, 544);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.LblCC);
            this.Controls.Add(this.BDel);
            this.Controls.Add(this.BEdit);
            this.Controls.Add(this.BSave);
            this.Controls.Add(this.TSM);
            this.Controls.Add(this.TMN);
            this.Controls.Add(this.LblSMS);
            this.Controls.Add(this.LblPhone);
            this.Controls.Add(this.BImport);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Memories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memories";
            this.Load += new System.EventHandler(this.Memories_Load);
            this.Click += new System.EventHandler(this.Memories_Click);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.History)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            this.CMS.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.PictureBox History;
        private System.Windows.Forms.Label LbluserId;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BImport;
        private System.Windows.Forms.RichTextBox TSM;
        private System.Windows.Forms.TextBox TMN;
        private System.Windows.Forms.Label LblSMS;
        private System.Windows.Forms.Label LblPhone;
        private System.Windows.Forms.Button BSave;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.Button BEdit;
        private System.Windows.Forms.Button BDel;
        private System.Windows.Forms.Label Count;
        private System.Windows.Forms.Label LblCC;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip CMS;
        private System.Windows.Forms.ToolStripMenuItem maxmizesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon NI;
    }
}