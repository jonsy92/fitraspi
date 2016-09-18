namespace FitRaspi
{
    partial class Testformular
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_sqlconnection = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_calc_age = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_classtester = new System.Windows.Forms.Button();
            this.btn_close_database_connection = new System.Windows.Forms.Button();
            this.btn_calc_ffmi = new System.Windows.Forms.Button();
            this.btn_calc_ffm = new System.Windows.Forms.Button();
            this.btn_calc_kfa = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tB_Nickname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rB_female = new System.Windows.Forms.RadioButton();
            this.rB_male = new System.Windows.Forms.RadioButton();
            this.tB_waist = new System.Windows.Forms.TextBox();
            this.tB_stomach = new System.Windows.Forms.TextBox();
            this.tB_neck = new System.Windows.Forms.TextBox();
            this.tB_weight = new System.Windows.Forms.TextBox();
            this.tB_height = new System.Windows.Forms.TextBox();
            this.lbl_waist = new System.Windows.Forms.Label();
            this.lbl_stomach = new System.Windows.Forms.Label();
            this.lbl_weight = new System.Windows.Forms.Label();
            this.lbl_neck = new System.Windows.Forms.Label();
            this.lbl_height = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mC_birthdate = new System.Windows.Forms.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(453, 24);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(253, 45);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Testlandschaft";
            this.lbl_title.Click += new System.EventHandler(this.lbl_title_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.lbl_title);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 100);
            this.panel1.TabIndex = 2;
            // 
            // btn_sqlconnection
            // 
            this.btn_sqlconnection.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sqlconnection.Location = new System.Drawing.Point(3, 4);
            this.btn_sqlconnection.Name = "btn_sqlconnection";
            this.btn_sqlconnection.Size = new System.Drawing.Size(153, 53);
            this.btn_sqlconnection.TabIndex = 2;
            this.btn_sqlconnection.Text = "Connect Database";
            this.btn_sqlconnection.UseVisualStyleBackColor = true;
            this.btn_sqlconnection.Click += new System.EventHandler(this.btn_sqlconnection_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackgroundImage = global::FitRaspi.Properties.Resources.exit;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(424, 376);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(134, 99);
            this.btn_close.TabIndex = 4;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_calc_age
            // 
            this.btn_calc_age.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calc_age.Location = new System.Drawing.Point(3, 63);
            this.btn_calc_age.Name = "btn_calc_age";
            this.btn_calc_age.Size = new System.Drawing.Size(153, 53);
            this.btn_calc_age.TabIndex = 5;
            this.btn_calc_age.Text = "Calculate my age";
            this.btn_calc_age.UseVisualStyleBackColor = true;
            this.btn_calc_age.Click += new System.EventHandler(this.btn_calc_age_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btn_classtester);
            this.panel2.Controls.Add(this.btn_close_database_connection);
            this.panel2.Controls.Add(this.btn_calc_ffmi);
            this.panel2.Controls.Add(this.btn_calc_ffm);
            this.panel2.Controls.Add(this.btn_calc_kfa);
            this.panel2.Controls.Add(this.btn_sqlconnection);
            this.panel2.Controls.Add(this.btn_calc_age);
            this.panel2.Controls.Add(this.btn_close);
            this.panel2.Location = new System.Drawing.Point(518, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(558, 475);
            this.panel2.TabIndex = 3;
            // 
            // btn_classtester
            // 
            this.btn_classtester.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_classtester.Location = new System.Drawing.Point(3, 300);
            this.btn_classtester.Name = "btn_classtester";
            this.btn_classtester.Size = new System.Drawing.Size(153, 53);
            this.btn_classtester.TabIndex = 10;
            this.btn_classtester.Text = "Test my User_Class";
            this.btn_classtester.UseVisualStyleBackColor = true;
            this.btn_classtester.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_close_database_connection
            // 
            this.btn_close_database_connection.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close_database_connection.Location = new System.Drawing.Point(162, 4);
            this.btn_close_database_connection.Name = "btn_close_database_connection";
            this.btn_close_database_connection.Size = new System.Drawing.Size(153, 53);
            this.btn_close_database_connection.TabIndex = 9;
            this.btn_close_database_connection.Text = "Disconnect Database";
            this.btn_close_database_connection.UseVisualStyleBackColor = true;
            this.btn_close_database_connection.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_calc_ffmi
            // 
            this.btn_calc_ffmi.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calc_ffmi.Location = new System.Drawing.Point(3, 241);
            this.btn_calc_ffmi.Name = "btn_calc_ffmi";
            this.btn_calc_ffmi.Size = new System.Drawing.Size(153, 53);
            this.btn_calc_ffmi.TabIndex = 8;
            this.btn_calc_ffmi.Text = "Calculate my FFMI";
            this.btn_calc_ffmi.UseVisualStyleBackColor = true;
            // 
            // btn_calc_ffm
            // 
            this.btn_calc_ffm.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calc_ffm.Location = new System.Drawing.Point(3, 181);
            this.btn_calc_ffm.Name = "btn_calc_ffm";
            this.btn_calc_ffm.Size = new System.Drawing.Size(153, 53);
            this.btn_calc_ffm.TabIndex = 7;
            this.btn_calc_ffm.Text = "Calculate my FFM";
            this.btn_calc_ffm.UseVisualStyleBackColor = true;
            this.btn_calc_ffm.Click += new System.EventHandler(this.btn_calc_ffm_Click);
            // 
            // btn_calc_kfa
            // 
            this.btn_calc_kfa.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calc_kfa.Location = new System.Drawing.Point(3, 122);
            this.btn_calc_kfa.Name = "btn_calc_kfa";
            this.btn_calc_kfa.Size = new System.Drawing.Size(153, 53);
            this.btn_calc_kfa.TabIndex = 6;
            this.btn_calc_kfa.Text = "Calculate my KFA";
            this.btn_calc_kfa.UseVisualStyleBackColor = true;
            this.btn_calc_kfa.Click += new System.EventHandler(this.btn_calc_kfa_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel3.Controls.Add(this.tB_Nickname);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.rB_female);
            this.panel3.Controls.Add(this.rB_male);
            this.panel3.Controls.Add(this.tB_waist);
            this.panel3.Controls.Add(this.tB_stomach);
            this.panel3.Controls.Add(this.tB_neck);
            this.panel3.Controls.Add(this.tB_weight);
            this.panel3.Controls.Add(this.tB_height);
            this.panel3.Controls.Add(this.lbl_waist);
            this.panel3.Controls.Add(this.lbl_stomach);
            this.panel3.Controls.Add(this.lbl_weight);
            this.panel3.Controls.Add(this.lbl_neck);
            this.panel3.Controls.Add(this.lbl_height);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.mC_birthdate);
            this.panel3.Location = new System.Drawing.Point(12, 128);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(467, 475);
            this.panel3.TabIndex = 6;
            // 
            // tB_Nickname
            // 
            this.tB_Nickname.Location = new System.Drawing.Point(271, 280);
            this.tB_Nickname.Name = "tB_Nickname";
            this.tB_Nickname.Size = new System.Drawing.Size(100, 20);
            this.tB_Nickname.TabIndex = 20;
            this.tB_Nickname.Text = "Jonas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(198, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nickname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Sex:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // rB_female
            // 
            this.rB_female.AutoSize = true;
            this.rB_female.Location = new System.Drawing.Point(47, 241);
            this.rB_female.Name = "rB_female";
            this.rB_female.Size = new System.Drawing.Size(56, 17);
            this.rB_female.TabIndex = 17;
            this.rB_female.TabStop = true;
            this.rB_female.Text = "female";
            this.rB_female.UseVisualStyleBackColor = true;
            // 
            // rB_male
            // 
            this.rB_male.AutoSize = true;
            this.rB_male.Checked = true;
            this.rB_male.Location = new System.Drawing.Point(47, 203);
            this.rB_male.Name = "rB_male";
            this.rB_male.Size = new System.Drawing.Size(47, 17);
            this.rB_male.TabIndex = 16;
            this.rB_male.TabStop = true;
            this.rB_male.Text = "male";
            this.rB_male.UseVisualStyleBackColor = true;
            // 
            // tB_waist
            // 
            this.tB_waist.Location = new System.Drawing.Point(72, 448);
            this.tB_waist.Name = "tB_waist";
            this.tB_waist.Size = new System.Drawing.Size(100, 20);
            this.tB_waist.TabIndex = 15;
            this.tB_waist.Text = "120";
            // 
            // tB_stomach
            // 
            this.tB_stomach.Location = new System.Drawing.Point(72, 406);
            this.tB_stomach.Name = "tB_stomach";
            this.tB_stomach.Size = new System.Drawing.Size(100, 20);
            this.tB_stomach.TabIndex = 14;
            this.tB_stomach.Text = "100";
            // 
            // tB_neck
            // 
            this.tB_neck.Location = new System.Drawing.Point(72, 364);
            this.tB_neck.Name = "tB_neck";
            this.tB_neck.Size = new System.Drawing.Size(100, 20);
            this.tB_neck.TabIndex = 13;
            this.tB_neck.Text = "80";
            // 
            // tB_weight
            // 
            this.tB_weight.Location = new System.Drawing.Point(72, 322);
            this.tB_weight.Name = "tB_weight";
            this.tB_weight.Size = new System.Drawing.Size(100, 20);
            this.tB_weight.TabIndex = 12;
            this.tB_weight.Text = "80";
            // 
            // tB_height
            // 
            this.tB_height.Location = new System.Drawing.Point(72, 280);
            this.tB_height.Name = "tB_height";
            this.tB_height.Size = new System.Drawing.Size(100, 20);
            this.tB_height.TabIndex = 11;
            this.tB_height.Text = "180";
            // 
            // lbl_waist
            // 
            this.lbl_waist.AutoSize = true;
            this.lbl_waist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_waist.Location = new System.Drawing.Point(9, 448);
            this.lbl_waist.Name = "lbl_waist";
            this.lbl_waist.Size = new System.Drawing.Size(43, 13);
            this.lbl_waist.TabIndex = 8;
            this.lbl_waist.Text = "Waist:";
            // 
            // lbl_stomach
            // 
            this.lbl_stomach.AutoSize = true;
            this.lbl_stomach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stomach.Location = new System.Drawing.Point(9, 406);
            this.lbl_stomach.Name = "lbl_stomach";
            this.lbl_stomach.Size = new System.Drawing.Size(60, 13);
            this.lbl_stomach.TabIndex = 7;
            this.lbl_stomach.Text = "Stomach:";
            // 
            // lbl_weight
            // 
            this.lbl_weight.AutoSize = true;
            this.lbl_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_weight.Location = new System.Drawing.Point(9, 322);
            this.lbl_weight.Name = "lbl_weight";
            this.lbl_weight.Size = new System.Drawing.Size(51, 13);
            this.lbl_weight.TabIndex = 6;
            this.lbl_weight.Text = "Weight:";
            // 
            // lbl_neck
            // 
            this.lbl_neck.AutoSize = true;
            this.lbl_neck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_neck.Location = new System.Drawing.Point(9, 364);
            this.lbl_neck.Name = "lbl_neck";
            this.lbl_neck.Size = new System.Drawing.Size(41, 13);
            this.lbl_neck.TabIndex = 5;
            this.lbl_neck.Text = "Neck:";
            // 
            // lbl_height
            // 
            this.lbl_height.AutoSize = true;
            this.lbl_height.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_height.Location = new System.Drawing.Point(9, 280);
            this.lbl_height.Name = "lbl_height";
            this.lbl_height.Size = new System.Drawing.Size(48, 13);
            this.lbl_height.TabIndex = 3;
            this.lbl_height.Text = "Height:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Birthdate";
            // 
            // mC_birthdate
            // 
            this.mC_birthdate.Location = new System.Drawing.Point(9, 20);
            this.mC_birthdate.Name = "mC_birthdate";
            this.mC_birthdate.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(162, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 53);
            this.button1.TabIndex = 11;
            this.button1.Text = "Test my Athlete_Class";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Testformular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 615);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Testformular";
            this.Text = "Testformular";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_sqlconnection;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_calc_age;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar mC_birthdate;
        private System.Windows.Forms.Button btn_calc_ffmi;
        private System.Windows.Forms.Button btn_calc_ffm;
        private System.Windows.Forms.Button btn_calc_kfa;
        private System.Windows.Forms.Label lbl_height;
        private System.Windows.Forms.Label lbl_waist;
        private System.Windows.Forms.Label lbl_stomach;
        private System.Windows.Forms.Label lbl_weight;
        private System.Windows.Forms.Label lbl_neck;
        private System.Windows.Forms.TextBox tB_waist;
        private System.Windows.Forms.TextBox tB_stomach;
        private System.Windows.Forms.TextBox tB_neck;
        private System.Windows.Forms.TextBox tB_weight;
        private System.Windows.Forms.TextBox tB_height;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rB_female;
        private System.Windows.Forms.RadioButton rB_male;
        private System.Windows.Forms.Button btn_close_database_connection;
        private System.Windows.Forms.Button btn_classtester;
        private System.Windows.Forms.TextBox tB_Nickname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}