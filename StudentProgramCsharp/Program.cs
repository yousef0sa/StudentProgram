using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentProgramCsharp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static Form SplashScreen;
        static Form MainForm;
        [STAThread]
        static void Main()
        { 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Show Splash Form
            SplashScreen = new SplashScreen();
            var splashThread = new Thread(new ThreadStart(
                () => Application.Run(SplashScreen)));
            splashThread.SetApartmentState(ApartmentState.STA);
            splashThread.Start();

            //Create and Show Main Form
            MainForm = new Form1();
            MainForm.Load += MainForm_LoadCompleted;
            Application.Run(MainForm);

        }

        private static void MainForm_LoadCompleted(object sender, EventArgs e)
        {
            if (SplashScreen != null && !SplashScreen.Disposing && !SplashScreen.IsDisposed)
                SplashScreen.Invoke(new Action(() => SplashScreen.Close()));
            MainForm.TopMost = true;
            MainForm.Activate();
            MainForm.TopMost = false;
        }
    }
}
