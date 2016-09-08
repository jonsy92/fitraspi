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
        private Boolean male;
        private double weight;
        private double height;
        private string email;
        private double ffm;
        private double ffmi;
        private double kfa;

        public Cl_Athlete (string n, string f, string b, string e, Boolean m, double w, double h, double ffm, double ffmi, double kfa)
        {
            this.name = n;
            this.firstname = f;
            this.birthday = b;
            this.email = e;
            this.male = m;
            this.weight = w;
            this.height = h;
            this.ffm = ffm;
            this.ffmi = ffmi;
            this.kfa = kfa;
        }

        public double calc_kfa(double stomach, double neck, double height, double waist, double butt)
        {
            double result = 0;
            double buffer;

            if (male)
            {
                buffer = 0.19077 * Math.Log10(stomach - neck);
                buffer = 1.0324 - buffer;
                buffer = buffer + 0.15456 * Math.Log10(height);
                buffer = 495 / buffer;
                result = buffer - 450;
            }

            else
            {
                buffer = 0.35004 * Math.Log10(stomach + waist - neck);
                buffer = 1.29579 - buffer;
                buffer = buffer + 0.22100 * Math.Log10(height);
                buffer = 495 / buffer;
                result = buffer - 450;
            }

            return (result);
        }
    }
}
