using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitRaspi
{
    class Cl_MacroPlanner
    {
        //Property Definition -----------------------------------------------------------------------------------------------------
        double kcal;
        double protein;
        double fat;
        double carbohxdrates;
        //-------------------------------------------------------------------------------------------------------------------------




        // Constructors------------------------------------------------------------------------------------------------------------
        public Cl_MacroPlanner(double kcal, double protein, double fat, double carbohydrates)
        {
            this.kcal = kcal;
            this.protein = protein;
            this.fat = fat;
            this.carbohxdrates = carbohydrates;
        }

        public Cl_MacroPlanner()
        {
        }
        //-------------------------------------------------------------------------------------------------------------------------






        //Setter und Getter--------------------------------------------------------------------------------------------------------
        public double Kcal
        {
            get
            {
                return kcal;
            }

            set
            {
                kcal = value;
            }
        }

        public double Protein
        {
            get
            {
                return protein;
            }

            set
            {
                protein = value;
            }
        }

        public double Fat
        {
            get
            {
                return fat;
            }

            set
            {
                fat = value;
            }
        }

        public double Carbohxdrates
        {
            get
            {
                return carbohxdrates;
            }

            set
            {
                carbohxdrates = value;
            }
        }

    }
}
