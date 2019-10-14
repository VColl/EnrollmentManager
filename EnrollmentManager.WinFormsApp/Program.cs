using EnrollmentManager.Business;
using Ninject;
using System;
using System.Windows.Forms;

namespace EnrollmentManager.WinFormsApp
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

            IKernel kernel = new StandardKernel(new WindowsAppModule(), new DefaultBusinessModule());
            var mainView = kernel.Get<MainView>();

            Application.Run(mainView);
        }
    }
}
