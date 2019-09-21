using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Web.Hosting;
using System.Windows.Forms;
using Dapper;

namespace Password_Manager
{
    public partial class Form1 : Form, IMessageFilter
    {
        private ushort menuItemIndex = 0;
        
        private SecureString ssmp;

        private List<Panel> menuItemList;

        private DataGridViewRowCollection originalRows;

        public Form1()
        {
            InitializeComponent();
            Application.AddMessageFilter(this);
        }

        public Form1(SecureString ssmp)
        {
            this.ssmp = ssmp;
            InitializeComponent();
            Application.AddMessageFilter(this);


            Bitmap passVaultIcon = new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream("Password_Manager.lock-icon.png"));
            Bitmap addNewPassIcon = new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream("Password_Manager.add-icon.png"));
            
            picboxPasswordVault.Image = passVaultIcon;
            picboxPasswordVault.Update();

            picboxAddNewPassword.Image = addNewPassIcon;
            picboxAddNewPassword.Update();


            menuItemList = new List<Panel>
            {
                pnlMenuItem1,
                pnlMenuItem2
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTitle.Text = $"YourPass - V{Program.VERSION_NUM:0.0}";
            LoadPasswordVault();
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

        #region UI/UX Code

        private Color menuItemSelected = Color.LightGray;
        private Color menuItemHighlighted = Color.Silver;
        private Color menuItemDeselected = Color.DarkGray;

        private void PnlMenuItem1_MouseEnter(object sender, EventArgs e)
        {
            PasswordVaultMouseEntered();
        }
        private void PnlMenuItem1_MouseLeave(object sender, EventArgs e)
        {
            if (pnlMenuItem1.BackColor != menuItemSelected)
                pnlMenuItem1.BackColor = menuItemDeselected;
        }
        private void PnlMenuItem1_MouseClick(object sender, MouseEventArgs e)
        {
            PasswordVaultClicked();
        }
        private void LblVault_MouseEnter(object sender, EventArgs e)
        {
            PasswordVaultMouseEntered();
        }
        private void LblVault_MouseClick(object sender, MouseEventArgs e)
        {
            PasswordVaultClicked();
        }
        private void PicboxPasswordVault_MouseEnter(object sender, EventArgs e)
        {
            PasswordVaultMouseEntered();
        }
        private void PicboxPasswordVault_MouseClick(object sender, MouseEventArgs e)
        {
            PasswordVaultClicked();
        }
        private void PasswordVaultMouseEntered()
        {
            if (pnlMenuItem1.BackColor != menuItemSelected)
                pnlMenuItem1.BackColor = menuItemHighlighted;
        }
        private void PasswordVaultClicked()
        {
            if (pnlMenuItem1.BackColor != menuItemSelected)
                pnlMenuItem1.BackColor = menuItemSelected;
            DeselectAllOtherItems(pnlMenuItem1);
            menuItemIndex = 0;
        }

        private void PnlMenuItem2_MouseEnter(object sender, EventArgs e)
        {
            AddNewPasswordMouseEntered();
        }
        private void PnlMenuItem2_MouseLeave(object sender, EventArgs e)
        {
            if (pnlMenuItem2.BackColor != menuItemSelected)
                pnlMenuItem2.BackColor = menuItemDeselected;
        }
        private void PnlMenuItem2_MouseClick(object sender, MouseEventArgs e)
        {
            AddNewPasswordClicked();
        }
        private void LblAddNewService_MouseEnter(object sender, EventArgs e)
        {
            AddNewPasswordMouseEntered();
        }
        private void LblAddNewService_MouseClick(object sender, MouseEventArgs e)
        {
            AddNewPasswordClicked();
        }
        private void PicboxAddNewPassword_MouseEnter(object sender, EventArgs e)
        {
            AddNewPasswordMouseEntered();
        }
        private void PicboxAddNewPassword_MouseClick(object sender, MouseEventArgs e)
        {
            AddNewPasswordClicked();
        }
        private void AddNewPasswordMouseEntered()
        {
            if (pnlMenuItem2.BackColor != menuItemSelected)
                pnlMenuItem2.BackColor = menuItemHighlighted;
        }
        private void AddNewPasswordClicked()
        {
            if (pnlMenuItem2.BackColor != menuItemSelected)
                pnlMenuItem2.BackColor = menuItemSelected;
            DeselectAllOtherItems(pnlMenuItem2);
            menuItemIndex = 1;
        }

        private void BtnRetrievePassword_Click(object sender, EventArgs e)
        {
            // If there isn't exactly one row that is selected, return.
            if (dgvPasswordVault.SelectedRows.Count != 1) return;

            // Set the plain text password in the textbox by retrieving the service name from the user selected row.
            txtboxPasswordRetrieval.Text = RetrievePasswordFromVault(dgvPasswordVault.SelectedRows[0].Cells[0].Value.ToString());
        }

        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == Program.WM_LBUTTONDOWN && (FromHandle(m.HWnd) == pnlDragbar || FromHandle(m.HWnd) == lblTitle))
            {
                ReleaseCapture();
                SendMessage(Handle, Program.WM_NCLBUTTONDOWN, Program.HT_CAPTION, 0);
                return true;
            }
            return false;
        }
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        
        private void DeselectAllOtherItems(Panel selectedItem)
        {
            for (int i = 0; i < menuItemList.Count; i++)
                if (menuItemList[i] != selectedItem)
                    menuItemList[i].BackColor = menuItemDeselected;
        }

        #endregion
        private void LoadPasswordVault()
        {
            dgvPasswordVault.Rows.Clear();
            using (IDbConnection conn = new SQLiteConnection(Program.CurrentConnectionString))
            {
                var output = conn.Query<Service>("SELECT service_name, email, username FROM PasswordVault;").ToList();
                for (int i = 0; i < output.Count; i++)
                    dgvPasswordVault.Rows.Add(output[i].ServiceName, output[i].Email, output[i].Name);
                
                //TODO: Clone rows received from DB in originalRows var.

            }
        }

        private string RetrievePasswordFromVault(string service_name)
        {
            using (IDbConnection conn = new SQLiteConnection(Program.CurrentConnectionString))
            {
                // Create Parameters to Sanitize Input
                DynamicParameters dp = new DynamicParameters();
                dp.Add("@service_name", service_name);

                return Crypto.SimpleDecryptWithPassword(
                    conn.ExecuteScalar(
                        "SELECT encrypted_password FROM PasswordVault WHERE service_name = @service_name",
                        dp) as string, GetMasterPassword());
            }
        }

        // Credit For Method: https://stackoverflow.com/questions/818704/how-to-convert-securestring-to-system-string
        private string GetMasterPassword()
        {
            IntPtr valuePtr = IntPtr.Zero;
            try
            {
                valuePtr = Marshal.SecureStringToGlobalAllocUnicode(ssmp);
                return Marshal.PtrToStringUni(valuePtr);
            } 
            finally 
            {
                Marshal.ZeroFreeGlobalAllocUnicode(valuePtr);
            }
        }

        private void BtnDisposePassword_Click(object sender, EventArgs e)
        {
            txtboxPasswordRetrieval.Text = string.Empty;
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void TxtboxServiceName_KeyPress(object sender, KeyPressEventArgs e)
        {
            FilterResults();
        }

        private void FilterResults()
        {
            dgvPasswordVault.Rows.Clear();

            HashSet<char> filter = new HashSet<char>(txtboxServiceName.Text.ToCharArray());

            for (int i = 0; i < originalRows.Count; i++) // O(n) where n is the amount of services stored.
            {
                string currentServiceName = originalRows[i].Cells[0].Value.ToString();
                for (int j = 0; j < currentServiceName.Length; j++) // Worst Case O(m), where m is the amount of characters in the service name.
                {
                    if (filter.Contains(currentServiceName[j]))
                    {
                        dgvPasswordVault.Rows.Add(originalRows[i]);
                        break;
                    }
                }
            }
        }
    }
}
