﻿namespace Organizacija_na_farma
{
    partial class OSForm
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
            this.buttonIzbrisi = new System.Windows.Forms.Button();
            this.buttonDodadi = new System.Windows.Forms.Button();
            this.buttonPromeni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonIzbrisi
            // 
            this.buttonIzbrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIzbrisi.Location = new System.Drawing.Point(167, 58);
            this.buttonIzbrisi.Name = "buttonIzbrisi";
            this.buttonIzbrisi.Size = new System.Drawing.Size(129, 62);
            this.buttonIzbrisi.TabIndex = 0;
            this.buttonIzbrisi.Text = "Избриши";
            this.buttonIzbrisi.UseVisualStyleBackColor = true;
            this.buttonIzbrisi.Click += new System.EventHandler(this.buttonIzbrisi_Click);
            // 
            // buttonDodadi
            // 
            this.buttonDodadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDodadi.Location = new System.Drawing.Point(12, 58);
            this.buttonDodadi.Name = "buttonDodadi";
            this.buttonDodadi.Size = new System.Drawing.Size(129, 62);
            this.buttonDodadi.TabIndex = 1;
            this.buttonDodadi.Text = "Додади";
            this.buttonDodadi.UseVisualStyleBackColor = true;
            this.buttonDodadi.Click += new System.EventHandler(this.buttonDodadi_Click);
            // 
            // buttonPromeni
            // 
            this.buttonPromeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPromeni.Location = new System.Drawing.Point(326, 58);
            this.buttonPromeni.Name = "buttonPromeni";
            this.buttonPromeni.Size = new System.Drawing.Size(129, 62);
            this.buttonPromeni.TabIndex = 2;
            this.buttonPromeni.Text = "Промени податоци";
            this.buttonPromeni.UseVisualStyleBackColor = true;
            this.buttonPromeni.Click += new System.EventHandler(this.buttonPromeni_Click);
            // 
            // OSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 178);
            this.Controls.Add(this.buttonPromeni);
            this.Controls.Add(this.buttonDodadi);
            this.Controls.Add(this.buttonIzbrisi);
            this.Name = "OSForm";
            this.Text = "Единка";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonIzbrisi;
        private System.Windows.Forms.Button buttonDodadi;
        private System.Windows.Forms.Button buttonPromeni;
    }
}