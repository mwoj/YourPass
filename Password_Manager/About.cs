using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Manager
{
    public partial class About : Form, IMessageFilter
    {
        private readonly Form1 mainWindow;
        public About()
        {
            InitializeComponent();
            Application.AddMessageFilter(this);
        }

        public About(Form1 mainWindow)
        {
            InitializeComponent();
            Application.AddMessageFilter(this);

            this.mainWindow = mainWindow;
            lblTitle.Text = Program.GetCaptionTitle("About");

            Bitmap mainIcon = new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream("Password_Manager.question-icon.png"));

            picboxIcon.Image = mainIcon;
            picboxIcon.Update();
        }

        public bool PreFilterMessage(ref Message m)
        {
            return Program.PreFilterMessage(ref m, this, pnlDragbar, lblTitle);
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }
        private void BtnOk_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }
        private void CloseWindow()
        {
            Close();
            mainWindow.PasswordVaultClicked();
        }

        private void LnklblGithubSoftwareEngineer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/mwoj");
        }
        private void LnklblFreepik_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.flaticon.com/authors/freepik");
        }
        private void LnklblRoundicons_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.flaticon.com/authors/roundicons");
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
