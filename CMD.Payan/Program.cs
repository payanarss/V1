using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using BaseComapny = CMD.Payan.Base.Company;
using CMD.Payan.Hrms.Views;

namespace Payanar.SSNamespace
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            PayanarApplication.OnStart();
            Application.Run(new CmdPayanMainView());
        }

        public static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.Message, BaseComapny.Company.CompanyDetail.Name);
        }
    }
}