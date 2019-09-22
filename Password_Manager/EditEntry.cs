using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using Dapper;

namespace Password_Manager
{
    public partial class EditEntry : Form, IMessageFilter
    {
        private Form1 main_window;
        private string service_name;

        public EditEntry()
        {
            InitializeComponent();
            Application.AddMessageFilter(this);
        }

        public EditEntry(Form1 mainWindow, string service_name)
        {
            InitializeComponent();
            Application.AddMessageFilter(this);

            main_window = mainWindow;
            this.service_name = service_name;

            Bitmap mainIcon = new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream("Password_Manager.edit-icon.png"));

            picboxIcon.Image = mainIcon;
            picboxIcon.Update();
        }

        private void EditEntry_Load(object sender, EventArgs e)
        {
            lblTitle.Text = Program.GetCaptionTitle($"Editing Entry \"{service_name}\"");
            btnEditEntry.Text = $"Save Changes for Service Name: \"{service_name}\"";
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
            main_window.PasswordVaultClicked();
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

        private void BtnEditEntry_Click(object sender, EventArgs e)
        {
            string new_service_name = txtboxServiceName.Text;
            string new_email = txtboxEmail.Text;
            string new_username = txtboxUsername.Text;
            string encrypted_password = string.Empty;
            if (txtboxPassword.Text != string.Empty)
            {
                encrypted_password =
                    Crypto.SimpleEncryptWithPassword(txtboxPassword.Text, main_window.GetMasterPassword());
            }

            

            bool success = UpdateEntryInformation(service_name,
                        (new_service_name == string.Empty) ? null : new_service_name,
                        (new_email == string.Empty) ? null : new_email, 
                             (new_username == string.Empty) ? null : new_username,
                           (txtboxPassword.Text == string.Empty) ? null : encrypted_password);

            if (success)
            {
                MessageBox.Show($"Success!\nThe entry '{service_name}' has been updated.",
                    Program.GetCaptionTitle("Successfully Updated Entry"), MessageBoxButtons.OK,
                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                Close();
                main_window.Show();
                main_window.VaultInformationUpdated();
            }
            else
            {
                MessageBox.Show($"Error: The entry '{service_name}' could not be updated.",
                    Program.GetCaptionTitle("Internal Error"), MessageBoxButtons.OK, MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
            }
        }

        private bool UpdateEntryInformation(string old_service_name, string new_service_name, string new_email, string new_username, string new_password)
        {
            if (new_service_name == null && new_email == null && new_username == null && new_password == null)
                return true;

            using (IDbConnection conn = new SQLiteConnection(Program.CurrentConnectionString))
            {
                string sql = "UPDATE PasswordVault SET ";
                if (new_service_name != null)
                    sql += "service_name = @new_service_name";
                if (new_email != null)
                    sql += ", email = @email";
                if (new_username != null)
                    sql += ", username = @username";
                if (new_password != null)
                    sql += ", encrypted_password = @password";
                sql += " WHERE service_name = @old_service_name;";
                DynamicParameters dp = new DynamicParameters();
                dp.Add("@new_service_name", new_service_name);
                dp.Add("@old_service_name", old_service_name);
                dp.Add("@email", new_email);
                dp.Add("@username", new_username);
                dp.Add("@password", new_password);

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
                        conn.Close();
                        return false;
                    }
                }
                conn.Close();
                return true;
            }
        }
    }
}
