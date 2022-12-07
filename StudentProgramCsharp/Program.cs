using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Serilog;

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
            //Creating logs file 
            Log.Logger = new LoggerConfiguration()

                //WriteTo Console
                .WriteTo.Console()

                //WriteTo File when Log Event Level => Information 
                .WriteTo.File("logs/log.txt",
                restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Information,
                rollingInterval: RollingInterval.Day)

                //WriteTo File when Log Event Level => Warning
                .WriteTo.File("logs/errorlog.txt", restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Warning)

                //CreateLogger
                .CreateLogger();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                Log.Information("Starting our service..");

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
            catch (SystemException ex)
            {
                Log.Fatal(ex, "Exception in application");
            }
            finally
            {
                Log.Information("Exiting service");
                Log.CloseAndFlush();
            }

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
