namespace Organizacija_na_farma
{
    partial class ReproductionForm
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
            this.buttonOsemenuvanje = new System.Windows.Forms.Button();
            this.buttonKontrola = new System.Windows.Forms.Button();
            this.buttonOprasuvanje = new System.Windows.Forms.Button();
            this.buttonOdbivanje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOsemenuvanje
            // 
            this.buttonOsemenuvanje.Location = new System.Drawing.Point(22, 13);
            this.buttonOsemenuvanje.Name = "buttonOsemenuvanje";
            this.buttonOsemenuvanje.Size = new System.Drawing.Size(97, 23);
            this.buttonOsemenuvanje.TabIndex = 0;
            this.buttonOsemenuvanje.Text = "Осеменување";
            this.buttonOsemenuvanje.UseVisualStyleBackColor = true;
            this.buttonOsemenuvanje.Click += new System.EventHandler(this.buttonOsemenuvanje_Click);
            // 
            // buttonKontrola
            // 
            this.buttonKontrola.Location = new System.Drawing.Point(22, 66);
            this.buttonKontrola.Name = "buttonKontrola";
            this.buttonKontrola.Size = new System.Drawing.Size(97, 23);
            this.buttonKontrola.TabIndex = 1;
            this.buttonKontrola.Text = "Контрола";
            this.buttonKontrola.UseVisualStyleBackColor = true;
            this.buttonKontrola.Click += new System.EventHandler(this.buttonKontrola_Click);
            // 
            // buttonOprasuvanje
            // 
            this.buttonOprasuvanje.Location = new System.Drawing.Point(22, 124);
            this.buttonOprasuvanje.Name = "buttonOprasuvanje";
            this.buttonOprasuvanje.Size = new System.Drawing.Size(97, 23);
            this.buttonOprasuvanje.TabIndex = 2;
            this.buttonOprasuvanje.Text = "Опрасување";
            this.buttonOprasuvanje.UseVisualStyleBackColor = true;
            this.buttonOprasuvanje.Click += new System.EventHandler(this.buttonOprasuvanje_Click);
            // 
            // buttonOdbivanje
            // 
            this.buttonOdbivanje.Location = new System.Drawing.Point(22, 182);
            this.buttonOdbivanje.Name = "buttonOdbivanje";
            this.buttonOdbivanje.Size = new System.Drawing.Size(97, 23);
            this.buttonOdbivanje.TabIndex = 3;
            this.buttonOdbivanje.Text = "Одбивање";
            this.buttonOdbivanje.UseVisualStyleBackColor = true;
            this.buttonOdbivanje.Click += new System.EventHandler(this.buttonOdbivanje_Click);
            // 
            // ReproductionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonOdbivanje);
            this.Controls.Add(this.buttonOprasuvanje);
            this.Controls.Add(this.buttonKontrola);
            this.Controls.Add(this.buttonOsemenuvanje);
            this.Name = "ReproductionForm";
            this.Text = "ReproductionForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOsemenuvanje;
        private System.Windows.Forms.Button buttonKontrola;
        private System.Windows.Forms.Button buttonOprasuvanje;
        private System.Windows.Forms.Button buttonOdbivanje;
    }
}