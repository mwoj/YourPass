using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public const int WM_LBUTTONDOWN = 0x0201;

        public const float VERSION_NUM = 1.0f;
        public readonly string PASSWORD_VAULT_DIRECTORY;

        private List<string> passwordVaults;

        public Login()
        {
            InitializeComponent();

            PASSWORD_VAULT_DIRECTORY = Path.GetDirectoryName(Application.ExecutablePath) + @"\Vault\";

            passwordVaults = new List<string>();
            passwordVaults.Add("<New Password List>");

            lblWelcome.Text += $"{VERSION_NUM:0.0}";

            Application.AddMessageFilter(this);

            passwordVaultWatcher.Path = PASSWORD_VAULT_DIRECTORY;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Check for all databases found
            foreach (string fileName in Directory.EnumerateFiles(PASSWORD_VAULT_DIRECTORY))
            {
                if (fileName.EndsWith(".db"))
                {
                    passwordVaults.Add(Path.GetFileName(fileName));
                }
            }

            passwordVaults.Sort();
            menuPasswordDB.Items.Clear();
            menuPasswordDB.Items.AddRange(passwordVaults.ToArray());

            // If there is a database found, change control focus to txtboxMasterPass
            if (passwordVaults.Count > 1)
            {
                menuPasswordDB.SelectedIndex = 1;
                txtboxMasterPass.Select();
            }
            // If there is no database found, change control focus to menuPasswordDB
            else menuPasswordDB.Select();
        }

        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == WM_LBUTTONDOWN && (FromHandle(m.HWnd) == pnlDragbar || FromHandle(m.HWnd) == lblWelcome))
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                return true;
            }
            return false;
        }

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

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
            {
                ciphertext = conn.ExecuteScalar("SELECT encrypted_password FROM PasswordVault WHERE id = 1 AND service_name = 'checksum';") as string;
            }

            string plaintext = Crypto.SimpleDecryptWithPassword(ciphertext, txtboxMasterPass.Text);

            if (plaintext == "correct_password")
            {
                MessageBox.Show("Password was accepted... Logging you in.", "YourPass - Success!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            else
            {
                MessageBox.Show("Password was denied... Try again.", "YourPass - Failure.", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
