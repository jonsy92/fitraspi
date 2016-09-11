using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; // --> Download mysqlConnector for this dll

namespace FitRaspi
{
    class Cl_MySQL
    {
       public static void OpenMySQLConnection(MySqlConnection connection)
        {
                connection.Open();
        }


        public static MySqlConnection getMySQLConnection()
        {
            string myConnectionString = "SERVER=localhost;DATABASE=fit-raspi;UID=root;" + "PASSWORD=;";
            using (MySqlConnection connection = new MySqlConnection(myConnectionString))
            {
                return (connection);
            }
        }


       public static MySqlConnection getMySQLConnection(string server, string userid, string password, string database)
        {
            MySqlConnectionStringBuilder conn_string = new MySqlConnectionStringBuilder();
            conn_string.Server = server;
            conn_string.UserID = userid;
            conn_string.Password = password;
            conn_string.Database = database;


            using (MySqlConnection connection = new MySqlConnection(conn_string.ToString()))
            {
                return (connection);
            }

    }
    }      
}
