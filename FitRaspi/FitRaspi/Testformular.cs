using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitRaspi
{
    public partial class Testformular : Form
    {
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
                Cl_MySQL.getMySQLConnection("localhost","root","","fit-raspi");
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
                double stomach = Convert.ToDouble(tB_stomach.Text); // das hier war wohl auch nicht die cleverste Lösung #ichbinimmernochdumm
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
    }
}
