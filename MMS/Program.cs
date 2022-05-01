using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.LookAndFeel;

namespace MMS
{
    static class Program
    {

         public static string Emp_name;
         public static  bool isLogin = false;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
         static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DevExpress.UserSkins.BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");

            Application.Run(new frm_Main());
        }
    }
}
