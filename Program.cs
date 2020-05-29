using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login());
        }
        public static string username;
        public static string status;
        public static string selectnumber;
        public static string selectmenubuffe;//เลือกเมนูบุฟเฟ่
        public static string manypeoplebuffe;//จำนวนคนนั่งกินบุฟเฟ่
    }
}
