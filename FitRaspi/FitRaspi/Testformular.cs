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
                Cl_MySQL.OpenSQLConnection();
            }
            catch
            {
                MessageBox.Show("Fail to connect to database");
            }
        }
    }
}
