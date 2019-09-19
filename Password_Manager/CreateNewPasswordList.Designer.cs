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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkboxReveal = new System.Windows.Forms.CheckBox();
            this.txtboxMasterPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtListName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.tmrReveal = new System.Windows.Forms.Timer(this.components);
            this.lblPassStrength = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 47);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create a New Password List";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(451, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(24, 24);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblPassStrength);
            this.groupBox1.Controls.Add(this.chkboxReveal);
            this.groupBox1.Controls.Add(this.txtboxMasterPassword);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtListName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 188);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Password List Parameters";
            // 
            // chkboxReveal
            // 
            this.chkboxReveal.AutoSize = true;
            this.chkboxReveal.Location = new System.Drawing.Point(9, 158);
            this.chkboxReveal.Name = "chkboxReveal";
            this.chkboxReveal.Size = new System.Drawing.Size(144, 17);
            this.chkboxReveal.TabIndex = 4;
            this.chkboxReveal.Text = "Reveal Master Password";
            this.chkboxReveal.UseVisualStyleBackColor = true;
            this.chkboxReveal.CheckedChanged += new System.EventHandler(this.ChkboxReveal_CheckedChanged);
            // 
            // txtboxMasterPassword
            // 
            this.txtboxMasterPassword.Location = new System.Drawing.Point(9, 132);
            this.txtboxMasterPassword.Name = "txtboxMasterPassword";
            this.txtboxMasterPassword.Size = new System.Drawing.Size(448, 20);
            this.txtboxMasterPassword.TabIndex = 3;
            this.txtboxMasterPassword.UseSystemPasswordChar = true;
            this.txtboxMasterPassword.TextChanged += new System.EventHandler(this.TxtboxMasterPassword_TextChanged);
            this.txtboxMasterPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtboxMasterPassword_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(391, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Master Password (MAKE SURE YOU WRITE THIS DOWN OR REMEMBER IT):";
            // 
            // txtListName
            // 
            this.txtListName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtListName.Location = new System.Drawing.Point(9, 47);
            this.txtListName.Name = "txtListName";
            this.txtListName.Size = new System.Drawing.Size(448, 20);
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
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.Location = new System.Drawing.Point(13, 252);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(462, 32);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create New Password List";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // tmrReveal
            // 
            this.tmrReveal.Interval = 1000;
            this.tmrReveal.Tick += new System.EventHandler(this.TmrReveal_Tick);
            // 
            // lblPassStrength
            // 
            this.lblPassStrength.AutoSize = true;
            this.lblPassStrength.ForeColor = System.Drawing.Color.DimGray;
            this.lblPassStrength.Location = new System.Drawing.Point(6, 116);
            this.lblPassStrength.Name = "lblPassStrength";
            this.lblPassStrength.Size = new System.Drawing.Size(111, 13);
            this.lblPassStrength.TabIndex = 5;
            this.lblPassStrength.Text = "Password Strength: ---";
            // 
            // CreateNewPasswordList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 300);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateNewPasswordList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YourPass - Create a New Password List";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.CheckBox chkboxReveal;
        private System.Windows.Forms.TextBox txtboxMasterPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtListName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer tmrReveal;
        private System.Windows.Forms.Label lblPassStrength;
    }
}