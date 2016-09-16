using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FitRaspi
{
    class Cl_User
    {

         string userid;
         string password;
         string username;



        public Cl_User(string username)
        {
            this.username = username;
        }

        public Cl_User(string username,string password)
        {
            this.username = username;
            this.password = password;
        }

        public string get_uid(string username)
        {
            MySqlConnection connection = Cl_MySQL.getMySQLConnection();
            Cl_MySQL.OpenMySQLConnection(connection);

            MySqlParameter param = new MySqlParameter();
            param.ParameterName = "@username";
            param.Value = username;

            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT UID FROM user WHERE Name = @username  ";
            command.Parameters.Add(param);

            MySqlDataReader reader;
            reader = command.ExecuteReader();

            while(reader.Read())
            {
                this.userid = reader.GetValue(0).ToString();
            }

            Cl_MySQL.CloseMySQLConnection(connection);

            
            return (this.userid);
        }


        public string get_password(string userid)
        {
            MySqlConnection connection = Cl_MySQL.getMySQLConnection();
            Cl_MySQL.OpenMySQLConnection(connection);

            MySqlParameter param = new MySqlParameter();
            param.ParameterName = "@userid";
            param.Value = userid;

            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT Passwordtext FROM password WHERE UID = @userid  ";
            command.Parameters.Add(param);

            MySqlDataReader reader;
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                this.password = reader.GetValue(0).ToString();
            }

            Cl_MySQL.CloseMySQLConnection(connection);


            return (this.password);
            
        }


        public bool check_password(string password)
        {
            //Check...
            //if(password correct)
            //{
               return (true);
            //}
            //else
            //{
            //    return (false);
            //}
        }

        public string Uid
        {
            get
            {
                return userid;
            }

            set
            {
                userid = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }
    }
}
