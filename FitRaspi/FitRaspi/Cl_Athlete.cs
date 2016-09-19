using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitRaspi
{
    class Cl_Athlete
    {
        // Property Definition--------------------------------------------------------------------------------------------------------
        private string nickname;
        private DateTime birthday; 
        private string sex;
        private string email;
        private double weight;
        private double height;
        private double ffm;
        private double ffmi;
        private double kfa;
        private int age;
        private int kcal;
        private double stomach;
        private double bizeps_left;
        private double bizeps_right;
        private double chest;
        private double quad_left;
        private double quad_right;
        private double butt;
        private double neck;
        private double shoulders;
        private double lat;
        private double waist;
        private double calf_left;
        private double calf_right;
        
        
        //-------------------------------------------------------------------------------------------------------------------------



        //Setter and Getter--------------------------------------------------------------------------------------------------------
      
        public DateTime Birthday
        {
            get
            {
                return birthday;
            }

            set
            {
                birthday = value;
            }
        }

        public string Sex
        {
            get
            {
                return sex;
            }

            set
            {
                sex = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public double Weight
        {
            get
            {
                return weight;
            }

            set
            {
                weight = value;
            }
        }

        public double Height
        {
            get
            {
                return height;
            }

            set
            {
                height = value;
            }
        }

        public double Ffm
        {
            get
            {
                return ffm;
            }

            set
            {
                ffm = value;
            }
        }

        public double Ffmi
        {
            get
            {
                return ffmi;
            }

            set
            {
                ffmi = value;
            }
        }

        public double Kfa
        {
            get
            {
                return kfa;
            }

            set
            {
                kfa = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public string Nickname
        {
            get
            {
                return nickname;
            }

            set
            {
                nickname = value;
            }
        }

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

        public double Stomach
        {
            get
            {
                return stomach;
            }

            set
            {
                stomach = value;
            }
        }

        public double Bizeps_left
        {
            get
            {
                return bizeps_left;
            }

            set
            {
                bizeps_left = value;
            }
        }

        public double Bizeps_right
        {
            get
            {
                return bizeps_right;
            }

            set
            {
                bizeps_right = value;
            }
        }

        public double Chest
        {
            get
            {
                return chest;
            }

            set
            {
                chest = value;
            }
        }

        public double Quad_left
        {
            get
            {
                return quad_left;
            }

            set
            {
                quad_left = value;
            }
        }

        public double Quad_right
        {
            get
            {
                return quad_right;
            }

            set
            {
                quad_right = value;
            }
        }

        public double Butt
        {
            get
            {
                return butt;
            }

            set
            {
                butt = value;
            }
        }

        public double Neck
        {
            get
            {
                return neck;
            }

            set
            {
                neck = value;
            }
        }

        public double Shoulders
        {
            get
            {
                return shoulders;
            }

            set
            {
                shoulders = value;
            }
        }

        public double Lat
        {
            get
            {
                return lat;
            }

            set
            {
                lat = value;
            }
        }

        public double Waist
        {
            get
            {
                return waist;
            }

            set
            {
                waist = value;
            }
        }

        public double Calf_left
        {
            get
            {
                return calf_left;
            }

            set
            {
                calf_left = value;
            }
        }

        public double Calf_right
        {
            get
            {
                return calf_right;
            }

            set
            {
                calf_right = value;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------





        // Constructors------------------------------------------------------------------------------------------------------------
        public Cl_Athlete (string nickname, string email, string sex, double weight, double height, DateTime birthday)
        {
            this.nickname = nickname;
            this.email = email;
            this.sex = sex;
            this.weight = weight;
            this.height = height;
            this.birthday = birthday;
            this.age = Cl_Athlete.calc_age(birthday);
        }

        public Cl_Athlete (string nickname, string email, string sex, DateTime birthday, double weight, double height, double ffm, double ffmi, double kfa)
        {
            this.nickname = nickname;
            this.email = email;
            this.sex = sex;
            this.birthday = birthday;
            this.age = Cl_Athlete.calc_age(birthday);
            this.weight = weight;
            this.height = height;
            this.ffm = ffm;
            this.ffmi = ffmi;
            this.kfa = kfa;
        }

        public Cl_Athlete()
        {
        }
        //-------------------------------------------------------------------------------------------------------------------------





        //Static Methods and Functions---------------------------------------------------------------------------------------------
        public static double calc_kfa(double stomach, double neck, double height)
        {
            double result;

            result = 495 / 1.0324 - 0.19077 * (stomach - neck) + 0.15456 * height - 450;

            return (Math.Round(result, 2));
        }

        public static double calc_kfa(double stomach, double neck, double height, double waist)
        {
            double result;

            result = 495 / 1.29579 - 0.35004 * (stomach + waist - neck) + 0.22100 * height - 450;

            return (Math.Round(result, 2));
        }

        public static double calc_ffm(double weight, double kfa)
        {
            double result;

            result = weight * (100 - kfa) / 100;

            return (Math.Round(result, 2));
        }

        public static double calc_ffmi(double weight, double ffm)
        {
            double result;

            result = ffm / (weight * weight) + 6.3 * (1.8 - weight);

            return (Math.Round(result, 2));
        }

        public static int calc_age(DateTime birthday)
        {
            int age = DateTime.Now.Year - birthday.Year;
            birthday = birthday.AddYears(age);
            if (DateTime.Now.CompareTo(birthday) < 0)
            {
                age--;
            }
            return (age);
        }

        public static double calc_kcal(double weight, double height, int age, string sex, double job_factor, double sport_kcal, double goal_kcal)
        {
            double result;

            if (sex == "male")
            {
                result = ((66.47 + (13.7 * weight + 5 * height - 6.8 * age)) * job_factor) + sport_kcal + goal_kcal;
            }
            else
            {
                result = ((655.1 + (9.6 * weight + 1.8 * height - 4.7 * age)) * job_factor) + sport_kcal + goal_kcal;
            }

            return result;
        }

        public static double calc_kcal(Cl_ActivityCalculator activity, Cl_Athlete athlete)
        {
            double result;

            if (athlete.Sex == "male")
            {
                result = ((66.47 + (13.7 * athlete.Weight + 5 * athlete.Height - 6.8 * athlete.Age)) * activity.Job_factor) + activity.Sport_kcal + activity.Goal_kcal;
            }
            else
            {
                result = ((655.1 + (9.6 * athlete.Weight + 1.8 * athlete.Height - 4.7 * athlete.Age)) * activity.Job_factor) + activity.Sport_kcal + activity.Goal_kcal;
            }

            return result;
        }
        //-------------------------------------------------------------------------------------------------------------------------





        //Class Methods and Functions---------------------------------------------------------------------------------------------
        public void set_kfa()
        {
            if (sex == "male")
            {
                this.kfa = 495 / (1.0324 - 0.19077 * Math.Log10(stomach - neck) + 0.15456 * Math.Log10(height)) - 450;
            }
            else
            {
                this.kfa = 495 / (1.29579 - 0.35004 * Math.Log10(stomach + waist - neck) + 0.22100 * Math.Log10(height)) - 450;
            }
        }

        public void set_ffm()
        {
            this.ffm = weight * (100 - kfa) / 100;
        }
      
        public void set_ffmi()
        {
            this.ffmi = ffm / (height * height) + 6.3 * (1.8 - height);
        }

        public void set_age(DateTime birthday)
        {
            int age = DateTime.Now.Year - birthday.Year;
            birthday = birthday.AddYears(age);
            if (DateTime.Now.CompareTo(birthday) < 0)
            {
                age--;
            }
            this.age = age;
        }
        //-------------------------------------------------------------------------------------------------------------------------

    }
}
