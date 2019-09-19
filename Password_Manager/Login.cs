using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace Password_Manager
{
    public partial class Login : Form, IMessageFilter
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public const int WM_LBUTTONDOWN = 0x0201;

        public const float VERSION_NUM = 1.0f;

        public Login()
        {
            InitializeComponent();
            lblWelcome.Text += $"{VERSION_NUM:0.0}";
            Application.AddMessageFilter(this);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Check for all databases found

            // If there is a database found, change control focus to txtboxMasterPass

            // If there is no database found, change control focus to menuPasswordDB


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
        }
    }
}
