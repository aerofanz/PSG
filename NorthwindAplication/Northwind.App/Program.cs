using Northwind.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.App
{
    static class Program
    {
        public static User user = null;
        private static bool _isLogout;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmLogin());
            Login();
        }

        private static void Login()
        {
            var frmMain = new FrmMain();
            frmMain.FormClosed += frmMain_FormClosed;

            var frmLogin = new FrmLogin();
            if(frmLogin.ShowDialog(frmMain) == DialogResult.OK)
            {
                SetDefaultRegionalSetting();
                Application.Run(frmMain);
                if (_isLogout)
                    Login();
                else
                    Application.Exit();
            }
            else
            {
                Application.Exit();
            }


        }

        private static void SetDefaultRegionalSetting()
        {
            var cultureInfo = Thread.CurrentThread.CurrentCulture;
            var regionInfo = new RegionInfo(cultureInfo.LCID);

            string englishName = regionInfo.EnglishName;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("id-ID");
        }

        private static void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            _isLogout = ((FrmMain)sender).IsLogout;
        }
    }
}
