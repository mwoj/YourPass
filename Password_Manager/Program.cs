using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Manager
{
    static class Program
    {
        public static string CurrentConnectionString = "";
        public static readonly float VERSION_NUM = 1.0f;

        public static readonly int WM_NCLBUTTONDOWN = 0xA1;
        public static readonly int HT_CAPTION = 0x2;
        public static readonly int WM_LBUTTONDOWN = 0x0201;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }

        public static string GetCaptionTitle(string message)
        {
            return $@"YourPass V{VERSION_NUM:0.0}" + (message != string.Empty ? $" - {message}" : "");
        }
        public static bool PreFilterMessage(ref Message m, Control mainWindow, params Control[] controlsCaptured)
        {
            if (m.Msg == WM_LBUTTONDOWN)
            {
                for (int i = 0; i < controlsCaptured.Length; i++)
                {
                    if (Control.FromHandle(m.HWnd) == controlsCaptured[i])
                    {
                        ReleaseCapture();
                        SendMessage(mainWindow.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                        return true;
                    }
                }
            }
            return false;
        }

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
    }
}
