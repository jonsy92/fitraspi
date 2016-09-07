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
        private string nickname;
        private string birthday;
        private string sex;
        private double weight;
        private double high;
        private float ffmi;
        private double kfa;

        // Bitte Konstruktor bauen ;) hier steh ich irgendwie aufem Schlauch... 
        public Cl_Athlete()
        {
                

        }

        public double calc_kfa()
        {
            for (sex = male)
                86.010 * Math.Log(Bauch - Nacken) - 70.041 * Math.Log(high) + 30.30;

            for (sex = female)
                163.205 * Math.Log(Taille + Po – Nacken) – 97.684 * Math.Log(high) – 104.912;

            return (0); // Es is zu spät, un ich komm mir so dumm vor, weil  ich das nit geappelt grin :C
        }

    }
}
