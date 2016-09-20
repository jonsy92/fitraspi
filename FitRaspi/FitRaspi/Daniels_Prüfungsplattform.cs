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
            // Hier darfst du dann die Methoden deiner Klasse verwenden um das Ergebnis zu berechenn ;)
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
    }
}
