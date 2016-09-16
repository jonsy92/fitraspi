using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitRaspi
{
    class Cl_ActivityCalculator
    {
        //Property Definition -----------------------------------------------------------------------------------------------------
        private double job;
        private double sport;
        private double goal;
        //-------------------------------------------------------------------------------------------------------------------------




        //Setter und Getter--------------------------------------------------------------------------------------------------------
        public double Sport
        {
            get
            {
                return sport;
            }

            set
            {
                sport = value;
            }
        }

        public double Goal
        {
            get
            {
                return goal;
            }

            set
            {
                goal = value;
            }
        }

        public double Job
        {
            get
            {
                return job;
            }

            set
            {
                job = value;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------





        // Static Methods and Functions----------------------------------------------------------------------------------------------

        //was jetzt folgt is bestimmt falsch, bzw nicht so von dir erdacht worden


        public static double calc_job_male(Cl_Athlete athlete)
        {
            double result;

            double weight = athlete.Weight;

            double height = athlete.Height;

            int age = athlete.Age;

            result = (66.47 + (13.7 * weight + 5 * height - 6.8 * age)) * 1.4 - (66.47 + (13.7 * weight + 5 * height - 6.8 * age));

            return result;
        }

        public static double calc_job_normal_male(Cl_Athlete athlete)
        {
            double result;

            double weight = athlete.Weight;

            double height = athlete.Height;

            int age = athlete.Age;

            result = (66.47 + (13.7 * weight + 5 * height - 6.8 * age)) * 1.6 - (66.47 + (13.7 * weight + 5 * height - 6.8 * age));

            return result;
        }

        public static double calc_job_heavy_male(Cl_Athlete athlete)
        {
            double result;

            double weight = athlete.Weight;

            double height = athlete.Height;

            int age = athlete.Age;

            result = (66.47 + (13.7 * weight + 5 * height - 6.8 * age)) * 1.8 - (66.47 + (13.7 * weight + 5 * height - 6.8 * age));

            return result;
        }

        public static double calc_job_heavier_male(Cl_Athlete athlete)
        {
            double result;

            double weight = athlete.Weight;

            double height = athlete.Height;

            int age = athlete.Age;

            result = (66.47 + (13.7 * weight + 5 * height - 6.8 * age)) * 2 - (66.47 + (13.7 * weight + 5 * height - 6.8 * age));

            return result;
        }

        public static double calc_job_easy_female(Cl_Athlete athlete)
        {
            double result;

            double weight = athlete.Weight;

            double height = athlete.Height;

            int age = athlete.Age;

            result = (655.1 + (9.8 * weight + 1.8 * height - 4.7 * age)) * 1.4 - (655.1 + (9.8 * weight + 1.8 * height - 4.7 * age));

            return result;
        }

        public static double calc_job_normal_female(Cl_Athlete athlete)
        {
            double result;

            double weight = athlete.Weight;

            double height = athlete.Height;

            int age = athlete.Age;

            result = (655.1 + (9.8 * weight + 1.8 * height - 4.7 * age)) * 1.6 - (655.1 + (9.8 * weight + 1.8 * height - 4.7 * age));

            return result;
        }

        public static double calc_job_heavy_female(Cl_Athlete athlete)
        {
            double result;

            double weight = athlete.Weight;

            double height = athlete.Height;

            int age = athlete.Age;

            result = (655.1 + (9.8 * weight + 1.8 * height - 4.7 * age)) * 1.8 - (655.1 + (9.8 * weight + 1.8 * height - 4.7 * age));

            return result;
        }

        public static double calc_job_heavier_female(Cl_Athlete athlete)
        {
            double result;

            double weight = athlete.Weight;

            double height = athlete.Height;

            int age = athlete.Age;

            result = (655.1 + (9.8 * weight + 1.8 * height - 4.7 * age)) * 2 - (655.1 + (9.8 * weight + 1.8 * height - 4.7 * age));

            return result;
        }
    }   
}
