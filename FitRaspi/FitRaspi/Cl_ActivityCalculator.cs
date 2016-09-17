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
        public static double calc_job_calories (Cl_Athlete athlete, string job_factor)
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

            double result;
            double weight = athlete.Weight;
            double height = athlete.Height;
            int age = athlete.Age;

            if(ReferenceEquals(athlete.Sex, "male"))
            {
                result = ((66.47 + (13.7 * weight + 5 * height - 6.8 * age)) * Convert.ToDouble(job_factor) - (66.47 + (13.7 * weight + 5 * height - 6.8 * age)));
            }
            else
            {
                result = ((655.1 + (9.6 * weight + 1.8 * height - 4.7 * age)) * Convert.ToDouble(job_factor) - (655.1 + (9.6 * weight + 1.8 * height - 4.7 * age)));
            }

            return result;
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

            result = Convert.ToDouble(sport_value) * weight * min;

            return result;
        }

        public static double set_goal_calories(string goals)
        {
            switch (goals)
            {
                case "gain weight slowly":
                    goals = "250";
                    break;
                case "gain weight normaly":
                    goals = "500";
                    break;
                case "gain weight fast":
                    goals = "750";
                    break;
                case "gain weight faster":
                    goals = "1000";
                    break;
                case "lose weight slowly":
                    goals = "- 250";
                    break;
                case "lose weight normaly":
                    goals = "- 500";
                    break;
                case "lose weight fast":
                    goals = "- 750";
                    break;
                case "lose weight faster":
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
