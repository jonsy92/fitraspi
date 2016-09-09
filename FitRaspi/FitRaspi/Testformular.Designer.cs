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
            this.panel3 = new System.Windows.Forms.Panel();
            this.mC_birthdate = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
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
            this.btn_sqlconnection.Location = new System.Drawing.Point(23, 9);
            this.btn_sqlconnection.Name = "btn_sqlconnection";
            this.btn_sqlconnection.Size = new System.Drawing.Size(177, 77);
            this.btn_sqlconnection.TabIndex = 2;
            this.btn_sqlconnection.Text = "Connect Database";
            this.btn_sqlconnection.UseVisualStyleBackColor = true;
            this.btn_sqlconnection.Click += new System.EventHandler(this.btn_sqlconnection_Click);
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(23, 379);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(177, 77);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "Close the Window";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_calc_age
            // 
            this.btn_calc_age.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calc_age.Location = new System.Drawing.Point(23, 105);
            this.btn_calc_age.Name = "btn_calc_age";
            this.btn_calc_age.Size = new System.Drawing.Size(177, 77);
            this.btn_calc_age.TabIndex = 5;
            this.btn_calc_age.Text = "Calculate my age";
            this.btn_calc_age.UseVisualStyleBackColor = true;
            this.btn_calc_age.Click += new System.EventHandler(this.btn_calc_age_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.Controls.Add(this.btn_sqlconnection);
            this.panel2.Controls.Add(this.btn_calc_age);
            this.panel2.Controls.Add(this.btn_close);
            this.panel2.Location = new System.Drawing.Point(518, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(558, 475);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.mC_birthdate);
            this.panel3.Location = new System.Drawing.Point(12, 128);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(467, 475);
            this.panel3.TabIndex = 6;
            // 
            // mC_birthdate
            // 
            this.mC_birthdate.Location = new System.Drawing.Point(9, 20);
            this.mC_birthdate.Name = "mC_birthdate";
            this.mC_birthdate.TabIndex = 1;
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
    }
}