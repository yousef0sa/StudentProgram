using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentProgramCsharp.Class
{
    internal class TitleBar
    {
        //Maximized this Window
        public void Maximized(Form WindowForm)
        {
            if (WindowForm.WindowState == FormWindowState.Maximized)
            {
                WindowForm.WindowState = FormWindowState.Normal;
            }
            else if (WindowForm.WindowState == FormWindowState.Normal)
            {
                WindowForm.WindowState = FormWindowState.Maximized;
            }
        }

        //Minimized  Window
        public void Minimized(Form WindowForm)
        {
            WindowForm.WindowState = FormWindowState.Minimized;
        }

        //exit Application
        public void Exit()
        {
            Form1.Instance.Close();
            Application.Exit();
            Application.ExitThread();
            Environment.Exit(0);
            //Environment.Exit(Environment.ExitCode);
        }

       
    } 
}
