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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonPromeni = new System.Windows.Forms.Button();
            this.buttonDodadi = new System.Windows.Forms.Button();
            this.buttonIzbrisi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLista = new System.Windows.Forms.Button();
            this.tbSifra = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Majka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tatko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Osemenuvanje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumKontrola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kontrola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oprasuvanje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZivoRodeni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MrtvoRodeni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nevitalni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OdbivanjeDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OdbieniPrasinja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPromeni
            // 
            this.buttonPromeni.Enabled = false;
            this.buttonPromeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPromeni.Location = new System.Drawing.Point(1029, 388);
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
            this.buttonDodadi.Location = new System.Drawing.Point(1029, 244);
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
            this.buttonIzbrisi.Location = new System.Drawing.Point(1029, 113);
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
            this.label1.Location = new System.Drawing.Point(49, 571);
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
            this.tbSifra.Location = new System.Drawing.Point(58, 612);
            this.tbSifra.Name = "tbSifra";
            this.tbSifra.Size = new System.Drawing.Size(100, 20);
            this.tbSifra.TabIndex = 10;
            this.tbSifra.TextChanged += new System.EventHandler(this.tbSifra_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Majka,
            this.Tatko,
            this.Osemenuvanje,
            this.DatumKontrola,
            this.Kontrola,
            this.Oprasuvanje,
            this.ZivoRodeni,
            this.MrtvoRodeni,
            this.Nevitalni,
            this.OdbivanjeDatum,
            this.OdbieniPrasinja});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.Size = new System.Drawing.Size(994, 524);
            this.dataGridView1.TabIndex = 24;
            // 
            // Majka
            // 
            this.Majka.FillWeight = 40F;
            this.Majka.HeaderText = "Мајка";
            this.Majka.Name = "Majka";
            this.Majka.ReadOnly = true;
            this.Majka.Width = 40;
            // 
            // Tatko
            // 
            this.Tatko.FillWeight = 40F;
            this.Tatko.HeaderText = "Татко";
            this.Tatko.Name = "Tatko";
            this.Tatko.ReadOnly = true;
            this.Tatko.Width = 40;
            // 
            // Osemenuvanje
            // 
            this.Osemenuvanje.FillWeight = 130F;
            this.Osemenuvanje.HeaderText = "Датум на Осеменување";
            this.Osemenuvanje.Name = "Osemenuvanje";
            this.Osemenuvanje.ReadOnly = true;
            this.Osemenuvanje.Width = 130;
            // 
            // DatumKontrola
            // 
            this.DatumKontrola.FillWeight = 130F;
            this.DatumKontrola.HeaderText = "Датум на Контрола";
            this.DatumKontrola.Name = "DatumKontrola";
            this.DatumKontrola.ReadOnly = true;
            this.DatumKontrola.Width = 130;
            // 
            // Kontrola
            // 
            this.Kontrola.FillWeight = 70F;
            this.Kontrola.HeaderText = "Контрола";
            this.Kontrola.Name = "Kontrola";
            this.Kontrola.ReadOnly = true;
            this.Kontrola.Width = 70;
            // 
            // Oprasuvanje
            // 
            this.Oprasuvanje.FillWeight = 130F;
            this.Oprasuvanje.HeaderText = "Датум на Опрасување";
            this.Oprasuvanje.Name = "Oprasuvanje";
            this.Oprasuvanje.ReadOnly = true;
            this.Oprasuvanje.Width = 130;
            // 
            // ZivoRodeni
            // 
            this.ZivoRodeni.FillWeight = 70F;
            this.ZivoRodeni.HeaderText = "Живо Родени Прасиња";
            this.ZivoRodeni.Name = "ZivoRodeni";
            this.ZivoRodeni.ReadOnly = true;
            this.ZivoRodeni.Width = 70;
            // 
            // MrtvoRodeni
            // 
            this.MrtvoRodeni.FillWeight = 70F;
            this.MrtvoRodeni.HeaderText = "Мртво Родени Прасиња";
            this.MrtvoRodeni.Name = "MrtvoRodeni";
            this.MrtvoRodeni.ReadOnly = true;
            this.MrtvoRodeni.Width = 70;
            // 
            // Nevitalni
            // 
            this.Nevitalni.FillWeight = 70F;
            this.Nevitalni.HeaderText = "Невитални";
            this.Nevitalni.Name = "Nevitalni";
            this.Nevitalni.ReadOnly = true;
            this.Nevitalni.Width = 70;
            // 
            // OdbivanjeDatum
            // 
            this.OdbivanjeDatum.FillWeight = 130F;
            this.OdbivanjeDatum.HeaderText = "Датум на Одбивање";
            this.OdbivanjeDatum.Name = "OdbivanjeDatum";
            this.OdbivanjeDatum.ReadOnly = true;
            this.OdbivanjeDatum.Width = 130;
            // 
            // OdbieniPrasinja
            // 
            this.OdbieniPrasinja.FillWeight = 70F;
            this.OdbieniPrasinja.HeaderText = "Одбиени Прасиња";
            this.OdbieniPrasinja.Name = "OdbieniPrasinja";
            this.OdbieniPrasinja.ReadOnly = true;
            this.OdbieniPrasinja.Width = 70;
            // 
            // ReprodukcijaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 665);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbSifra);
            this.Controls.Add(this.buttonLista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPromeni);
            this.Controls.Add(this.buttonDodadi);
            this.Controls.Add(this.buttonIzbrisi);
            this.Name = "ReprodukcijaForm";
            this.Text = "Reprodukcija";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Majka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tatko;
        private System.Windows.Forms.DataGridViewTextBoxColumn Osemenuvanje;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumKontrola;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kontrola;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oprasuvanje;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZivoRodeni;
        private System.Windows.Forms.DataGridViewTextBoxColumn MrtvoRodeni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nevitalni;
        private System.Windows.Forms.DataGridViewTextBoxColumn OdbivanjeDatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn OdbieniPrasinja;
    }
}