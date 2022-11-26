using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProgramCsharp.Class
{

    internal class DBConnection
    {
        private SqlConnection _connectionString;


        //Return SqlConnection Default Path 
        public SqlConnection defaultPath()
        {
            _connectionString = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Database\Database2.mdf ;Integrated Security=True");

            return _connectionString;           
        }

        //Return SqlConnection by Select name of Database
        public SqlConnection con (String DBPath = @"Database\Database2.mdf")
        {
            _connectionString = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|" + DBPath + " ;Integrated Security=True");

            return _connectionString;
        }

        //Return SqlConnection by Select Full Connection Path
        public SqlConnection selectConPath(String StringPath)
        {
            _connectionString = new SqlConnection(StringPath);

            return _connectionString;
        }

    }
}
