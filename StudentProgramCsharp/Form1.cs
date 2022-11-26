using StudentProgramCsharp.Class;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace StudentProgramCsharp
{
    public partial class Form1 : Form
    {
        static Form1 _obj;

        private TableReader tableReader = new TableReader();
        private RowCounter rowCunt = new RowCounter();
        private AddItems addItems = new AddItems();
        private SelectType selectType = new SelectType();
        private TitleBar titleBar = new TitleBar();
        private UserInterFaceInfo UIFN = new UserInterFaceInfo();

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
            //load item in program page
            popuProgramItems();

            //load item in Download page
            popuDownloadItems();

            //return user name
            UIFN.UserName(User_Name);
        }


        //Fun for adding items to Program page
        private void popuProgramItems()
        {
            //Return ExecuteReader 
            var reader = tableReader.ReadByStatus();

            //Return row count
            int cunter = rowCunt.cuntPrograms();

            //Add items to Programs page
            addItems.ProgramList(reader, cunter);

            //get number of programs
            lab_numOFprograms.Text = "Programs: " + cunter.ToString() + "|";
        }

        //Fun for adding items to Download page
        private void popuDownloadItems()
        {
            //Return ExecuteReader When Status != New
            var reader = tableReader.ReadByStatus("New");

            //Return row count When Status != New
            int x = rowCunt.cuntStatusNot("New");

            //Add items to Download page
            addItems.DownloadList(reader, x);

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
            settingsMenuForm.Show(this, new Point(but_Settings.Location.X + 60, but_Settings.Location.Y + 45));
        }

        //Search bar if Text Changed
        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            if (tb_Search.Text != "")
            {
                Programs_flowLayoutPanel.Controls.Clear();

                //Count the number of rows in the table
                var cunter = rowCunt.cuntSearchBar(tb_Search.Text);

                var raeder = tableReader.ReadBySearchName(tb_Search.Text);

                addItems.ProgramList(raeder, cunter);
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
            UIFN.ProgramsItemsCunter(Programs_flowLayoutPanel, lab_numOFprograms);
        }

        private void Programs_flowLayoutPanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            //get number of programs When remove from page
            UIFN.ProgramsItemsCunter(Programs_flowLayoutPanel, lab_numOFprograms);
        }

        private void Downloads_flowLayoutPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            //get number of Downloads When add to page
            UIFN.DownloadsItemsCunter(Downloads_flowLayoutPanel, lab_NumberOfDownloads);
        }

        private void Downloads_flowLayoutPanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            //get number of Downloads When remove from page
            UIFN.DownloadsItemsCunter(Downloads_flowLayoutPanel, lab_NumberOfDownloads);
        }

        //
        //address bar
        //

        //Maximized
        private void button2_Click(object sender, EventArgs e)
        {
            titleBar.Maximized(this);
        }

        //exit
        private void button1_Click_1(object sender, EventArgs e)
        {
            titleBar.Exit();
        }

        //Minimized
        private void button3_Click(object sender, EventArgs e)
        {
            titleBar.Minimized(this);
        }


        //move form window Tool
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg = WM_NCLBUTTONDOWN, int wParam = HT_CAPTION, int lParam = 0);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        //move form window
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
            selectType.ShowItemByType("Coding");
        }

        //show [Engineering]
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            selectType.ShowItemByType("Engineering");
        }
    }
}
