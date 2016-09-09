using System;

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
            this.btn_calc_kfa = new System.Windows.Forms.Button();
            this.tB_kfa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_calc_kfa
            // 
            this.btn_calc_kfa.Location = new System.Drawing.Point(71, 99);
            this.btn_calc_kfa.Name = "btn_calc_kfa";
            this.btn_calc_kfa.Size = new System.Drawing.Size(161, 59);
            this.btn_calc_kfa.TabIndex = 0;
            this.btn_calc_kfa.Text = "Errechne mein KFA";
            this.btn_calc_kfa.UseVisualStyleBackColor = true;
            this.btn_calc_kfa.Click += new System.EventHandler(this.btn_calc_kfa_Click);
            // 
            // tB_kfa
            // 
            this.tB_kfa.Location = new System.Drawing.Point(71, 48);
            this.tB_kfa.Name = "tB_kfa";
            this.tB_kfa.Size = new System.Drawing.Size(161, 20);
            this.tB_kfa.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tB_kfa);
            this.Controls.Add(this.btn_calc_kfa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btn_calc_kfa_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button btn_calc_kfa;
        private System.Windows.Forms.TextBox tB_kfa;
    }
}

