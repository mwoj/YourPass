﻿using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Dapper;

namespace Password_Manager
{
    public partial class CreateNewPasswordList : Form, IMessageFilter
    {
        private readonly Login loginForm;
        public CreateNewPasswordList()
        {
            InitializeComponent();
            Application.AddMessageFilter(this);
        }

        public CreateNewPasswordList(Login loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            Application.AddMessageFilter(this);

            Bitmap mainIcon = new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream("Password_Manager.key-icon.png"));

            picboxIcon.Image = mainIcon;
            picboxIcon.Update();
        }

        private void ChkboxReveal_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxReveal.Checked)
            {
                chkboxReveal.Checked = false;
                txtboxMasterPassword.UseSystemPasswordChar = false;
                tmrReveal.Start();
            }
        }

        private void TmrReveal_Tick(object sender, EventArgs e)
        {
            txtboxMasterPassword.UseSystemPasswordChar = true;
            tmrReveal.Stop();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
            loginForm.ShowFormHook();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            if (txtListName.Text.Length < 3 || StringContains(txtListName.Text, new []{ '\\', '/', '|', ':', '?', '*', '\"', '<', '>'}))
            {
                MessageBox.Show("Error: The name of your password list must be at least 3 characters, and it can not contain the following characters:\n\\ / | : ? * \" < >", "YourPass - Password List Name Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }

            if (txtboxMasterPassword.Text.Length < 12)
            {
                MessageBox.Show("Error: Your Master Password must be at least 12 characters long.", "YourPass - Master Password Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
                return;
            }

            string vaultName = txtListName.Text + ".db";

            // Create any directories we need to create and check whether a database with the provided name already exists.
            Directory.CreateDirectory(Path.GetDirectoryName(Application.ExecutablePath) + "\\Vault\\");
            if (File.Exists(Path.GetDirectoryName(Application.ExecutablePath) + $"\\Vault\\{vaultName}"))
            {
                MessageBox.Show($"Error: Unable to create a password vault with name: \"{txtListName.Text}\"\n\n\"Password Vault \"{vaultName}\" already exists.", "YourPass - Password List Creation Failure", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }

            // Create Password Database
            SQLiteConnection.CreateFile(Path.GetDirectoryName(Application.ExecutablePath) + $"\\Vault\\{vaultName}");

            // Set Initial Connection String
            Program.CurrentConnectionString = $"DataSource=.\\Vault\\{vaultName};Version=3;";

            // Generate the cipher text that we will use to check and see if the master password provided is correct.
            string ciphertext = Crypto.SimpleEncryptWithPassword("correct_password", txtboxMasterPassword.Text);

            // Insert the entry that will be used to check if the master password provided is correct.
            using (IDbConnection connection = new SQLiteConnection(Program.CurrentConnectionString))
            {
                string tableSQL = "CREATE TABLE \"PasswordVault\" (\"id\" INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, \"service_name\" TEXT NOT NULL, \"email\" TEXT, \"username\" TEXT, \"encrypted_password\" TEXT NOT NULL);";
                string checksumSQL =
                    $"INSERT INTO PasswordVault (service_name, email, username, encrypted_password) VALUES ('checksum', null, null, '{ciphertext}');";
                
                connection.Execute(tableSQL);
                connection.Execute(checksumSQL);
            }

            MessageBox.Show($"Success! The password vault \"{vaultName}\" has been created in:\n\n{Path.GetDirectoryName(Application.ExecutablePath) + $"\\Vault\\{vaultName}"}", "YourPass - Success", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            Close();
            loginForm.ShowFormHook();
        }

        private bool StringContains(string stringToCheck, char[] listOfChars)
        {
            for (int i = 0; i < listOfChars.Length; i++)
                if (stringToCheck.Contains(listOfChars[i]))
                    return true;
            return false;
        }

        private void TxtboxMasterPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            CalculatePasswordStrength();
        }

        private void TxtboxMasterPassword_TextChanged(object sender, EventArgs e)
        {
            CalculatePasswordStrength();
        }

        private void CalculatePasswordStrength()
        {
            int passwordStrength = 0;
            string pass = txtboxMasterPassword.Text;
            if (pass.Length >= 0 && pass.Length < 12)
            {
                lblPassStrength.ForeColor = Color.DimGray;
                lblPassStrength.Text = "Password must be at least 12 characters long.";
                return;
            }

            if (pass.Length >= 12 && pass.Length < 15)
                passwordStrength += 1;
            else if (pass.Length >= 15 && pass.Length < 32)
                passwordStrength += 2;
            else if (pass.Length >= 32)
                passwordStrength += 3;

            var lowercaseMatches = Regex.Matches(pass, "[a-z]+");
            if (lowercaseMatches.Count > 0)
                passwordStrength += 1;

            if (Regex.Matches(pass, "[A-Z]+").Count > 0)
                passwordStrength += 1;

            if (Regex.Matches(pass, "[0-9]+").Count > 0)
                passwordStrength += 1;

            if (Regex.Matches(pass, "[$-/:-?{-~!\"^_`\\[\\]]+").Count > 0)
                passwordStrength += 1;

            if (passwordStrength > 0 && passwordStrength < 5)
            {
                lblPassStrength.ForeColor = Color.Red;
                lblPassStrength.Text = "Password Strength: Weak";
            }
            else if (passwordStrength >= 5 && passwordStrength < 7)
            {
                lblPassStrength.ForeColor = Color.YellowGreen;
                lblPassStrength.Text = "Password Strength: Medium";
            }
            else if (passwordStrength >= 7)
            {
                lblPassStrength.ForeColor = Color.Green;
                lblPassStrength.Text = "Password Strength: Strong";
            }
        }

        public bool PreFilterMessage(ref Message m)
        {
            return Program.PreFilterMessage(ref m, this, pnlDragbar, lblTitle);
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= Program.CS_DROPSHADOW;
                return cp;
            }
        }
    }
}
