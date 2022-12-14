using AltoHttp;
using Microsoft.Win32;
using StudentProgramCsharp.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Data.Entity.Infrastructure.Design.Executor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentProgramCsharp.user_control
{   
    public partial class DownloadList : UserControl
    {
        private DBOperations update = new DBOperations();
        private Checking check = new Checking();

        public DownloadList()
        {
            InitializeComponent();

        }


        private void DownloadList_Load(object sender, EventArgs e)
        {
            //Start with Checking
            Checking();
        }


        //Fun to return path of user Download folder
        string GetDownloadFolderPath()
        {
            return Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "{374DE290-123F-4565-9164-39C4925E467B}", String.Empty).ToString();
        }

        //Fun for download fill from URL
        private void start_Download()
        {
            try
            {
                Directory.CreateDirectory(GetDownloadFolderPath() + @"\Studen Program");
                httpDownloader = new HttpDownloader(Url, GetDownloadFolderPath() + @"\Studen Program\" + Path.GetFileName(Url));
                httpDownloader.DownloadCompleted += HttpDownloader_DownloadCompleted;
                httpDownloader.ProgressChanged += HttpDownloader_ProgressChanged;
                httpDownloader.Start();
                lab_processing.Text = "Downloading....";
            }
            catch
            {
                lab_processing.Text = "Try Later....";

            }

        }

        //Fun when Progress is Changed
        private void HttpDownloader_ProgressChanged(object sender, AltoHttp.ProgressChangedEventArgs e)
        {
            progressBar1.Value = (int)e.Progress;
            lbspeed.Text = String.Format("{0} MB/s", (e.SpeedInBytes / 1024d / 1024d).ToString("0.00"));

        }

        //Fun Delete file and change Database Status
        private void DeleteFile(string path = null)
        {
            try
            {
                //Delete file from path
                File.Delete(GetDownloadFolderPath() + @"\Studen Program\" + Path.GetFileName(Url));

                //remove from Download page
                Form1.Instance.Downloads_flowLayoutPanel.Controls.RemoveByKey(ProgramName);

                //change Status in ProgramsData Table to New
                update.UpdataStatus("New", ProgramName);
            }
            catch 
            { 
                MessageBox.Show(ProgramName +" is still working"); 
            }

            


        }

        //Fun for if Download is Completed
        private void HttpDownloader_DownloadCompleted(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                lab_processing.Text = "Download Completed";
                but_stop.Enabled = false;
                but_Remove.Enabled = true ;
                but_Install.Enabled = true;
                but_Remove.BringToFront();
                lbspeed.Text = "";

                //change Status in ProgramsData Table to Complete
                update.UpdataStatus("Complete", ProgramName);


            });
        }

        //Fun for Checking Download page
        private void Checking()
        {
            //check if Download is Completed
            if (check.DownloadCompleted(ProgramName))
            {
                lab_processing.Text = "Download Completed";
                but_stop.Enabled = false;
                but_Remove.Enabled = true;
                but_Install.Enabled = true;
                but_Remove.BringToFront();
                lbspeed.Text = "";
                progressBar1.Value = 100;
            }
            else
                start_Download();
        }

        //Fun back ground install
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Process.Start(GetDownloadFolderPath() + @"\Studen Program\" + Path.GetFileName(Url));
            }
            catch { }
            {

            }
        }

        //get set
        #region Properties
        private Image _icone;
        private string _name;
        private string _procssing;
        private string _url;
        HttpDownloader httpDownloader;

        




        [Category("Custom Props")]
        public Image Icone
        {
            get { return _icone; }
            set { _icone = value; pictureBox1.Image = value; }
        }


        [Category("Custom Props")]
        public string ProgramName
        {
            get { return _name; }
            set { _name = value; 
                lab_Program_name.Text = value;

            }
        }



        [Category("Custom Props")]
        public string Procssing
        {
            get { return _procssing; }

            set
            {
                _procssing = value;
                _procssing = value; lab_processing.Text = value;
            }
        }


        [Category("Custom Props")]
        public string Url
        {
            get { return _url; }
            set { _url = value;}
        }


        #endregion

        //Button for Pause or Resume the Download
        private void but_stop_Click(object sender, EventArgs e)
        {
            //if Paused Resume
            if (httpDownloader.State == AltoHttp.Status.Paused)
            {
                but_stop.Text = "Pause";
                lab_processing.Text = "Downloading....";
                httpDownloader.Resume();

            }

            //if Resume Paused
            else if (httpDownloader.State != AltoHttp.Status.Paused)
            {
                lbspeed.Text = "0.00 MB/s";
                but_stop.Text = "Resume";
                lab_processing.Text = "Paused...";
                httpDownloader.Pause();
                
                

            }

                
        }

        //Button for installing the application
        private void but_Install_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
                MessageBox.Show("The installation is Running");
            else
                backgroundWorker1.RunWorkerAsync();

        }

        //Button for deleting
        private void but_Remove_Click(object sender, EventArgs e)
        {   
            //if Settings DontShow == false show message form
            if (!Properties.Settings.Default.DontShow)
            {   
                MessageForm messageForm =  new MessageForm();
                messageForm.message("Are you sure to delete this file " + ProgramName);
                messageForm.ShowDialog();

                //if OK is clicked delete file
                if (messageForm.Status)
                {
                    DeleteFile();   
                }

            }

            //if Settings DontShow == true delete file
            else if (Properties.Settings.Default.DontShow)
            {
                DeleteFile();

            }


        }
    }
}
