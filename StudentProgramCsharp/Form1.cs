using StudentProgramCsharp.user_control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using StudentProgramCsharp.Database;
using System.Data.Common;
using System.Data.SqlClient;
using System.Reflection.Emit;
using StudentProgramCsharp.Properties;
using System.Linq.Expressions;

namespace StudentProgramCsharp
{
    public partial class Form1 : Form
    {
        static Form1 _obj;

        public static Form1 Instance
        { 
            get 
            { 
                if (_obj == null)
                    _obj = new Form1();
                return _obj; 
            } 
        }

        public Form1()
        {
            InitializeComponent();
            _obj = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            popuProgramItems();
            popuDownloadItems();
        }
        

        private void popuProgramItems()
        {
            CDB readData = new CDB();
            int x = readData.count_Row("ProgramsData"); //Count the number of rows in the table

            SqlCommand cmd;
            SqlDataReader dataReader;
            String sql = "";
            int number = 0;

            sql = "Select * From ProgramsData";
            cmd = new SqlCommand(sql, readData._con());
            readData.open();

            dataReader = cmd.ExecuteReader();
            ProgramPage[] listItems = new ProgramPage[x];

            while (dataReader.Read())
            {
                listItems[number] = new ProgramPage();
                listItems[number].Title = dataReader["Name"].ToString();
                listItems[number].Install = dataReader["Url"].ToString();
             


                if (Programs_flowLayoutPanel.Controls.Count < 0)
                {
                    Programs_flowLayoutPanel.Controls.Clear();
                }
                else
                    Programs_flowLayoutPanel.Controls.Add(listItems[number]);

                number++;


            }
            number = 0;
            dataReader.Close();
            readData.close();

        }

    


        private void popuDownloadItems()
        {
            CDB readData = new CDB();

            //Count the number of rows in the table
            int x = readData.count_Row("ProgramsData" , " where CONVERT(VARCHAR,Status) not in ('New')"); 

            SqlCommand cmd;
            SqlDataReader dataReader;
            String sql = "";
            int number = 0;

            sql = "Select * From ProgramsData where CONVERT(VARCHAR,Status) not in ('New')";
            cmd = new SqlCommand(sql, readData._con());
            readData.open();

            dataReader = cmd.ExecuteReader();
            DownloadList[] listItems = new DownloadList[x];
            
            while (dataReader.Read())
            {
                listItems[number] = new DownloadList();
                listItems[number].ProgramName = dataReader["Name"].ToString();
                //listItems[number].Icone = dataReader["Image"].ToString();
                
                Properties.Settings.Default.SettingUrl = dataReader["Url"].ToString();
                Properties.Settings.Default.Save();
                listItems[number].Url = Properties.Settings.Default.SettingUrl.ToString();


                if (Downloads_flowLayoutPanel.Controls.Count < 0)
                {
                    Downloads_flowLayoutPanel.Controls.Clear();
                }
                else
                    Downloads_flowLayoutPanel.Controls.Add(listItems[number]);
                

                number++;


            }
            number = 0;
            dataReader.Close();
            readData.close();

        }


        private void but_Programs_Click(object sender, EventArgs e)
        {
            Programs_flowLayoutPanel.BringToFront();
        }

        private void but_My_Library_Click(object sender, EventArgs e)
        {
            My_Library_flowLayoutPanel.BringToFront();
        }

       

        private void but_Downloads_Click(object sender, EventArgs e)
        {


            Downloads_flowLayoutPanel.Refresh();
            Downloads_flowLayoutPanel.BringToFront();
            




        }
    }
}
