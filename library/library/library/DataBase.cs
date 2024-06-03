using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace library
{

    internal class DataBase
    {
        static SqlConnection cn = new SqlConnection("server = DESKTOP-PDSBB7V\\MSSQLSERVER1;database = master;integrated security=true");

        public static void connect()
        {

            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();

            }

        }
        public static void disconnect()
        {

            if (cn.State == ConnectionState.Open)
            {
                cn.Close();

            }

        }
        /*public SqlDataReader ExecuteQuery(string query)
        {
            SqlCommand command = new SqlCommand(query, cn);
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }
        */
        //this function takes query as a parameter and execute it(query that does not return data like insert, delete, alter)
        public static void execute(string query)
        {
            connect();

            SqlCommand command = new SqlCommand(query, cn);
            command.ExecuteNonQuery();
            disconnect();

        }

        //this function takes query as a parameter and execute it (query that return data )
        public static DataTable Get(string query)
        {
            //execute command on the database
            SqlCommand command = new SqlCommand(query, cn);
            //sqlDataAdapter convert command to dataTable
            SqlDataAdapter sa = new SqlDataAdapter(command);

            DataTable dt = new DataTable();
            //
            sa.Fill(dt);

            return dt;


        }
    }

}
