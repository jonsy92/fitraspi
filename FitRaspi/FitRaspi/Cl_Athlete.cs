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
        private string birthday;
        private string sex;
        private double weight;
        private double height;
        private string email;
        private double ffm;
        private double ffmi;
        private double kfa;

        public Cl_Athlete (string n, string f, string b, string e, string m, double w, double h, double ffm, double ffmi, double kfa)
        {
            this.name = n;
            this.firstname = f;
            this.birthday = b;
            this.email = e;
            this.sex = m;
            this.weight = w;
            this.height = h;
            this.ffm = ffm;
            this.ffmi = ffmi;
            this.kfa = kfa;
        }

        public double calc_kfa(double stomach, double neck, double height, double waist, double butt)
        {
            double result;

            if (sex == "male")
            {
               result = 495 / (1.0324 - 0.19077 * Math.Log10(stomach - neck) + 0.15456 * Math.Log10(height)) - 450;
            }

            else
            {
                result = 495 / (1.29579 - 0.35004 * Math.Log10(stomach + waist - neck) + 0.22100 * Math.Log10(height)) - 450;
            }

            return (result);
        }
    }
}
