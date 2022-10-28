﻿using StudentProgramCsharp.Class;
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

namespace StudentProgramCsharp
{
    public partial class ProgramPage : UserControl
    {
        public ProgramPage()
        {
            InitializeComponent();
            


        }

        #region Properties
        private Image _icone;
        private string _title;
        private string _install;



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
                if (lblTitle.Parent != null)
                { //this if check may be removed if it's sure that Parent is not null
                    lblTitle.Left = (lblTitle.Parent.Width - lblTitle.Width) / 2;
                    checkking();
                }
            }
        }

        [Category("Custom Props")]
        public string Install
        {
            get { return _install; }

            set { _install = value; }
        }



        #endregion


        private void checkking ()
        {
            CDB readData = new CDB();
            readData._con();

            SqlDataReader dataReader;
            String sql = "Select * From ProgramsData WHERE CONVERT(varchar,Name) = " + String.Format("'{0}'", _title);
            SqlCommand myCommand = new SqlCommand(sql, readData._con());
            readData.open();
            dataReader = myCommand.ExecuteReader();
            dataReader.Read();


            if (dataReader["Status"].ToString() == "Listed")
                button1.Enabled = false;

            readData.close();









        }

        private void button1_Click(object sender, EventArgs e)
        {
            CDB readData = new CDB();
            readData._con();

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


            listItems.ProgramName = dataReader["Name"].ToString();
            Properties.Settings.Default.SettingUrl = dataReader["Url"].ToString();
            Properties.Settings.Default.Save();
            listItems.Url = Properties.Settings.Default.SettingUrl.ToString();



            if (Form1.Instance.Downloads_flowLayoutPanel.Controls.Count < 0)
            {
                Form1.Instance.Downloads_flowLayoutPanel.Controls.Clear();
            }
            else
                Form1.Instance.Downloads_flowLayoutPanel.Controls.Add(listItems);

            readData.close();

            button1.Enabled = false;


        }

    }
}