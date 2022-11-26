using StudentProgramCsharp.Class;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace StudentProgramCsharp
{
    public partial class ProgramPage : UserControl
    {
        private DBOperations update = new DBOperations();
        private TableReader tableReader = new TableReader();
        private Checking check = new Checking();
        private AddItems addItems = new AddItems();

        public ProgramPage()
        {
            InitializeComponent();



        }

        private void ProgramPage_Load(object sender, EventArgs e)
        {   //Start with checking 
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
            int x = (Width / 2) - (lblTitle.Width / 2);
            lblTitle.Left = x;

        }

        //Fun for checking is the program have Url and checks if New  
        private void checking()
        {
            if (check.CheckColumnValue("Url", "", Title))
            {
                button1.Enabled = false;
            }
            else
            {
                if (check.CheckColumnValue("Status", "New", Title))
                    button1.Enabled = true;
                else button1.Enabled = false;
            }
        }

        //Button to Download
        private void button1_Click(object sender, EventArgs e)
        {
            //change Status in ProgramsData Table to Listed 
            update.UpdataStatus("Listed", Title);

            //Return ExecuteReader When Name == Title
            var reader = tableReader.ReadByName(Title);

            //Add to Download page
            addItems.DownloadList(reader);

            button1.Enabled = false;
        }

        //Browse the program's website
        private void lblTitle_Click(object sender, EventArgs e)
        {
            if (Browse != "")
            {
                Process.Start(Browse);
            }
        }

    }
}
