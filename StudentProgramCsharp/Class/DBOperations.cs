using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudentProgramCsharp.Class
{
    internal class DBOperations
    {

        private DBConnection con = new DBConnection();
        private SqlConnection connection ;

        ///<summary>
        ///<para>Update ProgramsData table for Status column value</para>  
        ///<para>SQl command like: { UPDATE ProgramsData SET Status = 'StatusValue' WHERE Name = WhereEqual }</para> 
        ///<para>The Status column values are: </para> 
        ///<br>1-{ **New**: program in Programs page }</br>
        ///<br>2-{ **Listed**: program in the Download page }</br>
        ///<br>3-{ **Complete**: program is downloaded }</br>
        ///</summary>
        public void UpdataStatus(String StatusValue, String WhereEqual) 
        {
            using (connection = con.defaultPath())
            {
                using (SqlCommand command = new SqlCommand("UpdatStatus", connection))
                {
                    connection.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@StatusValue", StatusValue);
                    command.Parameters.AddWithValue("@WhereEqual", WhereEqual);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
