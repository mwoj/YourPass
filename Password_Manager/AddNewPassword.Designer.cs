namespace Password_Manager
{
    partial class AddNewPassword
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
            this.pnlDragbar = new System.Windows.Forms.Panel();
            this.lblWindowTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpboxPasswordParameters = new System.Windows.Forms.GroupBox();
            this.pnlUnderPassword = new System.Windows.Forms.Panel();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.pnlUnderServiceName = new System.Windows.Forms.Panel();
            this.txtboxServiceName = new System.Windows.Forms.TextBox();
            this.lblServiceName = new System.Windows.Forms.Label();
            this.pnlUnderEmail = new System.Windows.Forms.Panel();
            this.txtboxEmail = new System.Windows.Forms.TextBox();
            this.pnlUnderUsername = new System.Windows.Forms.Panel();
            this.txtboxUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.grpboxOptional = new System.Windows.Forms.GroupBox();
            this.btnCreateEntry = new System.Windows.Forms.Button();
            this.pnlDragbar.SuspendLayout();
            this.grpboxPasswordParameters.SuspendLayout();
            this.grpboxOptional.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDragbar
            // 
            this.pnlDragbar.Controls.Add(this.lblWindowTitle);
            this.pnlDragbar.Controls.Add(this.btnExit);
            this.pnlDragbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDragbar.Location = new System.Drawing.Point(0, 0);
            this.pnlDragbar.Name = "pnlDragbar";
            this.pnlDragbar.Size = new System.Drawing.Size(574, 66);
            this.pnlDragbar.TabIndex = 0;
            // 
            // lblWindowTitle
            // 
            this.lblWindowTitle.AutoSize = true;
            this.lblWindowTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindowTitle.Location = new System.Drawing.Point(12, 15);
            this.lblWindowTitle.Name = "lblWindowTitle";
            this.lblWindowTitle.Size = new System.Drawing.Size(295, 19);
            this.lblWindowTitle.TabIndex = 3;
            this.lblWindowTitle.Text = "YourPass - Add a New Password to Your Vault";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(538, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(24, 24);
            this.btnExit.TabIndex = 6;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // grpboxPasswordParameters
            // 
            this.grpboxPasswordParameters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpboxPasswordParameters.Controls.Add(this.pnlUnderPassword);
            this.grpboxPasswordParameters.Controls.Add(this.txtboxPassword);
            this.grpboxPasswordParameters.Controls.Add(this.lblPassword);
            this.grpboxPasswordParameters.Controls.Add(this.pnlUnderServiceName);
            this.grpboxPasswordParameters.Controls.Add(this.txtboxServiceName);
            this.grpboxPasswordParameters.Controls.Add(this.lblServiceName);
            this.grpboxPasswordParameters.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxPasswordParameters.Location = new System.Drawing.Point(12, 55);
            this.grpboxPasswordParameters.Name = "grpboxPasswordParameters";
            this.grpboxPasswordParameters.Size = new System.Drawing.Size(550, 183);
            this.grpboxPasswordParameters.TabIndex = 1;
            this.grpboxPasswordParameters.TabStop = false;
            this.grpboxPasswordParameters.Text = "Required Entry Parameters:";
            // 
            // pnlUnderPassword
            // 
            this.pnlUnderPassword.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlUnderPassword.Location = new System.Drawing.Point(20, 162);
            this.pnlUnderPassword.Name = "pnlUnderPassword";
            this.pnlUnderPassword.Size = new System.Drawing.Size(510, 1);
            this.pnlUnderPassword.TabIndex = 11;
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.BackColor = System.Drawing.SystemColors.Control;
            this.txtboxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxPassword.Location = new System.Drawing.Point(21, 137);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.Size = new System.Drawing.Size(509, 22);
            this.txtboxPassword.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(17, 109);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(82, 20);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Password:";
            // 
            // pnlUnderServiceName
            // 
            this.pnlUnderServiceName.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlUnderServiceName.Location = new System.Drawing.Point(20, 82);
            this.pnlUnderServiceName.Name = "pnlUnderServiceName";
            this.pnlUnderServiceName.Size = new System.Drawing.Size(510, 1);
            this.pnlUnderServiceName.TabIndex = 2;
            // 
            // txtboxServiceName
            // 
            this.txtboxServiceName.BackColor = System.Drawing.SystemColors.Control;
            this.txtboxServiceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxServiceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxServiceName.Location = new System.Drawing.Point(21, 57);
            this.txtboxServiceName.Name = "txtboxServiceName";
            this.txtboxServiceName.Size = new System.Drawing.Size(509, 22);
            this.txtboxServiceName.TabIndex = 0;
            // 
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceName.Location = new System.Drawing.Point(17, 29);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(111, 20);
            this.lblServiceName.TabIndex = 0;
            this.lblServiceName.Text = "Service Name:";
            // 
            // pnlUnderEmail
            // 
            this.pnlUnderEmail.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlUnderEmail.Location = new System.Drawing.Point(20, 84);
            this.pnlUnderEmail.Name = "pnlUnderEmail";
            this.pnlUnderEmail.Size = new System.Drawing.Size(510, 1);
            this.pnlUnderEmail.TabIndex = 5;
            // 
            // txtboxEmail
            // 
            this.txtboxEmail.BackColor = System.Drawing.SystemColors.Control;
            this.txtboxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxEmail.Location = new System.Drawing.Point(21, 59);
            this.txtboxEmail.Name = "txtboxEmail";
            this.txtboxEmail.Size = new System.Drawing.Size(509, 22);
            this.txtboxEmail.TabIndex = 2;
            // 
            // pnlUnderUsername
            // 
            this.pnlUnderUsername.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlUnderUsername.Location = new System.Drawing.Point(20, 167);
            this.pnlUnderUsername.Name = "pnlUnderUsername";
            this.pnlUnderUsername.Size = new System.Drawing.Size(510, 1);
            this.pnlUnderUsername.TabIndex = 8;
            // 
            // txtboxUsername
            // 
            this.txtboxUsername.BackColor = System.Drawing.SystemColors.Control;
            this.txtboxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxUsername.Location = new System.Drawing.Point(21, 142);
            this.txtboxUsername.Name = "txtboxUsername";
            this.txtboxUsername.Size = new System.Drawing.Size(509, 22);
            this.txtboxUsername.TabIndex = 3;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(17, 114);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(87, 20);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "Username:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(17, 31);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(115, 20);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email Address:";
            // 
            // grpboxOptional
            // 
            this.grpboxOptional.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpboxOptional.Controls.Add(this.lblEmail);
            this.grpboxOptional.Controls.Add(this.pnlUnderUsername);
            this.grpboxOptional.Controls.Add(this.txtboxEmail);
            this.grpboxOptional.Controls.Add(this.lblUsername);
            this.grpboxOptional.Controls.Add(this.pnlUnderEmail);
            this.grpboxOptional.Controls.Add(this.txtboxUsername);
            this.grpboxOptional.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxOptional.Location = new System.Drawing.Point(12, 244);
            this.grpboxOptional.Name = "grpboxOptional";
            this.grpboxOptional.Size = new System.Drawing.Size(550, 198);
            this.grpboxOptional.TabIndex = 2;
            this.grpboxOptional.TabStop = false;
            this.grpboxOptional.Text = "Optional Entry Parameters:";
            // 
            // btnCreateEntry
            // 
            this.btnCreateEntry.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateEntry.Location = new System.Drawing.Point(12, 453);
            this.btnCreateEntry.Name = "btnCreateEntry";
            this.btnCreateEntry.Size = new System.Drawing.Size(550, 40);
            this.btnCreateEntry.TabIndex = 4;
            this.btnCreateEntry.Text = "Create New Password Entry";
            this.btnCreateEntry.UseVisualStyleBackColor = true;
            this.btnCreateEntry.Click += new System.EventHandler(this.BtnCreateEntry_Click);
            // 
            // AddNewPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 508);
            this.ControlBox = false;
            this.Controls.Add(this.btnCreateEntry);
            this.Controls.Add(this.grpboxOptional);
            this.Controls.Add(this.grpboxPasswordParameters);
            this.Controls.Add(this.pnlDragbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNewPassword";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add a New Password";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddNewPassword_Load);
            this.pnlDragbar.ResumeLayout(false);
            this.pnlDragbar.PerformLayout();
            this.grpboxPasswordParameters.ResumeLayout(false);
            this.grpboxPasswordParameters.PerformLayout();
            this.grpboxOptional.ResumeLayout(false);
            this.grpboxOptional.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDragbar;
        private System.Windows.Forms.Label lblWindowTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpboxPasswordParameters;
        private System.Windows.Forms.Panel pnlUnderPassword;
        private System.Windows.Forms.TextBox txtboxPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Panel pnlUnderServiceName;
        private System.Windows.Forms.TextBox txtboxServiceName;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.Panel pnlUnderEmail;
        private System.Windows.Forms.TextBox txtboxEmail;
        private System.Windows.Forms.Panel pnlUnderUsername;
        private System.Windows.Forms.TextBox txtboxUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.GroupBox grpboxOptional;
        private System.Windows.Forms.Button btnCreateEntry;
    }
}