using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitRaspi
{
    class Cl_StrengthStats
    {
        //Property Definition -----------------------------------------------------------------------------------------------------
        private double squats;
        private double bench_press;
        private double dead_lift; 
        private double barbell_rowing;
        private double pull_ups;
        private double military_press;
        private double one_repeat_max; // Welchen Wert möchtest du hier an der Klasse oder für die Datenbank speichern? Bench Press Wert;)
        private double repeats_per_weight;
        private double weight_per_repeats;

        //-------------------------------------------------------------------------------------------------------------------------


        // Constructors------------------------------------------------------------------------------------------------------------
        public Cl_StrengthStats(double squats, double bench_press, double barbell_rowing, double cross_lift, double military_press, double pull_ups)
        {
            this.squats = squats;
            this.bench_press = bench_press;
            this.barbell_rowing = barbell_rowing;
            this.dead_lift = cross_lift;
            this.military_press = military_press;
            this.pull_ups = pull_ups;
        }

        public Cl_StrengthStats()
        {
        }
        //-------------------------------------------------------------------------------------------------------------------------




        //Setter und Getter--------------------------------------------------------------------------------------------------------
        public double Squats
        {
            get
            {
                return squats;
            }

            set
            {
                squats = value;
            }
        }

        public double Bench_press
        {
            get
            {
                return bench_press;
            }

            set
            {
                bench_press = value;
            }
        }

        public double Cross_lift
        {
            get
            {
                return dead_lift;
            }

            set
            {
                dead_lift = value;
            }
        }

        public double Barbell_rowing
        {
            get
            {
                return barbell_rowing;
            }

            set
            {
                barbell_rowing = value;
            }
        }

        public double Pull_ups
        {
            get
            {
                return pull_ups;
            }

            set
            {
                pull_ups = value;
            }
        }

        public double Military_press
        {
            get
            {
                return military_press;
            }

            set
            {
                military_press = value;
            }
        }

        public double One_repeat_max
        {
            get
            {
                return one_repeat_max;
            }

            set
            {
                one_repeat_max = value;
            }
        }

        public double Repeats_per_weight
        {
            get
            {
                return repeats_per_weight;
            }

            set
            {
                repeats_per_weight = value;
            }
        }

        public double Weight_per_repeats
        {
            get
            {
                return weight_per_repeats;
            }

            set
            {
                weight_per_repeats = value;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------












        //Static Methods and Functions---------------------------------------------------------------------------------------------
        public static double calc_one_repeat_max(double weight, double repeats)
        {
            double result;

            result = weight / (1.0278 - 0.0278 * repeats);

            return (Math.Round(result, 2));
        }

        public static double  calc_repeats_per_weight(double weight, double one_repeat_max)
        {
            double result;

            result = 36.97 - weight / one_repeat_max;

            Convert.ToInt32(result);

            return result;
        }

        public static double calc_weight_per_repeats(double one_repeat_max, double repeats)
        {
            double result;

            result = one_repeat_max * (1.0278 - 0.0278 * repeats);

            return (Math.Round(result, 2));
        }
        //-------------------------------------------------------------------------------------------------------------------------






        //Class Methods and Functions---------------------------------------------------------------------------------------------
        public void set_one_repeat_max(double weight, double repeats)
        {
            this.one_repeat_max = weight / (1.0278 - 0.0278 * repeats);
        }

        public void set_repeats_per_weight(double weight, double one_repeat_max)
        {
            this.repeats_per_weight = 36.97 - weight / one_repeat_max;
        }

        public void set_weight_per_repeats(double one_repeat_max, double repeats)
        {
            this.weight_per_repeats = one_repeat_max * (1.0278 - 0.0278 * repeats);
        }
        //-------------------------------------------------------------------------------------------------------------------------

    }
}
