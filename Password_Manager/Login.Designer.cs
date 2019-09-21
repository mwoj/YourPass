namespace Password_Manager
{
    partial class Login
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtboxMasterPass = new System.Windows.Forms.TextBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.lblProfile = new System.Windows.Forms.Label();
            this.menuPasswordDB = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnlPasswordUnderbar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDragbar = new System.Windows.Forms.Panel();
            this.passwordVaultWatcher = new System.IO.FileSystemWatcher();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlDragbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordVaultWatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.Location = new System.Drawing.Point(39, 234);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(403, 29);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Access Password Bank";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // txtboxMasterPass
            // 
            this.txtboxMasterPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxMasterPass.BackColor = System.Drawing.SystemColors.Control;
            this.txtboxMasterPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxMasterPass.Location = new System.Drawing.Point(9, 53);
            this.txtboxMasterPass.Name = "txtboxMasterPass";
            this.txtboxMasterPass.Size = new System.Drawing.Size(440, 13);
            this.txtboxMasterPass.TabIndex = 1;
            this.txtboxMasterPass.UseSystemPasswordChar = true;
            this.txtboxMasterPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtboxMasterPass_KeyPress);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(12, 12);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(264, 28);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome to YourPass V";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(448, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(24, 24);
            this.btnExit.TabIndex = 4;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Location = new System.Drawing.Point(418, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(24, 24);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.Location = new System.Drawing.Point(6, 26);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(144, 13);
            this.lblProfile.TabIndex = 5;
            this.lblProfile.Text = "Select your Password Profile:";
            // 
            // menuPasswordDB
            // 
            this.menuPasswordDB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuPasswordDB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menuPasswordDB.FormattingEnabled = true;
            this.menuPasswordDB.Items.AddRange(new object[] {
            "<New Password List>"});
            this.menuPasswordDB.Location = new System.Drawing.Point(9, 42);
            this.menuPasswordDB.Name = "menuPasswordDB";
            this.menuPasswordDB.Size = new System.Drawing.Size(440, 21);
            this.menuPasswordDB.TabIndex = 0;
            this.menuPasswordDB.SelectedValueChanged += new System.EventHandler(this.MenuPasswordDB_SelectedValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblProfile);
            this.groupBox1.Controls.Add(this.menuPasswordDB);
            this.groupBox1.Location = new System.Drawing.Point(17, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 73);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.pnlPasswordUnderbar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtboxMasterPass);
            this.groupBox2.Location = new System.Drawing.Point(17, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(455, 85);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Step 2";
            // 
            // pnlPasswordUnderbar
            // 
            this.pnlPasswordUnderbar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlPasswordUnderbar.Location = new System.Drawing.Point(9, 70);
            this.pnlPasswordUnderbar.Name = "pnlPasswordUnderbar";
            this.pnlPasswordUnderbar.Size = new System.Drawing.Size(440, 1);
            this.pnlPasswordUnderbar.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Master Password:";
            // 
            // pnlDragbar
            // 
            this.pnlDragbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDragbar.Controls.Add(this.lblWelcome);
            this.pnlDragbar.Controls.Add(this.btnMinimize);
            this.pnlDragbar.Controls.Add(this.btnExit);
            this.pnlDragbar.Location = new System.Drawing.Point(0, 0);
            this.pnlDragbar.Name = "pnlDragbar";
            this.pnlDragbar.Size = new System.Drawing.Size(485, 49);
            this.pnlDragbar.TabIndex = 9;
            // 
            // passwordVaultWatcher
            // 
            this.passwordVaultWatcher.EnableRaisingEvents = true;
            this.passwordVaultWatcher.SynchronizingObject = this;
            this.passwordVaultWatcher.Created += new System.IO.FileSystemEventHandler(this.PasswordVaultWatcher_Created);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 287);
            this.ControlBox = false;
            this.Controls.Add(this.pnlDragbar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Manager - Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.Shown += new System.EventHandler(this.Login_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlDragbar.ResumeLayout(false);
            this.pnlDragbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordVaultWatcher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtboxMasterPass;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.ComboBox menuPasswordDB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlDragbar;
        private System.IO.FileSystemWatcher passwordVaultWatcher;
        private System.Windows.Forms.Panel pnlPasswordUnderbar;
    }
}