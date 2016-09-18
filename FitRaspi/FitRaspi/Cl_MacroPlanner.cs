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
        int kcal;
        int protein;
        int fat;
        int carbohydrates;
        //-------------------------------------------------------------------------------------------------------------------------




        // Constructors------------------------------------------------------------------------------------------------------------
        public Cl_MacroPlanner(int kcal, int protein, int fat, int carbohydrates)
        {
            this.kcal = kcal;
            this.protein = protein;
            this.fat = fat;
            this.carbohydrates = carbohydrates;
        }

        public Cl_MacroPlanner()
        {
        }
        //-------------------------------------------------------------------------------------------------------------------------






        //Setter und Getter--------------------------------------------------------------------------------------------------------
        public int Kcal
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

        public int Protein
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

        public int Fat
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

        public int Carbohxdrates
        {
            get
            {
                return carbohydrates;
            }

            set
            {
                carbohydrates = value;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------





        // Static Methods and Functions----------------------------------------------------------------------------------------------
        public static Cl_MacroPlanner calc_macro(int kcal, Cl_Athlete athlete)
        {
            double weight = athlete.Weight;

            int protein = Convert.ToInt32(weight * 2);

            int fat = Convert.ToInt32(weight * 0.8);

            int carbohydrates = Convert.ToInt32((kcal - (protein * 4) - (fat * 9)) / 4);

            Cl_MacroPlanner macros = new Cl_MacroPlanner(kcal, protein, fat, carbohydrates);

            return macros;
        }

        public static int calc_kcal(int protein, int fat, int carbohydates)
        {
            int result;

            result = protein * 4 + fat * 9 + carbohydates * 4;

            return result;
        }
    }
}

