using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProgramCsharp.Class
{
    internal class Checking
    {
        private TableReader tableReader = new TableReader();
        private SqlDataReader reader;

        ///<summary>
        ///<para>Return true if( @ColumnName.Value ==  @ColumValue Where Name = @NameValue)  </para>
        ///</summary>
        public bool CheckColumnValue(String ColumnName, String ColumValue, String NameValue)
        {
            using (reader = tableReader.ReadByName(NameValue))
            { 
                reader.Read();
                if (reader[ColumnName].ToString() == ColumValue)
                    return true;
                else
                    return false;
            }            
        }

        ///<summary>
        ///<para>Return true if Status =  Complete Where name = @NameValue  </para>
        ///</summary>
        public bool DownloadCompleted(String NameValue)
        {
            return CheckColumnValue("Status", "Complete", NameValue);
        }
    }

}
