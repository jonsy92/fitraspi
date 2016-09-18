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

        //-------------------------------------------------------------------------------------------------------------------------





        // Constructors------------------------------------------------------------------------------------------------------------
        public Cl_Athlete (string nickname, string firstname, string email, string sex, double weight, double height)
        {
            this.nickname = nickname;
            this.email = email;
            this.sex = sex;
            this.weight = weight;
            this.height = height;
        }

        public Cl_Athlete (string nickname, string email, string sex, DateTime birthday, int age, double weight, double height, double ffm, double ffmi, double kfa)
        {
            this.nickname = nickname;
            this.email = email;
            this.sex = sex;
            this.birthday = birthday;
            this.age = age;
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

            result = 495 / (1.0324 - 0.19077 * Math.Log10(stomach - neck) + 0.15456 * Math.Log10(height)) - 450;

            return (Math.Round(result, 2));
        }

        public static double calc_kfa(double stomach, double neck, double height, double waist)
        {
            double result;

            result = 495 / (1.29579 - 0.35004 * Math.Log10(stomach + waist - neck) + 0.22100 * Math.Log10(height)) - 450;

            return (Math.Round(result, 2));
        }

        public static double calc_ffm(double weight, double kfa)
        {
            double result;

            result = weight * (100 - kfa) / 100;

            return (Math.Round(result, 2));
        }

        public static double calc_ffmi(double height, double ffm)
        {
            double result;

            result = ffm / (height * height) + 6.3 * (1.8 - height);

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
        //-------------------------------------------------------------------------------------------------------------------------





        //Class Methods and Functions---------------------------------------------------------------------------------------------
        public void set_kfa(double stomach, double neck, double height)
        {
            this.kfa = 495 / (1.0324 - 0.19077 * Math.Log10(stomach - neck) + 0.15456 * Math.Log10(height)) - 450;
        }
       
        public void set_kfa(double stomach, double neck, double height, double waist)
        {
            this.kfa = 495 / (1.29579 - 0.35004 * Math.Log10(stomach + waist - neck) + 0.22100 * Math.Log10(height)) - 450;
        }

        public void set_ffm(double weight, double kfa)
        {
            this.ffm = weight * (100 - kfa) / 100;
        }
      
        public void set_ffmi(double height,double ffm)
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

        public static double calc_kcal(double weight, double height, int age, string sex, Cl_ActivityCalculator activity)
        {
            double job = activity.Job_factor;

            double sport = activity.Sport_kcal;

            double goal = activity.Goal;

            double result;

            if (sex == "male")
            { 
                result = (66.47 + (13.7 * weight + 5 * height - 6.8 * age)) + job + sport + goal;
            }
            else
            {
                result = (655.1 + (9.6 * weight + 1.8 * height - 4.7 * age)) + job + sport + goal;
            }

            return result;
        }
        //-------------------------------------------------------------------------------------------------------------------------

    }
}
