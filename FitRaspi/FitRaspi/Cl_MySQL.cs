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
        
        
//        private static void OpenSQLConnection(string server,string userid, string password, string database )
//        {
         
            MySqlConnectionStringBuilder conn_string = new MySqlConnectionStringBuilder();
                conn_string.Server = server;
                conn_string.UserID = userid;
                conn_string.Password = password;
                conn_string.Database = database;
         
         
//            //using (SqlConnection connection = new SqlConnection(conn_string.ToString()))
//            //{
//            //    connection.Open();

//            //    Console.WriteLine("State: {0}", connection.State);
//            //    Console.WriteLine("ConnectionString: {0}",
//            //        connection.ConnectionString);
//            }

//        }

      
//    }
//}
