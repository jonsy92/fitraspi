﻿using System;
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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Alter_Click(object sender, EventArgs e)
        {
            string bd = tB_A.Text;

            DateTime birthday = Convert.ToDateTime(bd);

            int age = Cl_Athlete.calc_age(birthday);

            tB_B.Text = Convert.ToString(age);
        }
    }
}
