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

        //-------------------------------------------------------------------------------------------------------------------------





        // Static Methods and Functions----------------------------------------------------------------------------------------------
        public static double calc_job_calories (string job_factor)
        {
            switch (job_factor)
            {
                case "easy":
                    job_factor ="1.4";
                    break;
                case "normal":
                    job_factor = "1.6";
                    break;
                case "heavy":
                    job_factor = "1.8";
                    break;
                case "heavier":
                    job_factor = "2.0";
                    break;
            }

            return (Convert.ToDouble(job_factor));
        }

        public static double calc_sport_calories(Cl_Athlete athlete, TimeSpan time, string sport_value)
        {
            switch(sport_value)
            {
                case "soccer":
                    sport_value = "1.27";
                    break;
                case "running":
                    sport_value = "0.15";
                    break;
                case "biking":
                    sport_value = "0.07";
                    break;
                case "swimming":
                    sport_value = "1.46";
                    break;
                case "walking":
                    sport_value = "0.6";
                    break;
            }

            double result;
            double weight = athlete.Weight;
            double min = time.Minutes;
            double days = time.Days;

            result = (Convert.ToDouble(sport_value) * weight * min * days) / 7;

            return result;
        }

        public static double set_goal_calories(string goals)
        {
            switch (goals)
            {
                case "gain 0.5kg/week":
                    goals = "250";
                    break;
                case "gain 1kg/week":
                    goals = "500";
                    break;
                case "gain 1.5kg/week":
                    goals = "750";
                    break;
                case "gain 2kg/week":
                    goals = "1000";
                    break;
                case "lose 0.5kg/week":
                    goals = "- 250";
                    break;
                case "lose 1kg/week":
                    goals = "- 500";
                    break;
                case "lose 1.5kg/week":
                    goals = "- 750";
                    break;
                case "lose 2kg/week":
                    goals = "- 1000";
                    break;
                case "keep weight":
                    goals = "0";
                    break;
            }

            return (Convert.ToDouble(goals));
        }
    }   
}
