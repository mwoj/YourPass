namespace Password_Manager
{
    partial class CreateNewPasswordList
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
            this.pnlDragbar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlUnderPasswordName = new System.Windows.Forms.Panel();
            this.txtListName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPassStrength = new System.Windows.Forms.Label();
            this.chkboxReveal = new System.Windows.Forms.CheckBox();
            this.txtboxMasterPassword = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.tmrReveal = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlDragbar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDragbar
            // 
            this.pnlDragbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDragbar.BackColor = System.Drawing.SystemColors.Control;
            this.pnlDragbar.Controls.Add(this.lblTitle);
            this.pnlDragbar.Controls.Add(this.btnExit);
            this.pnlDragbar.Location = new System.Drawing.Point(0, 0);
            this.pnlDragbar.Name = "pnlDragbar";
            this.pnlDragbar.Size = new System.Drawing.Size(488, 48);
            this.pnlDragbar.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(8, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(402, 34);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "YourPass V1.0 - Create a New Password List";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(451, 14);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(24, 24);
            this.btnExit.TabIndex = 0;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.pnlUnderPasswordName);
            this.groupBox1.Controls.Add(this.txtListName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 84);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Password List Parameters";
            // 
            // pnlUnderPasswordName
            // 
            this.pnlUnderPasswordName.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlUnderPasswordName.Location = new System.Drawing.Point(9, 70);
            this.pnlUnderPasswordName.Name = "pnlUnderPasswordName";
            this.pnlUnderPasswordName.Size = new System.Drawing.Size(448, 1);
            this.pnlUnderPasswordName.TabIndex = 2;
            // 
            // txtListName
            // 
            this.txtListName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtListName.BackColor = System.Drawing.SystemColors.Control;
            this.txtListName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtListName.Location = new System.Drawing.Point(9, 53);
            this.txtListName.Name = "txtListName";
            this.txtListName.Size = new System.Drawing.Size(448, 13);
            this.txtListName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password List Name:";
            // 
            // lblPassStrength
            // 
            this.lblPassStrength.AutoSize = true;
            this.lblPassStrength.ForeColor = System.Drawing.Color.DimGray;
            this.lblPassStrength.Location = new System.Drawing.Point(6, 48);
            this.lblPassStrength.Name = "lblPassStrength";
            this.lblPassStrength.Size = new System.Drawing.Size(224, 13);
            this.lblPassStrength.TabIndex = 5;
            this.lblPassStrength.Text = "Password must be at least 12 characters long.";
            // 
            // chkboxReveal
            // 
            this.chkboxReveal.AutoSize = true;
            this.chkboxReveal.Location = new System.Drawing.Point(313, 48);
            this.chkboxReveal.Name = "chkboxReveal";
            this.chkboxReveal.Size = new System.Drawing.Size(144, 17);
            this.chkboxReveal.TabIndex = 6;
            this.chkboxReveal.TabStop = false;
            this.chkboxReveal.Text = "Reveal Master Password";
            this.chkboxReveal.UseVisualStyleBackColor = true;
            this.chkboxReveal.CheckedChanged += new System.EventHandler(this.ChkboxReveal_CheckedChanged);
            // 
            // txtboxMasterPassword
            // 
            this.txtboxMasterPassword.BackColor = System.Drawing.SystemColors.Control;
            this.txtboxMasterPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxMasterPassword.Location = new System.Drawing.Point(9, 24);
            this.txtboxMasterPassword.Name = "txtboxMasterPassword";
            this.txtboxMasterPassword.Size = new System.Drawing.Size(448, 13);
            this.txtboxMasterPassword.TabIndex = 2;
            this.txtboxMasterPassword.UseSystemPasswordChar = true;
            this.txtboxMasterPassword.TextChanged += new System.EventHandler(this.TxtboxMasterPassword_TextChanged);
            this.txtboxMasterPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtboxMasterPassword_KeyPress);
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.Location = new System.Drawing.Point(13, 245);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(462, 32);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Create New Password List";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // tmrReveal
            // 
            this.tmrReveal.Interval = 1000;
            this.tmrReveal.Tick += new System.EventHandler(this.TmrReveal_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.lblPassStrength);
            this.groupBox2.Controls.Add(this.chkboxReveal);
            this.groupBox2.Controls.Add(this.txtboxMasterPassword);
            this.groupBox2.Location = new System.Drawing.Point(12, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 77);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Master Password (MAKE SURE YOU WRITE THIS DOWN OR REMEMBER IT):";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(9, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(448, 1);
            this.panel2.TabIndex = 6;
            // 
            // CreateNewPasswordList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 293);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlDragbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateNewPasswordList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YourPass - Create a New Password List";
            this.pnlDragbar.ResumeLayout(false);
            this.pnlDragbar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDragbar;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.CheckBox chkboxReveal;
        private System.Windows.Forms.TextBox txtboxMasterPassword;
        private System.Windows.Forms.TextBox txtListName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer tmrReveal;
        private System.Windows.Forms.Label lblPassStrength;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel pnlUnderPasswordName;
        private System.Windows.Forms.Panel panel2;
    }
}