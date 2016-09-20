using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace FitRaspi
{
    public partial class Testformular : Form
    {
        MySqlConnection connection;

        public Testformular()
        {
            InitializeComponent();
        }

        private void lbl_title_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_sqlconnection_Click(object sender, EventArgs e)
        {
            try
            {
               connection = Cl_MySQL.getMySQLConnection("localhost","root","","fit-raspi");
               Cl_MySQL.OpenMySQLConnection(connection);

                MessageBox.Show("You are connected to the database: FIT-RASPI");
            }
            catch
            {
                MessageBox.Show("Fail to connect to database");
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_calc_age_Click(object sender, EventArgs e)
        {
            int age = Cl_Athlete.calc_age(mC_birthdate.SelectionRange.Start);
            MessageBox.Show("Digga, du biste " + age + " Jahre alt!");
        }

        private void btn_calc_kfa_Click(object sender, EventArgs e)
        {
            try
            {
                double stomach = Convert.ToDouble(tB_stomach.Text); 
                double neck = Convert.ToDouble(tB_neck.Text);
                double height = Convert.ToDouble(tB_height.Text);
                double waist = Convert.ToDouble(tB_waist.Text);

                if (rB_male.Checked)
                {
                    double kfa = Cl_Athlete.calc_kfa(stomach, neck, height);
                    MessageBox.Show("Digga, dein KFA liegt bei " + kfa + " %!");
                }
                else if (rB_female.Checked)
                {
                    double kfa = Cl_Athlete.calc_kfa(stomach, neck, height, waist);
                    MessageBox.Show("Diggi, dein KFA liegt bei " + kfa + " %!");
                }
            }

            catch
            {
                MessageBox.Show("Es sind nicht alle Felder ausgefüllt!");
            }
        }

        private void btn_calc_ffm_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Cl_MySQL.CloseMySQLConnection(connection);
                MessageBox.Show("You are disconnected from the database!");
            }
            catch
            {
                MessageBox.Show("No database-connection exists!");
            }
        }

        private void button1_Click_1(object sender, EventArgs e) // test my class
        {
            Cl_User jonas = new Cl_User(tB_Nickname.Text);

            try
            {
                string userid = jonas.get_uid(jonas.Username);
                MessageBox.Show("My password is: " + jonas.get_password(userid), "Info");
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Cl_Athlete Daniel = new Cl_Athlete("DanielS", "daniel1093@icloud.com", "male", 78, 175, mC_birthdate.SelectionRange.Start);

            Cl_ActivityCalculator activity = new Cl_ActivityCalculator();

            activity.Goal_kcal = Cl_ActivityCalculator.calc_goal_calories(0.5);

            activity.Job_factor = Cl_ActivityCalculator.get_job_factor("normal");

            activity.Sport_kcal = Cl_ActivityCalculator.get_sport_calories(Daniel, 60, 3, "power lifting");

            Daniel.Kfa = Cl_Athlete.calc_kfa(100, 78, Daniel.Height);

            Daniel.Bizeps_left = 34;

            Daniel.Bizeps_right = 33.5;

            Daniel.Butt = 98;

            Daniel.Calf_left = 39;

            Daniel.Calf_right = 38;

            Daniel.Chest = 98;

            Daniel.Ffm = Cl_Athlete.calc_ffm(Daniel.Weight, Daniel.Kfa);

            Daniel.Ffmi = Cl_Athlete.calc_ffmi(Daniel.Height, Daniel.Ffm);

            Daniel.Kcal = Convert.ToInt32(Cl_Athlete.calc_kcal(activity, Daniel));

            Daniel.Lat = 100;

            Daniel.Quad_left = 88;

            Daniel.Quad_right = 87.5;

            Daniel.Shoulders = 105;

            Daniel.Stomach = 100;

            Daniel.Waist = 90;

            Daniel.Neck = 77;

            MessageBox.Show("Meine Daten sind wie folgt: \n" + Daniel.Kfa + "\n" + Daniel.Ffm + "\n" + Daniel.Ffmi + "\n" + Daniel.Kcal);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cl_StrengthStats Daniel = new FitRaspi.Cl_StrengthStats(80, 62.5, 67.5, 115, 32.5, 78); // Wieso verwendest du nicht den Standardkonstruktor? :)
                            // am besten immer sinnvolle Instanzennamen wählen ;)                   // Die Werte bieten dir ja keinen mehrwert ;)
                            // beim Athleten geht das druch, aber bei den strengthstats ist das etwas verwirrend
                            // wenn du dir unsicher bist einfach den namen nach CL_... klein geschrieben verwenden.
                            // strengthstats_daniel würde auch passen ;)

            Daniel.Squats = Cl_StrengthStats.calc_one_repeat_max(Daniel.Squats, 10); // hier wäre jetzt die Stelle an der du deine Gewichte einträgst ;)

            Daniel.Bench_press = Cl_StrengthStats.calc_one_repeat_max(Daniel.Bench_press, 11);// ||

            Daniel.Dead_lift = Cl_StrengthStats.calc_one_repeat_max(Daniel.Dead_lift, 10);// ||

            Daniel.Barbell_rowing = Cl_StrengthStats.calc_one_repeat_max(Daniel.Barbell_rowing, 10);// ||

            Daniel.Military_press = Cl_StrengthStats.calc_one_repeat_max(Daniel.Military_press, 11);// ||

            Daniel.Pull_ups = Cl_StrengthStats.calc_one_repeat_max(Daniel.Pull_ups, 8);// ||

            Daniel.set_repeats_per_weight(85, Daniel.Squats);//  Der Aufruf ist richtig  ;)

            Daniel.set_weight_per_repeats(Daniel.Squats, 6); // Und der auch^^


            //Schöne Ausgabe ;)
            MessageBox.Show("Meine 1RM's sind: \nSquats: " + Daniel.Squats + "\nBench_Press: " + Daniel.Bench_press +
                "\nDead_Lift: " + Daniel.Dead_lift + "\nBarbell_Rowing: " + Daniel.Barbell_rowing + "\nMilitary_Press: " + Daniel.Military_press +
                "\nPull_Ups: " + Daniel.Pull_ups + "\nMeine Wiederholungszahl für 85kg Squats sind: " + Daniel.Repeats_per_weight + "\nMein Gewicht für 6 Wdh's Squats ist: " + Daniel.Weight_per_repeats );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cl_MacroPlanner Daniel = new Cl_MacroPlanner();
            // Hier das gleiche Thema wie oben ;)

            Cl_Athlete Me = new Cl_Athlete("Daniel10S", "bsp@i.com", "male", 78, 175, mC_birthdate.SelectionRange.Start);
            // Hier auch das gleiche Thema und me ist ein geschützter Begriff, aber das konnteste nicht wissen :)
            // Haste den Athleten zum üben instanziiert? :)

            Daniel.Kcal = Cl_MacroPlanner.calc_kcal(190, 40, 360);
            

            MessageBox.Show("Du solltest " + Daniel.Kcal + " kcal pro Tag zu dir nehmen.");
            
        }
    }
}


// Hoffe das war jetzt nicht zu viel negative Kritik...
// Fühle mich gerade wie so ein nerviger Lehrer, der peinlichst genau auf jede Kleinigkeit achtet... :D