using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Windows.Forms;

namespace StudentProgramCsharp.Database
{
    internal class CDB
    {
        SqlConnection con = new SqlConnection();

        public CDB() 
        { 
        
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\yosef\Documents\Visual Studio 2022\StudentProgramCsharp\StudentProgramCsharp\Database\Database1.mdf"";Integrated Security=True");
        }


        //open database
        public void open()
        {

            while (true)
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    break;

                }
                else
                    MessageBox.Show("The connection was open");
                    con.Close();
                
            }  
            
        }
        //close database
        public void close()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();

            }
        }

        //fun to read data
        public DataTable read (String store, SqlParameter[] pr)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = store;

            if (pr != null)
            { 
                cmd.Parameters.AddRange(pr);
             
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }



        //Excute to insert ,Delete ,Edit.
        public void Excute(string store, SqlParameter[] pr)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = store;

            if (pr != null)
            {
                cmd.Parameters.AddRange(pr);

            }
            cmd.ExecuteNonQuery();
        }

        //Count the number of rows in the table
        public int count_Row (String nameOfTable ,String where = null)
        {
            SqlCommand cmd;
            String sql = "";
            sql = "Select COUNT(*) From "+ nameOfTable + where;
            cmd = new SqlCommand(sql, con);
            open();

            var number_Of_Row = cmd.ExecuteScalar();
            int x = Int32.Parse(number_Of_Row.ToString());

            close();
            return x; 
        }
        public SqlConnection _con()
        {

            return con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\yosef\Documents\Visual Studio 2022\StudentProgramCsharp\StudentProgramCsharp\Database\Database1.mdf"";Integrated Security=True"); ;
        }
            
    }
}
