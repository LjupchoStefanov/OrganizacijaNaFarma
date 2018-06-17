namespace Organizacija_na_farma
{
    partial class ReprodukcijaForm
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
            this.buttonPromeni = new System.Windows.Forms.Button();
            this.buttonDodadi = new System.Windows.Forms.Button();
            this.buttonIzbrisi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLista = new System.Windows.Forms.Button();
            this.tbSifra = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonPromeni
            // 
            this.buttonPromeni.Enabled = false;
            this.buttonPromeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPromeni.Location = new System.Drawing.Point(939, 399);
            this.buttonPromeni.Name = "buttonPromeni";
            this.buttonPromeni.Size = new System.Drawing.Size(129, 62);
            this.buttonPromeni.TabIndex = 5;
            this.buttonPromeni.Text = "Промени податоци";
            this.buttonPromeni.UseVisualStyleBackColor = true;
            this.buttonPromeni.Click += new System.EventHandler(this.buttonPromeni_Click);
            // 
            // buttonDodadi
            // 
            this.buttonDodadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDodadi.Location = new System.Drawing.Point(938, 256);
            this.buttonDodadi.Name = "buttonDodadi";
            this.buttonDodadi.Size = new System.Drawing.Size(129, 62);
            this.buttonDodadi.TabIndex = 4;
            this.buttonDodadi.Text = "Додади";
            this.buttonDodadi.UseVisualStyleBackColor = true;
            this.buttonDodadi.Click += new System.EventHandler(this.buttonDodadi_Click);
            // 
            // buttonIzbrisi
            // 
            this.buttonIzbrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIzbrisi.Location = new System.Drawing.Point(939, 119);
            this.buttonIzbrisi.Name = "buttonIzbrisi";
            this.buttonIzbrisi.Size = new System.Drawing.Size(129, 62);
            this.buttonIzbrisi.TabIndex = 3;
            this.buttonIzbrisi.Text = "Избриши";
            this.buttonIzbrisi.UseVisualStyleBackColor = true;
            this.buttonIzbrisi.Click += new System.EventHandler(this.buttonIzbrisi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 571);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Внеси шифра";
            // 
            // buttonLista
            // 
            this.buttonLista.Enabled = false;
            this.buttonLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLista.Location = new System.Drawing.Point(246, 570);
            this.buttonLista.Name = "buttonLista";
            this.buttonLista.Size = new System.Drawing.Size(129, 62);
            this.buttonLista.TabIndex = 9;
            this.buttonLista.Text = "Прикажи листа";
            this.buttonLista.UseVisualStyleBackColor = true;
            this.buttonLista.Click += new System.EventHandler(this.buttonLista_Click);
            // 
            // tbSifra
            // 
            this.tbSifra.Location = new System.Drawing.Point(47, 612);
            this.tbSifra.Name = "tbSifra";
            this.tbSifra.Size = new System.Drawing.Size(100, 20);
            this.tbSifra.TabIndex = 10;
            this.tbSifra.TextChanged += new System.EventHandler(this.tbSifra_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(12, 66);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(898, 459);
            this.listBox1.TabIndex = 11;
            // 
            // ReprodukcijaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 665);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tbSifra);
            this.Controls.Add(this.buttonLista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPromeni);
            this.Controls.Add(this.buttonDodadi);
            this.Controls.Add(this.buttonIzbrisi);
            this.Name = "ReprodukcijaForm";
            this.Text = "Reprodukcija";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPromeni;
        private System.Windows.Forms.Button buttonDodadi;
        private System.Windows.Forms.Button buttonIzbrisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLista;
        private System.Windows.Forms.TextBox tbSifra;
        private System.Windows.Forms.ListBox listBox1;
    }
}