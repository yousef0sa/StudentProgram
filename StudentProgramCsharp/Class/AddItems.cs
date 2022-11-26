using StudentProgramCsharp.user_control;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentProgramCsharp.Class
{
    internal class AddItems
    {
        private ProgramPage[] ProgramItemList;
        private DownloadList[] DownloadItemList ;

        //Add item to program page 
        public void ProgramList(SqlDataReader Reader, int RowCunt = 1)
        {
            ProgramItemList = new ProgramPage[RowCunt];
            int number = 0;

            while (Reader.Read())
            {

                ProgramItemList[number] = new ProgramPage();
                ProgramItemList[number].Title = Reader["Name"].ToString();
                ProgramItemList[number].Install = Reader["Url"].ToString();
                ProgramItemList[number].Browse = Reader["Browse"].ToString();

                if (Form1.Instance.Programs_flowLayoutPanel.Controls.Count < 0)
                {
                    Form1.Instance.Programs_flowLayoutPanel.Controls.Clear();
                }
                else
                    Form1.Instance.Programs_flowLayoutPanel.Controls.Add(ProgramItemList[number]);
                number++;
            }
        }


        //Add item to Download page
        public void DownloadList(SqlDataReader Reader, int RowCunt = 1)
        {
            DownloadItemList = new DownloadList[RowCunt];
            int number = 0;
            while (Reader.Read())
            {
                DownloadItemList[number] = new DownloadList();
                DownloadItemList[number].Name = Reader["Name"].ToString();
                DownloadItemList[number].ProgramName = Reader["Name"].ToString();
                DownloadItemList[number].Url = Reader["Url"].ToString();
              

                if (Form1.Instance.Downloads_flowLayoutPanel.Controls.Count < 0)
                {
                    Form1.Instance.Downloads_flowLayoutPanel.Controls.Clear();
                }
                else
                    Form1.Instance.Downloads_flowLayoutPanel.Controls.Add(DownloadItemList[number]);

                number++;
            }
        }
    }
}
