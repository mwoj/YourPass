using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Manager
{
    public partial class CreateNewPasswordList : Form
    {
        private readonly Form loginForm;
        public CreateNewPasswordList()
        {
            InitializeComponent();
        }

        public CreateNewPasswordList(Form loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
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
            loginForm.Show();
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

            // Create Password Database

            // Add Connection String to App.Config?
            //AddConnectionString(txtListName.Text + ".db");
        }

        private void AddConnectionString(string nameOfDBFile)
        {
            var settings = ConfigurationManager.ConnectionStrings[ 0 ];
            var fi = typeof( ConfigurationElement ).GetField( "_bReadOnly", BindingFlags.Instance | BindingFlags.NonPublic );
            fi.SetValue(settings, false);

            settings.ConnectionString = $@"Data Source=.\{nameOfDBFile};Version=3;";
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
                lblPassStrength.Text = "Password Strength: ---";
                return;
            }

            if (pass.Length >= 12 && pass.Length < 16)
                passwordStrength += 1;
            else if (pass.Length >= 16 && pass.Length < 32)
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
    }
}
