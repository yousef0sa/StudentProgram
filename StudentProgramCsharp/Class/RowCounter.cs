using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProgramCsharp.Class
{
    internal class RowCounter
    {
        private int Row { get; set; }
        private SqlConnection connection;
        private DBConnection con = new DBConnection();


        //
        public int cuntPrograms()
        {
            using (connection = con.defaultPath())
            {
                using (SqlCommand command = new SqlCommand("ProgramsData_Cunt_All", connection))
                {
                    connection.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    Row = (int)command.ExecuteScalar();
                }
            }
            return Row;
        }


        public int cuntStatusNot(String StatusValue)
        {
            using (connection = con.defaultPath())
            {
                using (SqlCommand command = new SqlCommand("ProgramsData_Cunt_Status_Not", connection))
                {
                    connection.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@StatusValue", StatusValue);
                    Row = (int)command.ExecuteScalar();
                }
            }
            return Row;

        }

        //cunt Row Where Type == TypeValue
        public int cuntType(String TypeValue)
        {
            using (connection = con.defaultPath())
            {
                using (SqlCommand command = new SqlCommand("ProgramsData_Cunt_All_By_Type", connection))
                {
                    connection.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@TypeValue", TypeValue);
                    Row = (int)command.ExecuteScalar();
                }
            }
            return Row;
        }

        //cunt Row Where Name like NameValue
        public int cuntSearchBar(String NameValue)
        {
            using (connection = con.defaultPath())
            {
                using (SqlCommand command = new SqlCommand("ProgramsData_Cunt_All_By_Name", connection))
                {
                    connection.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@NameValue", NameValue);
                    Row = (int)command.ExecuteScalar();
                }
            }
            return Row;
        }
    }
}
