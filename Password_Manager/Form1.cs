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
        private readonly SecureString ssmp;
        private readonly List<Panel> menuItemList;
        private DataGridView originalTable;

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
            Bitmap editEntryIcon = new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream("Password_Manager.edit-icon.png"));

            picboxPasswordVault.Image = passVaultIcon;
            picboxPasswordVault.Update();

            picboxAddNewPassword.Image = addNewPassIcon;
            picboxAddNewPassword.Update();

            picboxEditEntry.Image = editEntryIcon;
            picboxEditEntry.Update();


            menuItemList = new List<Panel>
            {
                pnlMenuItem1,
                pnlMenuItem2,
                pnlMenuItem3
            };
            
            dgvPasswordVault.ClearSelection();
            txtboxServiceName.Select();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTitle.Text = Program.GetCaptionTitle(string.Empty);
            LoadPasswordVault();
        }
        
        #region UI/UX Code

        private Color menuItemSelected = Color.LightGray;
        private Color menuItemHighlighted = Color.Silver;
        private Color menuItemDeselected = Color.DarkGray;

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
            Hide();
            new AddNewPassword(this).Show();
        }
        public void NewPasswordAdded()
        {
            PasswordVaultClicked();
            LoadPasswordVault();
        }

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
            DeselectAllOtherItems(pnlMenuItem3);
            menuItemIndex = 2;

            // Functionality Here
        }
        private void EditEntryEntered()
        {
            if (pnlMenuItem3.BackColor != menuItemSelected)
                pnlMenuItem3.BackColor = menuItemHighlighted;
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
            return Program.PreFilterMessage(ref m, this, pnlDragbar, lblTitle);
        }

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
                var output = conn.Query<Service>("SELECT service_name, email, username FROM PasswordVault;").ToList();
                for (int i = 0; i < output.Count; i++)
                    dgvPasswordVault.Rows.Add(output[i].ServiceName, output[i].Email, output[i].Name);
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

        private void BtnDisposePassword_Click(object sender, EventArgs e)
        {
            txtboxPasswordRetrieval.Text = string.Empty;
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
            }
            else
                FilterResults(txtboxServiceName.Text + e.KeyChar);
        }

        private void FilterResults(string search_text)
        {
            dgvPasswordVault.Rows.Clear();

            List<char> caseInsensitiveCharArray = new List<char>();
            for (int i = 0; i < search_text.Length; i++)
            {
                caseInsensitiveCharArray.Add(char.ToLowerInvariant(search_text[i]));
                caseInsensitiveCharArray.Add(char.ToUpperInvariant(search_text[i]));
            }

            HashSet<char> filter = new HashSet<char>(caseInsensitiveCharArray);
            DataGridView originalTableClone = CopyDataGridView(originalTable);

            for (int i = 0; i < originalTableClone.Rows.Count; i++) // O(n) where n is the amount of services stored.
            {
                string currentServiceName = originalTableClone.Rows[i].Cells[0].Value.ToString();
                for (int j = 0; j < currentServiceName.Length; j++) // Worst Case O(m), where m is the amount of characters in the service name.
                {
                    if (filter.Contains(currentServiceName[j]))
                    {
                        dgvPasswordVault.Rows.Add(originalTableClone.Rows[i].Cells[0].Value, originalTableClone.Rows[i].Cells[1].Value, originalTableClone.Rows[i].Cells[2].Value);
                        break;
                    }
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
