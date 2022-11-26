using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProgramCsharp.Class
{
    internal class SelectType
    {
        private RowCounter rowCunt = new RowCounter();
        private TableReader tableReader = new TableReader();
        private AddItems addItems = new AddItems();

        //showing items on programs page Where Type = TypeValue
        public void ShowItemByType(String TypeValue)
        {
            Form1.Instance.Programs_flowLayoutPanel.Controls.Clear();

            //Count the number of rows in the table
            var cunter = rowCunt.cuntType(TypeValue);

            var raeader = tableReader.ReadByType(TypeValue);

            addItems.ProgramList(raeader, cunter);
        }
    }
}
