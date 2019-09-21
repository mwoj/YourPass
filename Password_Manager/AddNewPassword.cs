using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Util;
using System.Windows.Forms;
using Dapper;

namespace Password_Manager
{
    public partial class AddNewPassword : Form, IMessageFilter
    {
        private readonly Form1 mainWindow;
        public AddNewPassword()
        {
            InitializeComponent();
            Application.AddMessageFilter(this);
        }

        public AddNewPassword(Form1 mainWindow)
        {
            InitializeComponent();
            Application.AddMessageFilter(this);
            this.mainWindow = mainWindow;
        }

        private void AddNewPassword_Load(object sender, EventArgs e)
        {
            lblWindowTitle.Text = Program.GetCaptionTitle("Add a New Password to Your Vault");
        }

        private void BtnCreateEntry_Click(object sender, EventArgs e)
        {
            if (txtboxServiceName.Text.Length < 2)
            {
                MessageBox.Show("Error: You must provide a service name that has at least 2 character.", Program.GetCaptionTitle("Service Name Required"), MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }

            if (txtboxPassword.Text.Length == 0)
            {
                MessageBox.Show("Error: You must provided a password for the service.", Program.GetCaptionTitle("Password Required"), MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }

            if (!AddEntryToDatabase())
            {
                MessageBox.Show("An error occurred while trying to add your entry to the vault.", Program.GetCaptionTitle("Internal Error"), MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                MessageBox.Show($"Success!\n\nThe entry \"{txtboxServiceName.Text}\" has been added to the vault.", Program.GetCaptionTitle("Successfully Added Entry"), MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                mainWindow.Show();
                mainWindow.NewPasswordAdded();
                Close();
            }
        }

        private bool AddEntryToDatabase()
        {
            using (IDbConnection conn = new SQLiteConnection(Program.CurrentConnectionString))
            {
                // Declare Local Variables
                string sql =
                    "INSERT INTO PasswordVault (service_name, email, username, encrypted_password) VALUES (@service_name, @email, @username, @password);";
                DynamicParameters dp = new DynamicParameters();
                
                // Add Sanitized Password
                dp.Add("@password", Crypto.SimpleEncryptWithPassword(txtboxPassword.Text, mainWindow.GetMasterPassword()));
                txtboxPassword.Text = string.Empty;
                GC.Collect();
                GC.WaitForPendingFinalizers();

                // Add Remaining Information
                dp.Add("@service_name", txtboxServiceName.Text);
                dp.Add("@email", txtboxEmail.Text);
                dp.Add("@username", txtboxUsername.Text);
                
                // Open connection to database and complete transaction
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        conn.Execute(sql, dp);
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
                conn.Close();
                return true;
            }
        }
        public bool PreFilterMessage(ref Message m)
        {
            return Program.PreFilterMessage(ref m, this, pnlDragbar, lblWindowTitle);
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
            mainWindow.Show();
            mainWindow.PasswordVaultClicked();
        }
    }
}
