using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Dapper;

namespace Password_Manager
{
    public partial class Form1 : Form, IMessageFilter
    {
        private ushort menuItemIndex = 0;
        private readonly Login loginForm;
        private readonly string vaultName;
        private SecureString ssmp;
        private readonly List<Panel> menuItemList;
        private DataGridView originalTable;

        // Created to fix weird bug with the custom resizing method WndProc.
        private readonly bool isFormLoaded;

        public Form1()
        {
            InitializeComponent();
            Application.AddMessageFilter(this);
        }

        public Form1(Login loginForm, string vaultName, SecureString ssmp)
        {
            this.loginForm = loginForm;
            this.vaultName = vaultName;
            this.ssmp = ssmp;
            InitializeComponent();
            Application.AddMessageFilter(this);
            isFormLoaded = true;


            Bitmap passVaultIcon = new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream("Password_Manager.lock-icon.png"));
            Bitmap addNewPassIcon = new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream("Password_Manager.add-icon.png"));
            Bitmap editEntryIcon = new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream("Password_Manager.edit-icon.png"));
            
            Bitmap mainWindowIcon = new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream("Password_Manager.key-icon.png"));
            // Credit for mainWindowIcon -> "Icon made by Freepik[https://www.flaticon.com/authors/freepik] from www.flaticon.com"
            
            Bitmap switchIcon = new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream("Password_Manager.switch-icon.png"));
            // Credit for switchIcon -> "Icon made by Freepik[https://www.flaticon.com/authors/freepik] from www.flaticon.com"

            Bitmap aboutIcon = new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream("Password_Manager.question-icon.png"));
            // Credit for aboutIcon -> "Icon made by Roundicons[https://www.flaticon.com/authors/roundicons] from www.flaticon.com"

            picboxPasswordVault.Image = passVaultIcon;
            picboxPasswordVault.Update();

            picboxAddNewPassword.Image = addNewPassIcon;
            picboxAddNewPassword.Update();

            picboxEditEntry.Image = editEntryIcon;
            picboxEditEntry.Update();

            picboxWindowIcon.Image = mainWindowIcon;
            picboxWindowIcon.Update();

            picboxSwitchVaults.Image = switchIcon;
            picboxSwitchVaults.Update();

            picboxAbout.Image = aboutIcon;
            picboxAbout.Update();


            menuItemList = new List<Panel>
            {
                pnlMenuItem1,
                pnlMenuItem2,
                pnlMenuItem3,
                pnlMenuItem4,
                pnlMenuItem99
            };
            
            txtboxServiceName.Select();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTitle.Text = Program.GetCaptionTitle($"Viewing \"{vaultName}\"");
            LoadPasswordVault();
        }
        
        #region UI/UX Code

        private Color menuItemSelected = Color.LightGray;
        private Color menuItemHighlighted = Color.Silver;
        private Color menuItemDeselected = Color.DarkGray;

        #region Titlebar/Window Controls
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
        public bool PreFilterMessage(ref Message m)
        {
            return Program.PreFilterMessage(ref m, this, pnlDragbar, lblTitle);
        }
        // Credit for Method: https://stackoverflow.com/questions/1535826/resize-borderless-window-on-bottom-right-corner
        #region credit
        protected override void WndProc(ref Message m)
        {
            const int wmNcHitTest = 0x84;
            const int htLeft = 10;
            const int htRight = 11;
            const int htTop = 12;
            const int htTopLeft = 13;
            const int htTopRight = 14;
            const int htBottom = 15;
            const int htBottomLeft = 16;
            const int htBottomRight = 17;

            if (m.Msg == wmNcHitTest)
            {
                int x = (int)(m.LParam.ToInt64() & 0xFFFF);
                int y = (int)((m.LParam.ToInt64() & 0xFFFF0000) >> 16);
                Point pt = PointToClient(new Point(x, y));
                Size clientSize = ClientSize;
                ///allow resize on the lower right corner
                if (pt.X >= clientSize.Width - 16 && pt.Y >= clientSize.Height - 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(IsMirrored ? htBottomLeft : htBottomRight);
                    return;
                }
                ///allow resize on the lower left corner
                if (pt.X <= 16 && pt.Y >= clientSize.Height - 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(IsMirrored ? htBottomRight : htBottomLeft);
                    return;
                }
                ///allow resize on the upper right corner
                if (pt.X <= 16 && pt.Y <= 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(IsMirrored ? htTopRight : htTopLeft);
                    return;
                }
                ///allow resize on the upper left corner
                if (pt.X >= clientSize.Width - 16 && pt.Y <= 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(IsMirrored ? htTopLeft : htTopRight);
                    return;
                }
                ///allow resize on the top border
                if (pt.Y <= 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(htTop);
                    return;
                }
                ///allow resize on the bottom border
                if (pt.Y >= clientSize.Height - 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(htBottom);
                    return;
                }
                ///allow resize on the left border
                if (pt.X <= 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(htLeft);
                    return;
                }
                ///allow resize on the right border
                if (pt.X >= clientSize.Width - 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(htRight);
                    return;
                }
            }

            if (isFormLoaded)
                base.WndProc(ref m);
        }
        
        //***********************************************************
        //***********************************************************
        //This gives us the drop shadow behind the borderless form
        private const int CS_DROPSHADOW = 0x20000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        #endregion
        #endregion

        #region Password Vault/Menu Item 1
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
        public void PasswordVaultClicked()
        {
            if (pnlMenuItem1.BackColor != menuItemSelected)
                pnlMenuItem1.BackColor = menuItemSelected;
            DeselectAllOtherItems(pnlMenuItem1);
            menuItemIndex = 0;
        }
        #endregion

        #region Add a New Password/Menu Item 2
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
            
            new AddNewPassword(this).ShowDialog();
        }
        public void VaultInformationUpdated()
        {
            PasswordVaultClicked();
            LoadPasswordVault();
        }
        #endregion

        #region Edit Entry/Menu Item 3
        private void PnlEditEntry_MouseEnter(object sender, EventArgs e)
        {
            EditEntryEntered();
        }
        private void PnlEditEntry_MouseLeave(object sender, EventArgs e)
        {
            if (pnlMenuItem3.BackColor != menuItemSelected)
                pnlMenuItem3.BackColor = menuItemDeselected;
        }
        private void PnlEditEntry_MouseClick(object sender, MouseEventArgs e)
        {
            EditEntryClicked();
        }
        private void LblEditEntry_MouseEnter(object sender, EventArgs e)
        {
            EditEntryEntered();
        }
        private void LblEditEntry_MouseClick(object sender, MouseEventArgs e)
        {
            EditEntryClicked();
        }
        private void PicboxEditEntry_MouseEnter(object sender, EventArgs e)
        {
            EditEntryEntered();
        }
        private void PicboxEditEntry_MouseClick(object sender, MouseEventArgs e)
        {
            EditEntryClicked();
        }
        private void EditEntryClicked()
        {
            if (pnlMenuItem3.BackColor != menuItemSelected)
                pnlMenuItem3.BackColor = menuItemSelected;
            DeselectAllOtherItems(pnlMenuItem1);
            menuItemIndex = 2;

            if (dgvPasswordVault.SelectedRows.Count != 1)
            {
                MessageBox.Show("Error: You must select one specific service to edit.", Program.GetCaptionTitle("Service Selection Error"), MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

            // Functionality
            string serv_name = dgvPasswordVault.SelectedRows[0].Cells[0].Value as string;
            new EditEntry(this, serv_name).ShowDialog();
        }
        private void EditEntryEntered()
        {
            if (pnlMenuItem3.BackColor != menuItemSelected)
                pnlMenuItem3.BackColor = menuItemHighlighted;
        }
        #endregion

        #region Switch Password Vault/Menu Item 4
        private void PnlMenuItem4_MouseEnter(object sender, EventArgs e)
        {
            SwitchVaultMouseEntered();
        }
        private void PnlMenuItem4_MouseLeave(object sender, EventArgs e)
        {
            if (pnlMenuItem4.BackColor != menuItemSelected)
                pnlMenuItem4.BackColor = menuItemDeselected;
        }
        private void PnlMenuItem4_MouseClick(object sender, MouseEventArgs e)
        {
            SwitchVaultClicked();
        }
        private void LblSwitchVaults_MouseEnter(object sender, EventArgs e)
        {
            SwitchVaultMouseEntered();
        }
        private void LblSwitchVaults_MouseClick(object sender, MouseEventArgs e)
        {
            SwitchVaultClicked();
        }
        private void PicboxSwitchVaults_MouseEnter(object sender, EventArgs e)
        {
            SwitchVaultMouseEntered();
        }
        private void PicboxSwitchVaults_MouseClick(object sender, MouseEventArgs e)
        {
            SwitchVaultClicked();
        }
        private void SwitchVaultMouseEntered()
        {
            if (pnlMenuItem4.BackColor != menuItemSelected)
                pnlMenuItem4.BackColor = menuItemHighlighted;
        }
        private void SwitchVaultClicked()
        {
            if (pnlMenuItem4.BackColor != menuItemSelected)
                pnlMenuItem4.BackColor = menuItemSelected;
            DeselectAllOtherItems(pnlMenuItem4);
            menuItemIndex = 3;

            // Functionality

            // Remove old master password from memory
            ssmp.Dispose();
            ssmp = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();

            // Remove the any plain text password that is still being displayed.
            btnDisposePassword.PerformClick();

            // Close the current view
            Close();

            // Show login form to user again
            loginForm.Show();
        }
        #endregion

        #region About/Last Menu Item
        private void PnlMenuItem99_MouseEnter(object sender, EventArgs e)
        {
            AboutMouseEntered();
        }
        private void PnlMenuItem99_MouseLeave(object sender, EventArgs e)
        {
            if (pnlMenuItem99.BackColor != menuItemSelected)
                pnlMenuItem99.BackColor = menuItemDeselected;
        }
        private void PnlMenuItem99_MouseClick(object sender, MouseEventArgs e)
        {
            AboutClicked();
        }
        private void LblAbout_MouseEnter(object sender, EventArgs e)
        {
            AboutMouseEntered();
        }
        private void LblAbout_MouseClick(object sender, MouseEventArgs e)
        {
            AboutClicked();
        }
        private void PicboxAbout_MouseEnter(object sender, EventArgs e)
        {
            AboutMouseEntered();
        }
        private void PicboxAbout_MouseClick(object sender, MouseEventArgs e)
        {
            AboutClicked();
        }
        private void AboutMouseEntered()
        {
            if (pnlMenuItem99.BackColor != menuItemSelected)
                pnlMenuItem99.BackColor = menuItemHighlighted;
        }
        private void AboutClicked()
        {
            if (pnlMenuItem99.BackColor != menuItemSelected)
                pnlMenuItem99.BackColor = menuItemSelected;
            DeselectAllOtherItems(pnlMenuItem99);
            menuItemIndex = 99;

            // Functionality
            new About(this).ShowDialog();
        }
        #endregion

        private void DeselectAllOtherItems(Panel selectedItem)
        {
            for (int i = 0; i < menuItemList.Count; i++)
                if (menuItemList[i] != selectedItem)
                    menuItemList[i].BackColor = menuItemDeselected;
        }
        #endregion

        #region Password Retrieval and Disposal
        private void LoadPasswordVault()
        {
            dgvPasswordVault.Rows.Clear();
            using (IDbConnection conn = new SQLiteConnection(Program.CurrentConnectionString))
            {
                var output = conn.Query<Service>("SELECT service_name, email, username FROM PasswordVault WHERE id != 1;").ToList();
                for (int i = 0; i < output.Count; i++)
                    dgvPasswordVault.Rows.Add(output[i].ServiceName, output[i].Name, output[i].Email);
            }
            originalTable = CopyDataGridView(dgvPasswordVault);
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
        public string GetMasterPassword()
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
        
        private void BtnRetrievePassword_Click(object sender, EventArgs e)
        {
            // If there isn't exactly one row that is selected, return.
            if (dgvPasswordVault.SelectedRows.Count != 1) return;

            //Dispose of Previous Password
            btnDisposePassword.PerformClick();

            // Create service_name local variable
            string service_name = dgvPasswordVault.SelectedRows[0].Cells[0].Value.ToString();

            // Update flavor text
            lblPasswordRetrieved.Text = $"Password Retrieved from: \"{service_name}\"";

            // Set the plain text password in the textbox by retrieving the service name from the user selected row.
            txtboxPasswordRetrieval.Text = RetrievePasswordFromVault(service_name);
        }
        private void BtnDisposePassword_Click(object sender, EventArgs e)
        {
            // Update flavor text
            lblPasswordRetrieved.Text = "Password Retrieved from: No Service Selected.";

            // Zero out the string.
            txtboxPasswordRetrieval.Text = string.Empty;
            
            // Force GC to remove the string from memory.
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        #endregion

        #region Result Filtering
        private void TxtboxServiceName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                if (txtboxServiceName.Text.Length - 1 <= 0)
                {
                    dgvPasswordVault.Rows.Clear();
                    for (int i = 0; i < originalTable.Rows.Count; i++)
                        dgvPasswordVault.Rows.Add(originalTable.Rows[i].Cells[0].Value, originalTable.Rows[i].Cells[1].Value, originalTable.Rows[i].Cells[2].Value);
                }
                else
                    FilterResults(txtboxServiceName.Text.Substring(0, txtboxServiceName.Text.Length - 1));
            }
            else
                FilterResults(txtboxServiceName.Text + e.KeyChar);
        }

        private void FilterResults(string search_text)
        {
            dgvPasswordVault.Rows.Clear();


            string regex = string.Empty;
            for (int i = 0; i < search_text.Length; i++)
            {
                if (i != 0)
                    regex += $"[{search_text[i]}]+";
                else
                    regex += $"[{search_text[i]}]";
            }

            DataGridView originalTableClone = CopyDataGridView(originalTable);

            for (int i = 0; i < originalTableClone.Rows.Count; i++) // O(n) where n is the amount of services stored.
            {
                string currentServiceName = originalTableClone.Rows[i].Cells[0].Value.ToString();
                if (Regex.Matches(currentServiceName, regex, RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.CultureInvariant).Count > 0)
                {
                    dgvPasswordVault.Rows.Add(originalTableClone.Rows[i].Cells[0].Value, originalTableClone.Rows[i].Cells[1].Value, originalTableClone.Rows[i].Cells[2].Value);
                }
            }
        }

        // Credit for Method: https://stackoverflow.com/questions/6336239/copy-datagridviews-rows-into-another-datagridview
        private DataGridView CopyDataGridView(DataGridView dgv_org)
        {
            DataGridView dgvCopy = new DataGridView();
            try
            {
                if (dgvCopy.Columns.Count == 0)
                    foreach (DataGridViewColumn dgvc in dgv_org.Columns)
                        dgvCopy.Columns.Add(dgvc.Clone() as DataGridViewColumn);

                DataGridViewRow row = new DataGridViewRow();

                for (int i = 0; i < dgv_org.Rows.Count; i++)
                {
                    row = (DataGridViewRow)dgv_org.Rows[i].Clone();
                    int intColIndex = 0;
                    foreach (DataGridViewCell cell in dgv_org.Rows[i].Cells)
                    {
                        row.Cells[intColIndex].Value = cell.Value;
                        intColIndex++;
                    }
                    dgvCopy.Rows.Add(row);
                }
                dgvCopy.AllowUserToAddRows = false;
                dgvCopy.Refresh();

            } catch (Exception) { }
            return dgvCopy;
        }

        #endregion

    }
}
