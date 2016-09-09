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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_input_title = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_output_title = new System.Windows.Forms.Label();
            this.btn_sqlconnection = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.LightCyan;
            this.flowLayoutPanel1.Controls.Add(this.lbl_input_title);
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 128);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(550, 231);
            this.flowLayoutPanel1.TabIndex = 1;
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
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.LightCyan;
            this.flowLayoutPanel2.Controls.Add(this.btn_sqlconnection);
            this.flowLayoutPanel2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel2.Location = new System.Drawing.Point(582, 128);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(494, 475);
            this.flowLayoutPanel2.TabIndex = 2;
            this.flowLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // lbl_input_title
            // 
            this.lbl_input_title.AutoSize = true;
            this.lbl_input_title.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_input_title.Location = new System.Drawing.Point(3, 0);
            this.lbl_input_title.Name = "lbl_input_title";
            this.lbl_input_title.Size = new System.Drawing.Size(57, 22);
            this.lbl_input_title.TabIndex = 0;
            this.lbl_input_title.Text = "Input";
            this.lbl_input_title.Click += new System.EventHandler(this.label1_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.LightCyan;
            this.flowLayoutPanel3.Controls.Add(this.lbl_output_title);
            this.flowLayoutPanel3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel3.Location = new System.Drawing.Point(12, 365);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(550, 238);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // lbl_output_title
            // 
            this.lbl_output_title.AutoSize = true;
            this.lbl_output_title.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_output_title.Location = new System.Drawing.Point(3, 0);
            this.lbl_output_title.Name = "lbl_output_title";
            this.lbl_output_title.Size = new System.Drawing.Size(73, 22);
            this.lbl_output_title.TabIndex = 0;
            this.lbl_output_title.Text = "Output";
            this.lbl_output_title.Click += new System.EventHandler(this.label3_Click);
            // 
            // btn_sqlconnection
            // 
            this.btn_sqlconnection.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sqlconnection.Location = new System.Drawing.Point(3, 3);
            this.btn_sqlconnection.Name = "btn_sqlconnection";
            this.btn_sqlconnection.Size = new System.Drawing.Size(177, 77);
            this.btn_sqlconnection.TabIndex = 2;
            this.btn_sqlconnection.Text = "Connect Database";
            this.btn_sqlconnection.UseVisualStyleBackColor = true;
            this.btn_sqlconnection.Click += new System.EventHandler(this.btn_sqlconnection_Click);
            // 
            // Testformular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 615);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Testformular";
            this.Text = "Testformular";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label lbl_input_title;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label lbl_output_title;
        private System.Windows.Forms.Button btn_sqlconnection;
    }
}