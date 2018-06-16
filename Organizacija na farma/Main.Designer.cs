namespace Organizacija_na_farma
{
    partial class Main
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
            this.buttonIndividual = new System.Windows.Forms.Button();
            this.buttonReproduction = new System.Windows.Forms.Button();
            this.buttonMovment = new System.Windows.Forms.Button();
            this.buttonOsnoven = new System.Windows.Forms.Button();
            this.buttonTovenici = new System.Windows.Forms.Button();
            this.buttonZadaci = new System.Windows.Forms.Button();
            this.buttonPeriodicen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonIndividual
            // 
            this.buttonIndividual.Location = new System.Drawing.Point(31, 40);
            this.buttonIndividual.Name = "buttonIndividual";
            this.buttonIndividual.Size = new System.Drawing.Size(141, 56);
            this.buttonIndividual.TabIndex = 0;
            this.buttonIndividual.Text = "Единка";
            this.buttonIndividual.UseVisualStyleBackColor = true;
            this.buttonIndividual.Click += new System.EventHandler(this.buttonIndividual_Click);
            // 
            // buttonReproduction
            // 
            this.buttonReproduction.Location = new System.Drawing.Point(200, 40);
            this.buttonReproduction.Name = "buttonReproduction";
            this.buttonReproduction.Size = new System.Drawing.Size(144, 56);
            this.buttonReproduction.TabIndex = 1;
            this.buttonReproduction.Text = "Репродукција";
            this.buttonReproduction.UseVisualStyleBackColor = true;
            this.buttonReproduction.Click += new System.EventHandler(this.buttonReproduction_Click);
            // 
            // buttonMovment
            // 
            this.buttonMovment.Location = new System.Drawing.Point(374, 40);
            this.buttonMovment.Name = "buttonMovment";
            this.buttonMovment.Size = new System.Drawing.Size(141, 56);
            this.buttonMovment.TabIndex = 2;
            this.buttonMovment.Text = "Движење";
            this.buttonMovment.UseVisualStyleBackColor = true;
            this.buttonMovment.Click += new System.EventHandler(this.buttonMovment_Click);
            // 
            // buttonOsnoven
            // 
            this.buttonOsnoven.Location = new System.Drawing.Point(117, 145);
            this.buttonOsnoven.Name = "buttonOsnoven";
            this.buttonOsnoven.Size = new System.Drawing.Size(124, 54);
            this.buttonOsnoven.TabIndex = 3;
            this.buttonOsnoven.Text = "Извештај основен";
            this.buttonOsnoven.UseVisualStyleBackColor = true;
            // 
            // buttonTovenici
            // 
            this.buttonTovenici.Location = new System.Drawing.Point(117, 237);
            this.buttonTovenici.Name = "buttonTovenici";
            this.buttonTovenici.Size = new System.Drawing.Size(124, 54);
            this.buttonTovenici.TabIndex = 4;
            this.buttonTovenici.Text = "Извештај товеници";
            this.buttonTovenici.UseVisualStyleBackColor = true;
            // 
            // buttonZadaci
            // 
            this.buttonZadaci.Location = new System.Drawing.Point(308, 145);
            this.buttonZadaci.Name = "buttonZadaci";
            this.buttonZadaci.Size = new System.Drawing.Size(124, 54);
            this.buttonZadaci.TabIndex = 5;
            this.buttonZadaci.Text = "Задачи";
            this.buttonZadaci.UseVisualStyleBackColor = true;
            // 
            // buttonPeriodicen
            // 
            this.buttonPeriodicen.Location = new System.Drawing.Point(308, 237);
            this.buttonPeriodicen.Name = "buttonPeriodicen";
            this.buttonPeriodicen.Size = new System.Drawing.Size(124, 54);
            this.buttonPeriodicen.TabIndex = 6;
            this.buttonPeriodicen.Text = "Периодичен";
            this.buttonPeriodicen.UseVisualStyleBackColor = true;
            this.buttonPeriodicen.Click += new System.EventHandler(this.button7_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 336);
            this.Controls.Add(this.buttonPeriodicen);
            this.Controls.Add(this.buttonZadaci);
            this.Controls.Add(this.buttonTovenici);
            this.Controls.Add(this.buttonOsnoven);
            this.Controls.Add(this.buttonMovment);
            this.Controls.Add(this.buttonReproduction);
            this.Controls.Add(this.buttonIndividual);
            this.Name = "Main";
            this.Text = "Организација на фарма";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonIndividual;
        private System.Windows.Forms.Button buttonReproduction;
        private System.Windows.Forms.Button buttonMovment;
        private System.Windows.Forms.Button buttonOsnoven;
        private System.Windows.Forms.Button buttonTovenici;
        private System.Windows.Forms.Button buttonZadaci;
        private System.Windows.Forms.Button buttonPeriodicen;
    }
}

