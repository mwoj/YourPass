using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Dapper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace Password_Manager
{
    public partial class Login : Form, IMessageFilter
    {
        public readonly string PASSWORD_VAULT_DIRECTORY;
        private readonly List<string> passwordVaults;

        public Login()
        {
            InitializeComponent();

            passwordVaults = new List<string> { "<New Password List>" };
            
            PASSWORD_VAULT_DIRECTORY = $@"{Path.GetDirectoryName(Application.ExecutablePath)}\Vault\";
            lblWelcome.Text += $"{Program.VERSION_NUM:0.0}";

            Application.AddMessageFilter(this);


            if (!Directory.Exists(PASSWORD_VAULT_DIRECTORY))
                Directory.CreateDirectory(PASSWORD_VAULT_DIRECTORY);
            passwordVaultWatcher.Path = PASSWORD_VAULT_DIRECTORY;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Check for all databases found
            foreach (string fileName in Directory.EnumerateFiles(PASSWORD_VAULT_DIRECTORY))
                if (fileName.EndsWith(".db"))
                    passwordVaults.Add(Path.GetFileName(fileName));

            passwordVaults.Sort();
            menuPasswordDB.Items.Clear();
            menuPasswordDB.Items.AddRange(passwordVaults.ToArray());

            ShowFormHook();
        }

        public bool PreFilterMessage(ref Message m)
        {
            return Program.PreFilterMessage(ref m, this, pnlDragbar, lblWelcome);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.Sizable;
            WindowState = FormWindowState.Minimized;
            FormBorderStyle = FormBorderStyle.None;
        }

        private void MenuPasswordDB_SelectedValueChanged(object sender, EventArgs e)
        {
            string selectedItem = menuPasswordDB.SelectedItem as string;
            if (selectedItem == "<New Password List>")
            {
                menuPasswordDB.SelectedIndex = -1;
                Hide();
                new CreateNewPasswordList(this).Show();
            }
            else
            {
                Program.CurrentConnectionString = $"DataSource=.\\Vault\\{selectedItem};Version=3;";
            }
        }

        private void PasswordVaultWatcher_Created(object sender, FileSystemEventArgs e)
        {
            if (e.Name.EndsWith(".db"))
            {
                passwordVaults.Add(e.Name);
                passwordVaults.Sort();
                menuPasswordDB.Items.Clear();
                menuPasswordDB.Items.AddRange(passwordVaults.ToArray());
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string ciphertext;
            using (IDbConnection conn = new SQLiteConnection(Program.CurrentConnectionString))
                ciphertext = conn.ExecuteScalar("SELECT encrypted_password FROM PasswordVault WHERE id = 1 AND service_name = 'checksum';") as string;

            string plaintext = Crypto.SimpleDecryptWithPassword(ciphertext, txtboxMasterPass.Text);

            if (plaintext == "correct_password")
            {
                //MessageBox.Show("Password was accepted... Logging you in.", "YourPass - Success!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                
                // Hide the login form
                Hide();

                // Store the encrypted master password in memory
                SecureString ssmp = new SecureString();
                for (ushort i = 0; i < txtboxMasterPass.Text.Length; i++)
                    ssmp.AppendChar(txtboxMasterPass.Text[i]);

                // Remove master password from being plaintext in memory
                txtboxMasterPass.Text = string.Empty;
                GC.Collect();
                GC.WaitForPendingFinalizers();

                // Show the new password vault form
                new Form1(ssmp).Show();
            }
            else
            {
                MessageBox.Show("Password was denied... Try again.", "YourPass - Failure.", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void TxtboxMasterPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnLogin.PerformClick();
        }

        private void Login_Shown(object sender, EventArgs e)
        {
            ShowFormHook();
        }

        private void ShowFormHook()
        {
            // If there is a database found, change control focus to txtboxMasterPass
            if (passwordVaults.Count > 1)
            {
                menuPasswordDB.SelectedIndex = 1;
                txtboxMasterPass.Select();
            }
            // If there is no database found, change control focus to menuPasswordDB
            else menuPasswordDB.Select();
        }
    }
}
