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

            activity.Job_factor = Cl_ActivityCalculator.get_job_factor("heavy");

            activity.Sport_kcal = Cl_ActivityCalculator.get_sport_calories(Daniel, 60, 3, "soccer");

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
    }
}
