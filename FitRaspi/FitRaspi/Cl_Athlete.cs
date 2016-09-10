using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitRaspi
{
    class Cl_Athlete
    {

       


        // Bitte Klassen Properties anlegen
        private string name;
        private string firstname;
        private DateTime birthday; // Hab den Datentyp in datetime geändert
        private string sex;
        private string email;
        private double weight;
        private double height;
        private double ffm;
        private double ffmi;
        private double kfa;

        public Cl_Athlete (string name, string firstname, string email, string sex, double weight, double height)
        {
            this.name = name;
            this.firstname = firstname;
            this.email = email;
            this.sex = sex;
            this.weight = weight;
            this.height = height;
        }

        public Cl_Athlete (string name, string firstname, string email, string sex, DateTime birthday, double weight, double height, double ffm, double ffmi, double kfa)
        {
            this.name = name;
            this.firstname = firstname;
            this.email = email;
            this.sex = sex;
            this.birthday = birthday;
            this.weight = weight;
            this.height = height;
            this.ffm = ffm;
            this.ffmi = ffmi;
            this.kfa = kfa;
        }

        public Cl_Athlete()
        { }

        public static double calc_kfa(double stomach, double neck, double height)
        {
            double result;

            result = 495 / (1.0324 - 0.19077 * Math.Log10(stomach - neck) + 0.15456 * Math.Log10(height)) - 450;
          
            return (result);
        }

        public void set_kfa(double stomach, double neck, double height)
        {
            this.kfa = 495 / (1.0324 - 0.19077 * Math.Log10(stomach - neck) + 0.15456 * Math.Log10(height)) - 450;
        }

        public  static double calc_kfa(double stomach, double neck, double height, double waist, double butt)
        {
            double result;

            result = 495 / (1.29579 - 0.35004 * Math.Log10(stomach + waist - neck) + 0.22100 * Math.Log10(height)) - 450;

            return (result);
        }

        public void set_kfa(double stomach, double neck, double height, double waist, double butt)
        {
            this.kfa = 495 / (1.29579 - 0.35004 * Math.Log10(stomach + waist - neck) + 0.22100 * Math.Log10(height)) - 450;
        }

        public static double calc_ffm(double weight, double kfa)
        {
            double result;

            result = weight * (100 - kfa) / 100;

            return (result);
        }

        public void set_ffm(double weight, double kfa)
        {
            this.ffm = weight * (100 - kfa) / 100;
        }

        public static double calc_ffmi(double height, double ffm)
        {
            double result;

            result = ffm / (height * height) + 6.3 * (1.8 - height);

            return (result);
        }

        public void set_ffmi(double height,double ffm)
        {
            this.ffmi = ffm / (height * height) + 6.3 * (1.8 - height);
        }

        public static int calc_age(DateTime birthday)
        {
            int age = DateTime.Now.Year - birthday.Year;
            birthday = birthday.AddYears(age);
            if (DateTime.Now.CompareTo(birthday) < 0)
            {
                age--;
            }
            return (age);
        }
    }
}
