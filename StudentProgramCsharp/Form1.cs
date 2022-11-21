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
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

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
            //loade item in program page
            popuProgramItems();

            //loade item in Download page
            popuDownloadItems();

            //return computer name
            label1.Text = Environment.MachineName;
        }


        //Fun for adding items to Program page
        private void popuProgramItems()
        {

            string sql = "Select * From ProgramsData";


            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Database\Database2.mdf ;Integrated Security=True"))
            {
                int number = 0;
                CDB readData = new CDB();

                int x = readData.count_Row("ProgramsData"); //Count the number of rows in the table

                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                ProgramPage[] listItems = new ProgramPage[x];

                // Call Read before accessing data.
                while (reader.Read())
                {
                    listItems[number] = new ProgramPage();
                    listItems[number].Title = reader["Name"].ToString();
                    listItems[number].Install = reader["Url"].ToString();
                    listItems[number].Browse = reader["Browse"].ToString();



                    if (Programs_flowLayoutPanel.Controls.Count < 0)
                    {
                        Programs_flowLayoutPanel.Controls.Clear();
                    }
                    else
                        Programs_flowLayoutPanel.Controls.Add(listItems[number]);

                    number++;

                }

                // Call Close when done reading.
                reader.Close();

                //get number of programs
                lab_numOFprograms.Text = "Programs: " + x.ToString() + " |";
            }
            
        }
    
            
        //Fun for showing items on programs page by select type from database
        private void showItemType(String Type)
        {
            Programs_flowLayoutPanel.Controls.Clear();

            CDB readData = new CDB();
            int x = readData.count_Row("ProgramsData", " Where CONVERT(VARCHAR,Type)  like  '%" + Type + "%'"); //Count the number of rows in the table

            SqlCommand cmd;
            SqlDataReader dataReader;
            String sql = "";
            int number = 0;

            sql = "Select * From ProgramsData Where CONVERT(VARCHAR,Type)  like '%" + Type + "%'";
            cmd = new SqlCommand(sql, readData._con());
            readData.open();

            dataReader = cmd.ExecuteReader();
            ProgramPage[] listItems = new ProgramPage[x];
            
            while (dataReader.Read())
            {
                listItems[number] = new ProgramPage();
                listItems[number].Title = dataReader["Name"].ToString();
                listItems[number].Install = dataReader["Url"].ToString();
                listItems[number].Browse = dataReader["Browse"].ToString();




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

        //Fun for adding items to Download page
        private void popuDownloadItems()
        {
            string sql = "Select * From ProgramsData where CONVERT(VARCHAR,Status) not in ('New')";

            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Database\Database2.mdf ;Integrated Security=True"))
            {
                int number = 0;
                CDB readData = new CDB();
                int x = readData.count_Row("ProgramsData", " where CONVERT(VARCHAR,Status) not in ('New')"); //Count the number of rows in the table

                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                DownloadList[] listItems = new DownloadList[x];

                // Call Read before accessing data.
                while (reader.Read())
                {
                    //this fix while bug!
                    if (x == number)
                        break;

                    listItems[number] = new DownloadList();
                    listItems[number].Name = reader["Name"].ToString();

                    listItems[number].ProgramName = reader["Name"].ToString();
                    listItems[number].Url = reader["Url"].ToString();
                    //listItems[number].Icone = reader["Image"].ToString();
                    





                    if (Downloads_flowLayoutPanel.Controls.Count < 0)
                    {
                        Downloads_flowLayoutPanel.Controls.Clear();
                    }
                    else
                        Downloads_flowLayoutPanel.Controls.Add(listItems[number]);


                    number++;

                }

                // Call Close when done reading.
                reader.Close();
            }
        }



        

        //Get Program page
        private void but_Programs_Click(object sender, EventArgs e)
        {
            if (tb_Search.Text != "")
                Programs.BringToFront();

            else if (tb_Search.Text == "")
            {
                Programs_flowLayoutPanel.Controls.Clear();
                popuProgramItems();
                Programs.BringToFront();

            }
        }

        //Get Library page
        private void but_My_Library_Click(object sender, EventArgs e)
        {
            //My_Library_flowLayoutPanel.BringToFront();
        }


        //Get Download page
        private void but_Downloads_Click(object sender, EventArgs e)
        {
            Downloads_flowLayoutPanel.BringToFront();
        }



        //Show Settings Menu
        private void button1_Click(object sender, EventArgs e)
        {
            settingsMenuForm.Show(this, new Point(but_Settings.Location.X +60, but_Settings.Location.Y +45));
        }


        //Search bar if Text Changed
        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            if (tb_Search.Text != "")
            {
                Programs_flowLayoutPanel.Controls.Clear();

                CDB readData = new CDB();
                int x = readData.count_Row("ProgramsData", " Where CONVERT(VARCHAR,Name)  like  '%" + tb_Search.Text + "%'"); //Count the number of rows in the table

                SqlCommand cmd;
                SqlDataReader dataReader;
                String sql = "";
                int number = 0;

                sql = "Select * From ProgramsData Where CONVERT(VARCHAR,Name)  like '%" + tb_Search.Text + "%'";
                cmd = new SqlCommand(sql, readData._con());
                readData.open();

                dataReader = cmd.ExecuteReader();
                ProgramPage[] listItems = new ProgramPage[x];

                while (dataReader.Read())
                {
                    listItems[number] = new ProgramPage();
                    listItems[number].Title = dataReader["Name"].ToString();
                    listItems[number].Install = dataReader["Url"].ToString();
                    listItems[number].Browse = dataReader["Browse"].ToString();



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
            else if (tb_Search.Text == "")
            {
                Programs_flowLayoutPanel.Controls.Clear();
                popuProgramItems();
            }

        }



        //
        // get Info to main form
        //
        private void Programs_flowLayoutPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            //get number of programs When add to page
            lab_numOFprograms.Text = "Programs: " + Programs_flowLayoutPanel.Controls.Count + " |";
        }

        private void Programs_flowLayoutPanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            //get number of programs When remove from page
            lab_numOFprograms.Text = "Programs: " + Programs_flowLayoutPanel.Controls.Count + " |";
        }

        private void Downloads_flowLayoutPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            //get number of Downloads When add to page
            lab_NumberOfDownloads.Text = "Downloads: " + Downloads_flowLayoutPanel.Controls.Count + " |";
        }

        private void Downloads_flowLayoutPanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            //get number of Downloads When remove from page
            lab_NumberOfDownloads.Text = "Downloads: " + Downloads_flowLayoutPanel.Controls.Count + " |";
        }



        //
        //address bar
        //

        //Maximized
        private void button2_Click(object sender, EventArgs e)
        {
            

            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
               
            else if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;

            }
                
        }
        //exit
        private void button1_Click_1(object sender, EventArgs e)
        {
        
            this.Close();
            Application.Exit();
            Application.ExitThread();
            Environment.Exit(0);
            //Environment.Exit(Environment.ExitCode);


        }
        //Minimized
        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //move form window
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }



        //
        //programs filter bar [Display type of programs]
        //

        //show [All]
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Programs_flowLayoutPanel.Controls.Clear();
            popuProgramItems();
        }
        //show [Coding]
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            showItemType("Coding");
        }
        //show [Engineering]
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            showItemType("Engineering");
        }
    }
}
