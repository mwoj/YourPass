using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
    }
}
