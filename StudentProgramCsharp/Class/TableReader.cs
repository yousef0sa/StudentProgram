using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentProgramCsharp.Class
{
    internal class TableReader
    {
        private DBConnection con = new DBConnection();
        private SqlDataReader reader { get; set; }
        private SqlConnection connection;


        
        ///<summary>
        ///<para>Read ProgramsData Table and return ExecuteReader Where Status = null or Value For Show items</para>
        ///<para>SQl command like: { SELECT * FROM ProgramsData where Status != WhereEqual }</para> 
        ///</summary>
        public SqlDataReader ReadByStatus(String StatusValue = "")
        {
            connection = con.defaultPath();

            using (SqlCommand command = new SqlCommand("Select_All_Where", connection))
            {
                connection.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@WhereEqual", StatusValue);
                reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                return reader;
            }
          
        }


        ///<summary>
        ///<para>Read ProgramsData Table and return ExecuteReader Where Name = Value </para>
        ///<para>SQl command like: { SELECT * FROM ProgramsData where Name = NameValue }</para> 
        ///</summary>
        public SqlDataReader ReadByName(String NameValue = "")
        {
            connection = con.defaultPath();

            using (SqlCommand command = new SqlCommand("ProgramsData_Select_All_BY_Name", connection))
            {
                connection.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@NameValue", NameValue);
                reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                return reader;
            }

        }


        ///<summary>
        ///<para>Read ProgramsData Table and return ExecuteReader Where Type = Value </para>
        ///<para>SQl command like: { SELECT * FROM ProgramsData where Type = TypeValue }</para> 
        ///</summary>
        public SqlDataReader ReadByType(String TypeValue = "")
        {
            connection = con.defaultPath();

            using (SqlCommand command = new SqlCommand("ProgramsData_Select_All_By_Type", connection))
            {
                connection.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@TypeValue", TypeValue);
                reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                return reader;
            }
        }

        ///<summary>
        ///<para>Read ProgramsData Table and return ExecuteReader Where Name like % Value % </para>
        ///<para>SQl command like: { SELECT * FROM ProgramsData where Name like % NameValue % }</para> 
        ///</summary>
        public SqlDataReader ReadBySearchName(String NameValue = "")
        {
            connection = con.defaultPath();

            using (SqlCommand command = new SqlCommand("ProgramsData_Search_By_Name", connection))
            {
                connection.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@NameValue", NameValue);
                reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                return reader;
            }
        }
    }
}
