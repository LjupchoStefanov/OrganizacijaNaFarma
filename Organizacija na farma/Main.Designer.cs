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
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
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
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(117, 145);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 54);
            this.button4.TabIndex = 3;
            this.button4.Text = "Извештај основен";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(117, 237);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(124, 54);
            this.button5.TabIndex = 4;
            this.button5.Text = "Извештај товеници";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(308, 145);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(124, 54);
            this.button6.TabIndex = 5;
            this.button6.Text = "Задачи";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(308, 237);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(124, 54);
            this.button7.TabIndex = 6;
            this.button7.Text = "Периодичен";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 336);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
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
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}

