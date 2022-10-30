using AltoHttp;
using StudentProgramCsharp.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentProgramCsharp.user_control
{
    public partial class DownloadList : UserControl
    {
        public DownloadList()
        {
            InitializeComponent();

        }


        private void DownloadList_Load(object sender, EventArgs e)
        {

            start_Download();
        }

        //Fun when Progress is Changed
        private void HttpDownloader_ProgressChanged(object sender, AltoHttp.ProgressChangedEventArgs e)
        {
            progressBar1.Value = (int)e.Progress;
            lbspeed.Text = String.Format("{0} MB/s", (e.SpeedInBytes / 1024d / 1024d).ToString("0.00"));

        }


        //Fun for if Download is Completed
        private void HttpDownloader_DownloadCompleted(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                lab_processing.Text = "Download Completed";
                but_stop.Enabled = false;
                but_Install.Enabled = true;
                lbspeed.Text = "0.00 MB/s";

            });
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


        //Fun for download fill from URL
        private void start_Download()
        {
            try
            {
                httpDownloader = new HttpDownloader(Url, $"{"C:\\Download"}\\{Path.GetFileName(Url)}");
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
            
            RunCMD install = new RunCMD();
            install.cmd(@"C:\Download\" + Path.GetFileName(Url));


        }
    }
}
