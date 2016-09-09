using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FitRaspi
{
    class Cl_MySQL
    {
       public static void OpenSQLConnection()
        {
            string myConnectionString = "server=localhost;uid=root;" + "pwd=;database=fit-rasbi;";
            using (SqlConnection connection = new SqlConnection(myConnectionString))
            {
                connection.Open();
            }
        } 

       public static void OpenSQLConnection(string server, string userid, string password, string database)
        {
            SqlConnectionStringBuilder conn_string = new SqlConnectionStringBuilder();
            conn_string.DataSource = server;
            conn_string.UserID = userid;
            conn_string.Password = password;
            conn_string.InitialCatalog = database;


            using (SqlConnection connection = new SqlConnection(conn_string.ToString()))
            {
                    connection.Open();
                    Console.WriteLine("State: {0}", connection.State);
                    Console.WriteLine("ConnectionString: {0}",
                        connection.ConnectionString);
             
            }

    }
    }      
}
