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
        private double job_factor;
        private double sport_kcal;
        private double goal_kcal;
        //-------------------------------------------------------------------------------------------------------------------------




        //Setter und Getter--------------------------------------------------------------------------------------------------------
        public double Goal_kcal
        {
            get
            {
                return goal_kcal;
            }

            set
            {
                goal_kcal = value;
            }
        }

        public double Job_factor
        {
            get
            {
                return job_factor;
            }

            set
            {
                job_factor = value;
            }
        }

        public double Sport_kcal
        {
            get
            {
                return sport_kcal;
            }

            set
            {
                sport_kcal = value;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------





        // Static Methods and Functions----------------------------------------------------------------------------------------------
        public static double get_job_factor(string job_activitylvl)
        {
            switch (job_activitylvl)
            {
                case "easy":
                    return (1.4);
                case "normal":
                    return (1.6);
                case "heavy":
                    return (1.8);
                case "heavier":
                    return (2);
            }

            return (1);
        }

        public static double get_sport_calories(Cl_Athlete athlete, int min, int days, string sport_activity)
        {
            double sport_factor = 0;
            switch(sport_activity)
            {
                case "soccer":
                    sport_factor = 1.27;
                    break;
                case "running":
                    sport_factor = 0.15;
                    break;
                case "biking":
                    sport_factor = 0.07;
                    break;
                case "swimming":
                    sport_factor = 1.46;
                    break;
                case "walking":
                    sport_factor = 0.6;
                    break;
            }

            double result;
            double weight = athlete.Weight;

            result = (sport_factor * weight * min * days) / 7;

            return result;
        }

        public static double calc_goal_calories(double weight_per_week)
        {
            double kcal = (weight_per_week * 7000) / 7;

            return kcal;
        }
    }   
}
