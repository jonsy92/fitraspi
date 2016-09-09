namespace FitRaspi
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Alter = new System.Windows.Forms.Button();
            this.tB_A = new System.Windows.Forms.TextBox();
            this.tB_B = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Alter
            // 
            this.btn_Alter.Location = new System.Drawing.Point(180, 76);
            this.btn_Alter.Name = "btn_Alter";
            this.btn_Alter.Size = new System.Drawing.Size(75, 23);
            this.btn_Alter.TabIndex = 0;
            this.btn_Alter.Text = "Alter";
            this.btn_Alter.UseVisualStyleBackColor = true;
            this.btn_Alter.Click += new System.EventHandler(this.btn_Alter_Click);
            // 
            // tB_A
            // 
            this.tB_A.Location = new System.Drawing.Point(22, 48);
            this.tB_A.Name = "tB_A";
            this.tB_A.Size = new System.Drawing.Size(100, 20);
            this.tB_A.TabIndex = 1;
            // 
            // tB_B
            // 
            this.tB_B.Location = new System.Drawing.Point(22, 111);
            this.tB_B.Name = "tB_B";
            this.tB_B.Size = new System.Drawing.Size(100, 20);
            this.tB_B.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tB_B);
            this.Controls.Add(this.tB_A);
            this.Controls.Add(this.btn_Alter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Alter;
        private System.Windows.Forms.TextBox tB_A;
        private System.Windows.Forms.TextBox tB_B;
    }
}

