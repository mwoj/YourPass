namespace Password_Manager
{
    partial class EditEntry
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
            this.picboxIcon = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpboxInformation = new System.Windows.Forms.GroupBox();
            this.lblInformation = new System.Windows.Forms.Label();
            this.pnlUnderPassword = new System.Windows.Forms.Panel();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.pnlUnderUsername = new System.Windows.Forms.Panel();
            this.txtboxUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pnlUnderEmail = new System.Windows.Forms.Panel();
            this.pnlUnderServiceName = new System.Windows.Forms.Panel();
            this.txtboxEmail = new System.Windows.Forms.TextBox();
            this.txtboxServiceName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblServiceName = new System.Windows.Forms.Label();
            this.btnEditEntry = new System.Windows.Forms.Button();
            this.pnlDragbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxIcon)).BeginInit();
            this.grpboxInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDragbar
            // 
            this.pnlDragbar.BackColor = System.Drawing.SystemColors.Control;
            this.pnlDragbar.Controls.Add(this.picboxIcon);
            this.pnlDragbar.Controls.Add(this.btnExit);
            this.pnlDragbar.Controls.Add(this.lblTitle);
            this.pnlDragbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDragbar.Location = new System.Drawing.Point(0, 0);
            this.pnlDragbar.Name = "pnlDragbar";
            this.pnlDragbar.Size = new System.Drawing.Size(541, 66);
            this.pnlDragbar.TabIndex = 0;
            // 
            // picboxIcon
            // 
            this.picboxIcon.Location = new System.Drawing.Point(12, 12);
            this.picboxIcon.Name = "picboxIcon";
            this.picboxIcon.Size = new System.Drawing.Size(45, 45);
            this.picboxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxIcon.TabIndex = 2;
            this.picboxIcon.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(497, 17);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 32);
            this.btnExit.TabIndex = 1;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(63, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(84, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "YourPass";
            // 
            // grpboxInformation
            // 
            this.grpboxInformation.BackColor = System.Drawing.SystemColors.Control;
            this.grpboxInformation.Controls.Add(this.lblInformation);
            this.grpboxInformation.Controls.Add(this.pnlUnderPassword);
            this.grpboxInformation.Controls.Add(this.txtboxPassword);
            this.grpboxInformation.Controls.Add(this.lblPassword);
            this.grpboxInformation.Controls.Add(this.pnlUnderUsername);
            this.grpboxInformation.Controls.Add(this.txtboxUsername);
            this.grpboxInformation.Controls.Add(this.lblUsername);
            this.grpboxInformation.Controls.Add(this.pnlUnderEmail);
            this.grpboxInformation.Controls.Add(this.pnlUnderServiceName);
            this.grpboxInformation.Controls.Add(this.txtboxEmail);
            this.grpboxInformation.Controls.Add(this.txtboxServiceName);
            this.grpboxInformation.Controls.Add(this.lblEmail);
            this.grpboxInformation.Controls.Add(this.lblServiceName);
            this.grpboxInformation.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxInformation.Location = new System.Drawing.Point(12, 83);
            this.grpboxInformation.Name = "grpboxInformation";
            this.grpboxInformation.Size = new System.Drawing.Size(516, 374);
            this.grpboxInformation.TabIndex = 1;
            this.grpboxInformation.TabStop = false;
            this.grpboxInformation.Text = "Information";
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformation.ForeColor = System.Drawing.Color.DimGray;
            this.lblInformation.Location = new System.Drawing.Point(26, 334);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(377, 16);
            this.lblInformation.TabIndex = 12;
            this.lblInformation.Text = "Note: Any information left blank on this form will not be updated.";
            // 
            // pnlUnderPassword
            // 
            this.pnlUnderPassword.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlUnderPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlUnderPassword.Location = new System.Drawing.Point(27, 303);
            this.pnlUnderPassword.Name = "pnlUnderPassword";
            this.pnlUnderPassword.Size = new System.Drawing.Size(461, 1);
            this.pnlUnderPassword.TabIndex = 11;
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.BackColor = System.Drawing.SystemColors.Control;
            this.txtboxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxPassword.Location = new System.Drawing.Point(28, 282);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.Size = new System.Drawing.Size(460, 19);
            this.txtboxPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(23, 256);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(117, 20);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "New Password:";
            // 
            // pnlUnderUsername
            // 
            this.pnlUnderUsername.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlUnderUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlUnderUsername.Location = new System.Drawing.Point(29, 227);
            this.pnlUnderUsername.Name = "pnlUnderUsername";
            this.pnlUnderUsername.Size = new System.Drawing.Size(461, 1);
            this.pnlUnderUsername.TabIndex = 8;
            // 
            // txtboxUsername
            // 
            this.txtboxUsername.BackColor = System.Drawing.SystemColors.Control;
            this.txtboxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxUsername.Location = new System.Drawing.Point(30, 206);
            this.txtboxUsername.Name = "txtboxUsername";
            this.txtboxUsername.Size = new System.Drawing.Size(460, 19);
            this.txtboxUsername.TabIndex = 2;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(23, 180);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(122, 20);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "New Username:";
            // 
            // pnlUnderEmail
            // 
            this.pnlUnderEmail.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlUnderEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlUnderEmail.Location = new System.Drawing.Point(28, 155);
            this.pnlUnderEmail.Name = "pnlUnderEmail";
            this.pnlUnderEmail.Size = new System.Drawing.Size(461, 1);
            this.pnlUnderEmail.TabIndex = 5;
            // 
            // pnlUnderServiceName
            // 
            this.pnlUnderServiceName.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlUnderServiceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlUnderServiceName.Location = new System.Drawing.Point(27, 83);
            this.pnlUnderServiceName.Name = "pnlUnderServiceName";
            this.pnlUnderServiceName.Size = new System.Drawing.Size(461, 1);
            this.pnlUnderServiceName.TabIndex = 2;
            // 
            // txtboxEmail
            // 
            this.txtboxEmail.BackColor = System.Drawing.SystemColors.Control;
            this.txtboxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxEmail.Location = new System.Drawing.Point(29, 134);
            this.txtboxEmail.Name = "txtboxEmail";
            this.txtboxEmail.Size = new System.Drawing.Size(460, 19);
            this.txtboxEmail.TabIndex = 1;
            // 
            // txtboxServiceName
            // 
            this.txtboxServiceName.BackColor = System.Drawing.SystemColors.Control;
            this.txtboxServiceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxServiceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxServiceName.Location = new System.Drawing.Point(28, 62);
            this.txtboxServiceName.Name = "txtboxServiceName";
            this.txtboxServiceName.Size = new System.Drawing.Size(460, 19);
            this.txtboxServiceName.TabIndex = 0;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(23, 108);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(150, 20);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "New Email Address:";
            // 
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceName.Location = new System.Drawing.Point(23, 36);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(146, 20);
            this.lblServiceName.TabIndex = 0;
            this.lblServiceName.Text = "New Service Name:";
            // 
            // btnEditEntry
            // 
            this.btnEditEntry.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditEntry.Location = new System.Drawing.Point(11, 473);
            this.btnEditEntry.Name = "btnEditEntry";
            this.btnEditEntry.Size = new System.Drawing.Size(517, 40);
            this.btnEditEntry.TabIndex = 4;
            this.btnEditEntry.Text = "Edit Entry";
            this.btnEditEntry.UseVisualStyleBackColor = true;
            this.btnEditEntry.Click += new System.EventHandler(this.BtnEditEntry_Click);
            // 
            // EditEntry
            // 
            this.AcceptButton = this.btnEditEntry;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(541, 531);
            this.ControlBox = false;
            this.Controls.Add(this.btnEditEntry);
            this.Controls.Add(this.grpboxInformation);
            this.Controls.Add(this.pnlDragbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditEntry";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditEntry";
            this.Load += new System.EventHandler(this.EditEntry_Load);
            this.pnlDragbar.ResumeLayout(false);
            this.pnlDragbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxIcon)).EndInit();
            this.grpboxInformation.ResumeLayout(false);
            this.grpboxInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDragbar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpboxInformation;
        private System.Windows.Forms.Button btnEditEntry;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.TextBox txtboxServiceName;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Panel pnlUnderPassword;
        private System.Windows.Forms.TextBox txtboxPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Panel pnlUnderUsername;
        private System.Windows.Forms.TextBox txtboxUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel pnlUnderEmail;
        private System.Windows.Forms.Panel pnlUnderServiceName;
        private System.Windows.Forms.TextBox txtboxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.PictureBox picboxIcon;
    }
}