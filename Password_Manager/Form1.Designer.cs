namespace Password_Manager
{
    partial class Form1
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlDragbar = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.lblOptions = new System.Windows.Forms.Label();
            this.pnlMenuItem2 = new System.Windows.Forms.Panel();
            this.picboxAddNewPassword = new System.Windows.Forms.PictureBox();
            this.lblAddNewService = new System.Windows.Forms.Label();
            this.pnlMenuItem1 = new System.Windows.Forms.Panel();
            this.picboxPasswordVault = new System.Windows.Forms.PictureBox();
            this.lblVault = new System.Windows.Forms.Label();
            this.pnlPasswordVault = new System.Windows.Forms.Panel();
            this.grpbxPasswordRetrieval = new System.Windows.Forms.GroupBox();
            this.lblPasswordRetrieved = new System.Windows.Forms.Label();
            this.btnDisposePassword = new System.Windows.Forms.Button();
            this.txtboxPasswordRetrieval = new System.Windows.Forms.TextBox();
            this.pnlUnderPasswordRetrieval = new System.Windows.Forms.Panel();
            this.btnRetrievePassword = new System.Windows.Forms.Button();
            this.txtboxServiceName = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pnlUnderSearchbar = new System.Windows.Forms.Panel();
            this.dgvPasswordVault = new System.Windows.Forms.DataGridView();
            this.clmnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMenuItem3 = new System.Windows.Forms.Panel();
            this.picboxEditEntry = new System.Windows.Forms.PictureBox();
            this.lblEditEntry = new System.Windows.Forms.Label();
            this.pnlDragbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlOptions.SuspendLayout();
            this.pnlMenuItem2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAddNewPassword)).BeginInit();
            this.pnlMenuItem1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPasswordVault)).BeginInit();
            this.pnlPasswordVault.SuspendLayout();
            this.grpbxPasswordRetrieval.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasswordVault)).BeginInit();
            this.pnlMenuItem3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxEditEntry)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(756, 15);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 32);
            this.btnExit.TabIndex = 0;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Location = new System.Drawing.Point(718, 15);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(32, 32);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Text = "—";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(109, 28);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "YourPass";
            // 
            // pnlDragbar
            // 
            this.pnlDragbar.Controls.Add(this.lblTitle);
            this.pnlDragbar.Controls.Add(this.btnExit);
            this.pnlDragbar.Controls.Add(this.btnMinimize);
            this.pnlDragbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDragbar.Location = new System.Drawing.Point(0, 0);
            this.pnlDragbar.Name = "pnlDragbar";
            this.pnlDragbar.Size = new System.Drawing.Size(800, 64);
            this.pnlDragbar.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 66);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Gray;
            this.splitContainer1.Panel1.Controls.Add(this.pnlMenuItem3);
            this.splitContainer1.Panel1.Controls.Add(this.pnlOptions);
            this.splitContainer1.Panel1.Controls.Add(this.pnlMenuItem2);
            this.splitContainer1.Panel1.Controls.Add(this.pnlMenuItem1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pnlPasswordVault);
            this.splitContainer1.Size = new System.Drawing.Size(800, 512);
            this.splitContainer1.SplitterDistance = 196;
            this.splitContainer1.TabIndex = 5;
            // 
            // pnlOptions
            // 
            this.pnlOptions.Controls.Add(this.lblOptions);
            this.pnlOptions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlOptions.Location = new System.Drawing.Point(0, 459);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(196, 53);
            this.pnlOptions.TabIndex = 2;
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptions.Location = new System.Drawing.Point(58, 15);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(56, 18);
            this.lblOptions.TabIndex = 2;
            this.lblOptions.Text = "Options";
            this.lblOptions.Visible = false;
            // 
            // pnlMenuItem2
            // 
            this.pnlMenuItem2.BackColor = System.Drawing.Color.DarkGray;
            this.pnlMenuItem2.Controls.Add(this.picboxAddNewPassword);
            this.pnlMenuItem2.Controls.Add(this.lblAddNewService);
            this.pnlMenuItem2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuItem2.Location = new System.Drawing.Point(0, 53);
            this.pnlMenuItem2.Name = "pnlMenuItem2";
            this.pnlMenuItem2.Size = new System.Drawing.Size(196, 53);
            this.pnlMenuItem2.TabIndex = 1;
            this.pnlMenuItem2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PnlMenuItem2_MouseClick);
            this.pnlMenuItem2.MouseEnter += new System.EventHandler(this.PnlMenuItem2_MouseEnter);
            this.pnlMenuItem2.MouseLeave += new System.EventHandler(this.PnlMenuItem2_MouseLeave);
            // 
            // picboxAddNewPassword
            // 
            this.picboxAddNewPassword.Location = new System.Drawing.Point(3, 4);
            this.picboxAddNewPassword.Name = "picboxAddNewPassword";
            this.picboxAddNewPassword.Size = new System.Drawing.Size(45, 45);
            this.picboxAddNewPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxAddNewPassword.TabIndex = 4;
            this.picboxAddNewPassword.TabStop = false;
            this.picboxAddNewPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PicboxAddNewPassword_MouseClick);
            this.picboxAddNewPassword.MouseEnter += new System.EventHandler(this.PicboxAddNewPassword_MouseEnter);
            // 
            // lblAddNewService
            // 
            this.lblAddNewService.AutoSize = true;
            this.lblAddNewService.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewService.Location = new System.Drawing.Point(62, 17);
            this.lblAddNewService.Name = "lblAddNewService";
            this.lblAddNewService.Size = new System.Drawing.Size(103, 18);
            this.lblAddNewService.TabIndex = 1;
            this.lblAddNewService.Text = "Add a Password";
            this.lblAddNewService.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LblAddNewService_MouseClick);
            this.lblAddNewService.MouseEnter += new System.EventHandler(this.LblAddNewService_MouseEnter);
            // 
            // pnlMenuItem1
            // 
            this.pnlMenuItem1.BackColor = System.Drawing.Color.LightGray;
            this.pnlMenuItem1.Controls.Add(this.picboxPasswordVault);
            this.pnlMenuItem1.Controls.Add(this.lblVault);
            this.pnlMenuItem1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuItem1.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuItem1.Name = "pnlMenuItem1";
            this.pnlMenuItem1.Size = new System.Drawing.Size(196, 53);
            this.pnlMenuItem1.TabIndex = 0;
            this.pnlMenuItem1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PnlMenuItem1_MouseClick);
            this.pnlMenuItem1.MouseEnter += new System.EventHandler(this.PnlMenuItem1_MouseEnter);
            this.pnlMenuItem1.MouseLeave += new System.EventHandler(this.PnlMenuItem1_MouseLeave);
            // 
            // picboxPasswordVault
            // 
            this.picboxPasswordVault.Location = new System.Drawing.Point(3, 4);
            this.picboxPasswordVault.Name = "picboxPasswordVault";
            this.picboxPasswordVault.Size = new System.Drawing.Size(45, 45);
            this.picboxPasswordVault.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxPasswordVault.TabIndex = 3;
            this.picboxPasswordVault.TabStop = false;
            this.picboxPasswordVault.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PicboxPasswordVault_MouseClick);
            this.picboxPasswordVault.MouseEnter += new System.EventHandler(this.PicboxPasswordVault_MouseEnter);
            // 
            // lblVault
            // 
            this.lblVault.AutoSize = true;
            this.lblVault.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVault.Location = new System.Drawing.Point(62, 17);
            this.lblVault.Name = "lblVault";
            this.lblVault.Size = new System.Drawing.Size(100, 18);
            this.lblVault.TabIndex = 0;
            this.lblVault.Text = "Password Vault";
            this.lblVault.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LblVault_MouseClick);
            this.lblVault.MouseEnter += new System.EventHandler(this.LblVault_MouseEnter);
            // 
            // pnlPasswordVault
            // 
            this.pnlPasswordVault.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPasswordVault.Controls.Add(this.grpbxPasswordRetrieval);
            this.pnlPasswordVault.Controls.Add(this.txtboxServiceName);
            this.pnlPasswordVault.Controls.Add(this.lblSearch);
            this.pnlPasswordVault.Controls.Add(this.pnlUnderSearchbar);
            this.pnlPasswordVault.Controls.Add(this.dgvPasswordVault);
            this.pnlPasswordVault.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPasswordVault.Location = new System.Drawing.Point(0, 0);
            this.pnlPasswordVault.Name = "pnlPasswordVault";
            this.pnlPasswordVault.Size = new System.Drawing.Size(600, 512);
            this.pnlPasswordVault.TabIndex = 1;
            // 
            // grpbxPasswordRetrieval
            // 
            this.grpbxPasswordRetrieval.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbxPasswordRetrieval.Controls.Add(this.lblPasswordRetrieved);
            this.grpbxPasswordRetrieval.Controls.Add(this.btnDisposePassword);
            this.grpbxPasswordRetrieval.Controls.Add(this.txtboxPasswordRetrieval);
            this.grpbxPasswordRetrieval.Controls.Add(this.pnlUnderPasswordRetrieval);
            this.grpbxPasswordRetrieval.Controls.Add(this.btnRetrievePassword);
            this.grpbxPasswordRetrieval.Location = new System.Drawing.Point(3, 381);
            this.grpbxPasswordRetrieval.Name = "grpbxPasswordRetrieval";
            this.grpbxPasswordRetrieval.Size = new System.Drawing.Size(591, 125);
            this.grpbxPasswordRetrieval.TabIndex = 10;
            this.grpbxPasswordRetrieval.TabStop = false;
            this.grpbxPasswordRetrieval.Text = "Password Retrieval";
            // 
            // lblPasswordRetrieved
            // 
            this.lblPasswordRetrieved.AutoSize = true;
            this.lblPasswordRetrieved.Location = new System.Drawing.Point(6, 26);
            this.lblPasswordRetrieved.Name = "lblPasswordRetrieved";
            this.lblPasswordRetrieved.Size = new System.Drawing.Size(232, 13);
            this.lblPasswordRetrieved.TabIndex = 8;
            this.lblPasswordRetrieved.Text = "Password Retrieved from: No Service Selected.";
            // 
            // btnDisposePassword
            // 
            this.btnDisposePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisposePassword.Location = new System.Drawing.Point(450, 80);
            this.btnDisposePassword.Name = "btnDisposePassword";
            this.btnDisposePassword.Size = new System.Drawing.Size(133, 29);
            this.btnDisposePassword.TabIndex = 9;
            this.btnDisposePassword.Text = "Dispose of Password";
            this.btnDisposePassword.UseVisualStyleBackColor = true;
            this.btnDisposePassword.Click += new System.EventHandler(this.BtnDisposePassword_Click);
            // 
            // txtboxPasswordRetrieval
            // 
            this.txtboxPasswordRetrieval.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxPasswordRetrieval.BackColor = System.Drawing.Color.Gainsboro;
            this.txtboxPasswordRetrieval.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxPasswordRetrieval.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxPasswordRetrieval.Location = new System.Drawing.Point(9, 48);
            this.txtboxPasswordRetrieval.Name = "txtboxPasswordRetrieval";
            this.txtboxPasswordRetrieval.ReadOnly = true;
            this.txtboxPasswordRetrieval.Size = new System.Drawing.Size(574, 24);
            this.txtboxPasswordRetrieval.TabIndex = 5;
            // 
            // pnlUnderPasswordRetrieval
            // 
            this.pnlUnderPasswordRetrieval.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUnderPasswordRetrieval.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlUnderPasswordRetrieval.Location = new System.Drawing.Point(9, 72);
            this.pnlUnderPasswordRetrieval.Name = "pnlUnderPasswordRetrieval";
            this.pnlUnderPasswordRetrieval.Size = new System.Drawing.Size(574, 2);
            this.pnlUnderPasswordRetrieval.TabIndex = 6;
            // 
            // btnRetrievePassword
            // 
            this.btnRetrievePassword.Location = new System.Drawing.Point(9, 80);
            this.btnRetrievePassword.Name = "btnRetrievePassword";
            this.btnRetrievePassword.Size = new System.Drawing.Size(217, 29);
            this.btnRetrievePassword.TabIndex = 7;
            this.btnRetrievePassword.Text = "Retrieve Password From Selected Item";
            this.btnRetrievePassword.UseVisualStyleBackColor = true;
            this.btnRetrievePassword.Click += new System.EventHandler(this.BtnRetrievePassword_Click);
            // 
            // txtboxServiceName
            // 
            this.txtboxServiceName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxServiceName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtboxServiceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxServiceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxServiceName.Location = new System.Drawing.Point(6, 29);
            this.txtboxServiceName.Name = "txtboxServiceName";
            this.txtboxServiceName.Size = new System.Drawing.Size(588, 22);
            this.txtboxServiceName.TabIndex = 4;
            this.txtboxServiceName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtboxServiceName_KeyPress);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(2, 6);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(156, 20);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Search for a Service:";
            // 
            // pnlUnderSearchbar
            // 
            this.pnlUnderSearchbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUnderSearchbar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlUnderSearchbar.Location = new System.Drawing.Point(6, 51);
            this.pnlUnderSearchbar.Name = "pnlUnderSearchbar";
            this.pnlUnderSearchbar.Size = new System.Drawing.Size(588, 1);
            this.pnlUnderSearchbar.TabIndex = 1;
            // 
            // dgvPasswordVault
            // 
            this.dgvPasswordVault.AllowUserToAddRows = false;
            this.dgvPasswordVault.AllowUserToDeleteRows = false;
            this.dgvPasswordVault.AllowUserToResizeColumns = false;
            this.dgvPasswordVault.AllowUserToResizeRows = false;
            this.dgvPasswordVault.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPasswordVault.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPasswordVault.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnName,
            this.clmnUsername,
            this.clmnEmail});
            this.dgvPasswordVault.Location = new System.Drawing.Point(6, 58);
            this.dgvPasswordVault.Name = "dgvPasswordVault";
            this.dgvPasswordVault.ReadOnly = true;
            this.dgvPasswordVault.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPasswordVault.Size = new System.Drawing.Size(588, 317);
            this.dgvPasswordVault.TabIndex = 0;
            // 
            // clmnName
            // 
            this.clmnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnName.HeaderText = "Service Name";
            this.clmnName.Name = "clmnName";
            this.clmnName.ReadOnly = true;
            this.clmnName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmnName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // clmnUsername
            // 
            this.clmnUsername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnUsername.HeaderText = "Username";
            this.clmnUsername.Name = "clmnUsername";
            this.clmnUsername.ReadOnly = true;
            this.clmnUsername.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmnUsername.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // clmnEmail
            // 
            this.clmnEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnEmail.HeaderText = "Email Address";
            this.clmnEmail.Name = "clmnEmail";
            this.clmnEmail.ReadOnly = true;
            this.clmnEmail.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmnEmail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // pnlMenuItem3
            // 
            this.pnlMenuItem3.BackColor = System.Drawing.Color.DarkGray;
            this.pnlMenuItem3.Controls.Add(this.picboxEditEntry);
            this.pnlMenuItem3.Controls.Add(this.lblEditEntry);
            this.pnlMenuItem3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuItem3.Location = new System.Drawing.Point(0, 106);
            this.pnlMenuItem3.Name = "pnlMenuItem3";
            this.pnlMenuItem3.Size = new System.Drawing.Size(196, 53);
            this.pnlMenuItem3.TabIndex = 5;
            this.pnlMenuItem3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PnlEditEntry_MouseClick);
            this.pnlMenuItem3.MouseEnter += new System.EventHandler(this.PnlEditEntry_MouseEnter);
            this.pnlMenuItem3.MouseLeave += new System.EventHandler(this.PnlEditEntry_MouseLeave);
            // 
            // picboxEditEntry
            // 
            this.picboxEditEntry.Location = new System.Drawing.Point(3, 4);
            this.picboxEditEntry.Name = "picboxEditEntry";
            this.picboxEditEntry.Size = new System.Drawing.Size(45, 45);
            this.picboxEditEntry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxEditEntry.TabIndex = 4;
            this.picboxEditEntry.TabStop = false;
            this.picboxEditEntry.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PicboxEditEntry_MouseClick);
            this.picboxEditEntry.MouseEnter += new System.EventHandler(this.PicboxEditEntry_MouseEnter);
            // 
            // lblEditEntry
            // 
            this.lblEditEntry.AutoSize = true;
            this.lblEditEntry.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditEntry.Location = new System.Drawing.Point(62, 17);
            this.lblEditEntry.Name = "lblEditEntry";
            this.lblEditEntry.Size = new System.Drawing.Size(66, 18);
            this.lblEditEntry.TabIndex = 1;
            this.lblEditEntry.Text = "Edit Entry";
            this.lblEditEntry.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LblEditEntry_MouseClick);
            this.lblEditEntry.MouseEnter += new System.EventHandler(this.LblEditEntry_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 578);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnlDragbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(582, 386);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YourPass";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlDragbar.ResumeLayout(false);
            this.pnlDragbar.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlOptions.ResumeLayout(false);
            this.pnlOptions.PerformLayout();
            this.pnlMenuItem2.ResumeLayout(false);
            this.pnlMenuItem2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAddNewPassword)).EndInit();
            this.pnlMenuItem1.ResumeLayout(false);
            this.pnlMenuItem1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPasswordVault)).EndInit();
            this.pnlPasswordVault.ResumeLayout(false);
            this.pnlPasswordVault.PerformLayout();
            this.grpbxPasswordRetrieval.ResumeLayout(false);
            this.grpbxPasswordRetrieval.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasswordVault)).EndInit();
            this.pnlMenuItem3.ResumeLayout(false);
            this.pnlMenuItem3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxEditEntry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlDragbar;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.Panel pnlMenuItem2;
        private System.Windows.Forms.Label lblAddNewService;
        private System.Windows.Forms.Panel pnlMenuItem1;
        private System.Windows.Forms.Label lblVault;
        private System.Windows.Forms.PictureBox picboxPasswordVault;
        private System.Windows.Forms.Panel pnlPasswordVault;
        private System.Windows.Forms.TextBox txtboxServiceName;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Panel pnlUnderSearchbar;
        private System.Windows.Forms.PictureBox picboxAddNewPassword;
        private System.Windows.Forms.DataGridView dgvPasswordVault;
        private System.Windows.Forms.GroupBox grpbxPasswordRetrieval;
        private System.Windows.Forms.Label lblPasswordRetrieved;
        private System.Windows.Forms.Button btnDisposePassword;
        private System.Windows.Forms.TextBox txtboxPasswordRetrieval;
        private System.Windows.Forms.Panel pnlUnderPasswordRetrieval;
        private System.Windows.Forms.Button btnRetrievePassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEmail;
        private System.Windows.Forms.Panel pnlMenuItem3;
        private System.Windows.Forms.PictureBox picboxEditEntry;
        private System.Windows.Forms.Label lblEditEntry;
    }
}

