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
        private static string connString;

        public static string ConnString
        {
            get
            {
                return connString;
            }

            set
            {
                connString = value;
            }
        }

        private static void OpenSQLConnection()
        {
         
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();

                Console.WriteLine("State: {0}", connection.State);
                Console.WriteLine("ConnectionString: {0}",
                    connection.ConnectionString);
            }

        }

      
    }
}
