using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnAdaugaMasa = new System.Windows.Forms.Button();
            this.btnStergeMasa = new System.Windows.Forms.Button();
            this.btnAfiseazaMese = new System.Windows.Forms.Button();
            this.lblNumarMasa = new System.Windows.Forms.Label();
            this.txtNumarMasa = new System.Windows.Forms.TextBox();
            this.lblLocatieMasa = new System.Windows.Forms.Label();
            this.txtLocatieMasa = new System.Windows.Forms.TextBox();
            this.lblCapacitateMasa = new System.Windows.Forms.Label();
            this.txtCapacitateMasa = new System.Windows.Forms.TextBox();
            this.lstMese = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAdaugaMasa
            // 
            this.btnAdaugaMasa.Location = new System.Drawing.Point(12, 12);
            this.btnAdaugaMasa.Name = "btnAdaugaMasa";
            this.btnAdaugaMasa.Size = new System.Drawing.Size(115, 23);
            this.btnAdaugaMasa.TabIndex = 0;
            this.btnAdaugaMasa.Text = "Adaugă Masă";
            this.btnAdaugaMasa.UseVisualStyleBackColor = true;
            this.btnAdaugaMasa.Click += new System.EventHandler(this.btnAdaugaMasa_Click);
            // 
            // btnStergeMasa
            // 
            this.btnStergeMasa.Location = new System.Drawing.Point(12, 41);
            this.btnStergeMasa.Name = "btnStergeMasa";
            this.btnStergeMasa.Size = new System.Drawing.Size(115, 23);
            this.btnStergeMasa.TabIndex = 1;
            this.btnStergeMasa.Text = "Șterge Masă";
            this.btnStergeMasa.UseVisualStyleBackColor = true;
            this.btnStergeMasa.Click += new System.EventHandler(this.btnStergeMasa_Click);
            // 
            // btnAfiseazaMese
            // 
            this.btnAfiseazaMese.Location = new System.Drawing.Point(12, 70);
            this.btnAfiseazaMese.Name = "btnAfiseazaMese";
            this.btnAfiseazaMese.Size = new System.Drawing.Size(115, 23);
            this.btnAfiseazaMese.TabIndex = 2;
            this.btnAfiseazaMese.Text = "Afișează Mese";
            this.btnAfiseazaMese.UseVisualStyleBackColor = true;
            this.btnAfiseazaMese.Click += new System.EventHandler(this.btnAfiseazaMese_Click);
            // 
            // lblNumarMasa
            // 
            this.lblNumarMasa.AutoSize = true;
            this.lblNumarMasa.Location = new System.Drawing.Point(147, 17);
            this.lblNumarMasa.Name = "lblNumarMasa";
            this.lblNumarMasa.Size = new System.Drawing.Size(76, 13);
            this.lblNumarMasa.TabIndex = 3;
            this.lblNumarMasa.Text = "Număr Masă:";
            // 
            // txtNumarMasa
            // 
            this.txtNumarMasa.Location = new System.Drawing.Point(229, 14);
            this.txtNumarMasa.Name = "txtNumarMasa";
            this.txtNumarMasa.Size = new System.Drawing.Size(100, 20);
            this.txtNumarMasa.TabIndex = 4;
            // 
            // lblLocatieMasa
            // 
            this.lblLocatieMasa.AutoSize = true;
            this.lblLocatieMasa.Location = new System.Drawing.Point(147, 46);
            this.lblLocatieMasa.Name = "lblLocatieMasa";
            this.lblLocatieMasa.Size = new System.Drawing.Size(76, 13);
            this.lblLocatieMasa.TabIndex = 5;
            this.lblLocatieMasa.Text = "Locație Masă:";
            // 
            // txtLocatieMasa
            // 
            this.txtLocatieMasa.Location = new System.Drawing.Point(229, 43);
            this.txtLocatieMasa.Name = "txtLocatieMasa";
            this.txtLocatieMasa.Size = new System.Drawing.Size(100, 20);
            this.txtLocatieMasa.TabIndex = 6;
            // 
            // lblCapacitateMasa
            // 
            this.lblCapacitateMasa.AutoSize = true;
            this.lblCapacitateMasa.Location = new System.Drawing.Point(147, 75);
            this.lblCapacitateMasa.Name = "lblCapacitateMasa";
            this.lblCapacitateMasa.Size = new System.Drawing.Size(95, 13);
            this.lblCapacitateMasa.TabIndex = 7;
            this.lblCapacitateMasa.Text = "Capacitate Masă:";
            // 
            // txtCapacitateMasa
            // 
            this.txtCapacitateMasa.Location = new System.Drawing.Point(248, 72);
            this.txtCapacitateMasa.Name = "txtCapacitateMasa";
            this.txtCapacitateMasa.Size = new System.Drawing.Size(81, 20);
            this.txtCapacitateMasa.TabIndex = 8;
            // 
            // lstMese
            // 
            this.lstMese.FormattingEnabled = true;
            this.lstMese.Location = new System.Drawing.Point(12, 99);
            this.lstMese.Name = "lstMese";
            this.lstMese.Size = new System.Drawing.Size(317, 186);
            this.lstMese.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 297);
            this.Controls.Add(this.lstMese);
            this.Controls.Add(this.txtCapacitateMasa);
            this.Controls.Add(this.lblCapacitateMasa);
            this.Controls.Add(this.txtLocatieMasa);
            this.Controls.Add(this.lblLocatieMasa);
            this.Controls.Add(this.txtNumarMasa);
            this.Controls.Add(this.lblNumarMasa);
            this.Controls.Add(this.btnAfiseazaMese);
            this.Controls.Add(this.btnStergeMasa);
            this.Controls.Add(this.btnAdaugaMasa);
            this.Name = "Form1";
            this.Text = "Activitate Restaurant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnAdaugaMasa;
        private System.Windows.Forms.Button btnStergeMasa;
        private System.Windows.Forms.Button btnAfiseazaMese;
        private System.Windows.Forms.Label lblNumarMasa;
        private System.Windows.Forms.TextBox txtNumarMasa;
        private System.Windows.Forms.Label lblLocatieMasa;
        private System.Windows.Forms.TextBox txtLocatieMasa;
        private System.Windows.Forms.Label lblCapacitateMasa;
        private System.Windows.Forms.TextBox txtCapacitateMasa;
        private System.Windows.Forms.ListBox lstMese;
    }
}
