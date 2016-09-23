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
    public partial class Daniels_Prüfungsplattform : Form
    {
        public Daniels_Prüfungsplattform()
        {
            InitializeComponent();
        }

        private void rB_plus_Click(object sender, EventArgs e)
        {
            lbl_operator.Text = "+";
            lbl_operator2.Text = "+";
        }

        private void rB_minus_Click(object sender, EventArgs e)
        {
            lbl_operator.Text = "-";
            lbl_operator2.Text = "-";
        }

        private void rB_mal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
            this.Hide();
            Testformular tf = new Testformular();
            tf.Show();

        }

        private void rB_mal_Click(object sender, EventArgs e)
        {
            lbl_operator.Text = "*";
            lbl_operator2.Text = "*";
        }

        private void rB_geteilt_Click(object sender, EventArgs e)
        {
            lbl_operator.Text = "/";
            lbl_operator2.Text = "/";
        }

        private void btn_rechne_Click(object sender, EventArgs e)
        {
            try
            {
                int zahl1 = Convert.ToInt32(tB_zahl1.Text);
                int zahl2 = Convert.ToInt32(tB_zahl2.Text);

                string rechenoperator = "";

                if (rB_plus.Checked)
                {
                    rechenoperator = "+";
                }
                else if (rB_minus.Checked)
                {
                    rechenoperator = "-";
                }
                else if (rB_mal.Checked)
                {
                    rechenoperator = "*";
                }
                else if (rB_geteilt.Checked)
                {
                    rechenoperator = "/";
                }

                lbl_ergebnis.Text = Convert.ToString(Cl_Daniels_Calculator.calculate(zahl1, zahl2, rechenoperator));

                if (tB_zahl3.Visible)
                {
                    int zahl3 = Convert.ToInt32(tB_zahl3.Text);
                    lbl_ergebnis.Text = Convert.ToString(Cl_Daniels_Calculator.calculate(zahl1, zahl2, zahl3, rechenoperator));
                }

                //lbl_ergebnis.Text =  --> Hier sollst du nachher die Funktion "calculate" aufrufen,
                // die folgende Funktionalität besitzen soll: Addition,Subtraktion,Multiplikation und Division von sowohl 2 als auch 3 Zahlen.
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message);
            }
             catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_zusatz_Click(object sender, EventArgs e)
        {
            if ((label7.Visible && tB_zahl3.Visible) == true)
            {
                lbl_operator2.Visible = false;
                label7.Visible = false;
                tB_zahl3.Visible = false;
            }
            else
            {
                lbl_operator2.Visible = true;                
                label7.Visible = true;
                tB_zahl3.Visible = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
