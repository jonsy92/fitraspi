using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitRaspi
{
    class Cl_Daniels_Calculator
    {
        // Die Funktion die du implementierst, soll von überall aufgerufen werden,
        //ohne dass man sich Gedanken um eine instanz oder Properties machen muss

        // Static Methods and Functions----------------------------------------------------------------------------------------------
         public static int calculate(int zahl1, int zahl2, string rechenoperator)
        {
            int result;
            switch (rechenoperator)
            {
                case "+":
                    result = zahl1 + zahl2;
                    return result;
                case "-":
                    result = zahl1 - zahl2;
                    return result;
                case "*":
                    result = zahl1 * zahl2;
                    return result;
                case "/":
                    result = zahl1 / zahl2;
                    return result;
            }

            return 0;
        }

        public static int calculate(int zahl1, int zahl2, int zahl3, string rechenoperator)
        {
            int result;
            switch (rechenoperator)
            {
                case "+":
                    result = zahl1 + zahl2 + zahl3;
                    return result;
                case "-":
                    result = zahl1 - zahl2 - zahl3;
                    return result;
                case "*":
                    result = zahl1 * zahl2 + zahl3;
                    return result;
                case "/":
                    result = zahl1 / zahl2 / zahl3;
                    return result;
            }

            return 0;
        }
        //-------------------------------------------------------------------------------------------------------------------------
    }
}
