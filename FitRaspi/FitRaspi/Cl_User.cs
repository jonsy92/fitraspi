using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitRaspi
{
    class Cl_User
    {

        private string userid;
        private string password;
        private string username;


        public Cl_User(string username,string password)
        {
            this.username = username;
            this.password = password;
        }

        public string get_uid(string username)
        {
            return ("Select UID...");
        }


        public string get_password(string userid)
        {
            return ("Select password...");
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
