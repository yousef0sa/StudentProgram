using StudentProgramCsharp.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using StudentProgramCsharp.Database;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.SqlServer.Server;
using StudentProgramCsharp.user_control;
using System.Security.Policy;
using System.Diagnostics;

namespace StudentProgramCsharp
{
    public partial class ProgramPage : UserControl
    {
        public ProgramPage()
        {
            InitializeComponent();



        }

        private void ProgramPage_Load(object sender, EventArgs e)
        {   //checking data parameter 
            checking();

            //resize label
            resize();
        }
        //get set
        #region Properties
        private Image _icone;
        private string _title;
        private string _install;
        private string _browse;




        [Category("Custom Props")]
        public Image Icone
        {
            get { return _icone; }
            set { _icone = value; pictureBox1.Image = value; }
        }


        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value; lblTitle.Text = value;

            }
        }

        [Category("Custom Props")]
        public string Install
        {
            get { return _install; }

            set { _install = value; }
        }

        [Category("Custom Props")]
        public string Browse
        {
            get { return _browse; }

            set { _browse = value; }
        }





        #endregion

        //Fun for resize label
        private void resize()
        {
            int x = (this.Width / 2) - (lblTitle.Width / 2);
            lblTitle.Left = x;

        }

        //Fun for checking data parameter 
        private void checking()
        {
            CDB readData = new CDB();

            SqlDataReader dataReader;
            String sql = "Select * From ProgramsData WHERE CONVERT(varchar,Name) = " + String.Format("'{0}'", _title);
            SqlCommand myCommand = new SqlCommand(sql, readData._con());
            readData.open();
            dataReader = myCommand.ExecuteReader();
            dataReader.Read();

            if (dataReader["Url"].ToString() == "")
            {
                button1.Enabled = false;
            }
            else
            {
                if (dataReader["Status"].ToString() == "New")
                    button1.Enabled = true;
                else button1.Enabled = false;
            }
            readData.close();

        }

        //Button to Download
        private void button1_Click(object sender, EventArgs e)
        {
            CDB readData = new CDB();

            //change Status in ProgramsData Table to Listed 
            string cmd = "UPDATE ProgramsData SET Status = 'Listed' WHERE CONVERT(VARCHAR,Name) = " + String.Format("'{0}'", _title);
            SqlCommand myCommand = new SqlCommand(cmd, readData._con());
            readData.open();
            myCommand.ExecuteNonQuery();
            readData.close();


            //add to Downloads
            SqlDataReader dataReader;
            String sql = "Select * From ProgramsData WHERE CONVERT(VARCHAR,Name) = " + String.Format("'{0}'", _title);
            myCommand = new SqlCommand(sql, readData._con());
            readData.open();
            dataReader = myCommand.ExecuteReader();
            DownloadList listItems = new DownloadList();
            dataReader.Read();

            listItems.Name = dataReader["Name"].ToString();
            listItems.ProgramName = dataReader["Name"].ToString();
            listItems.Url = dataReader["Url"].ToString();


            if (Form1.Instance.Downloads_flowLayoutPanel.Controls.Count < 0)
            {
                Form1.Instance.Downloads_flowLayoutPanel.Controls.Clear();
            }
            else
                Form1.Instance.Downloads_flowLayoutPanel.Controls.Add(listItems);

            readData.close();

            button1.Enabled = false;


        }

        //Browse the program's website
        private void lblTitle_Click(object sender, EventArgs e)
        {
            if (_browse != "")
            {
                Process.Start(_browse);
            }


        }

    }
}
