namespace Organizacija_na_farma
{
    partial class OSFormDodadi
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
            this.components = new System.ComponentModel.Container();
            this.Naziv = new System.Windows.Forms.Label();
            this.Pol = new System.Windows.Forms.Label();
            this.Vid = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Majka = new System.Windows.Forms.Label();
            this.Tatko = new System.Windows.Forms.Label();
            this.BabaMajka = new System.Windows.Forms.Label();
            this.DedoMajka = new System.Windows.Forms.Label();
            this.BabaTatko = new System.Windows.Forms.Label();
            this.DedoTatko = new System.Windows.Forms.Label();
            this.DataRaganje = new System.Windows.Forms.Label();
            this.TBNaziv = new System.Windows.Forms.TextBox();
            this.TBPol = new System.Windows.Forms.TextBox();
            this.TBVid = new System.Windows.Forms.TextBox();
            this.TBMajka = new System.Windows.Forms.TextBox();
            this.TBTatko = new System.Windows.Forms.TextBox();
            this.TBBabaMajka = new System.Windows.Forms.TextBox();
            this.TBDedoMajka = new System.Windows.Forms.TextBox();
            this.TBBabaTatko = new System.Windows.Forms.TextBox();
            this.TBDedoTatko = new System.Windows.Forms.TextBox();
            this.MTBDatum = new System.Windows.Forms.MaskedTextBox();
            this.Save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFMajka = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Naziv
            // 
            this.Naziv.AutoSize = true;
            this.Naziv.Location = new System.Drawing.Point(23, 51);
            this.Naziv.Name = "Naziv";
            this.Naziv.Size = new System.Drawing.Size(39, 13);
            this.Naziv.TabIndex = 0;
            this.Naziv.Text = "Назив";
            // 
            // Pol
            // 
            this.Pol.AutoSize = true;
            this.Pol.Location = new System.Drawing.Point(23, 131);
            this.Pol.Name = "Pol";
            this.Pol.Size = new System.Drawing.Size(27, 13);
            this.Pol.TabIndex = 1;
            this.Pol.Text = "Пол";
            // 
            // Vid
            // 
            this.Vid.AutoSize = true;
            this.Vid.Location = new System.Drawing.Point(23, 174);
            this.Vid.Name = "Vid";
            this.Vid.Size = new System.Drawing.Size(26, 13);
            this.Vid.TabIndex = 2;
            this.Vid.Text = "Вид";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Внесување на нова индивидуа";
            // 
            // Majka
            // 
            this.Majka.AutoSize = true;
            this.Majka.Location = new System.Drawing.Point(23, 217);
            this.Majka.Name = "Majka";
            this.Majka.Size = new System.Drawing.Size(36, 13);
            this.Majka.TabIndex = 4;
            this.Majka.Text = "Мајка";
            // 
            // Tatko
            // 
            this.Tatko.AutoSize = true;
            this.Tatko.Location = new System.Drawing.Point(23, 263);
            this.Tatko.Name = "Tatko";
            this.Tatko.Size = new System.Drawing.Size(37, 13);
            this.Tatko.TabIndex = 5;
            this.Tatko.Text = "Татко";
            // 
            // BabaMajka
            // 
            this.BabaMajka.AutoSize = true;
            this.BabaMajka.Location = new System.Drawing.Point(322, 52);
            this.BabaMajka.Name = "BabaMajka";
            this.BabaMajka.Size = new System.Drawing.Size(83, 13);
            this.BabaMajka.TabIndex = 6;
            this.BabaMajka.Text = "Мајка на Мајка";
            // 
            // DedoMajka
            // 
            this.DedoMajka.AutoSize = true;
            this.DedoMajka.Location = new System.Drawing.Point(321, 90);
            this.DedoMajka.Name = "DedoMajka";
            this.DedoMajka.Size = new System.Drawing.Size(84, 13);
            this.DedoMajka.TabIndex = 7;
            this.DedoMajka.Text = "Татко на Мајка";
            // 
            // BabaTatko
            // 
            this.BabaTatko.AutoSize = true;
            this.BabaTatko.Location = new System.Drawing.Point(321, 133);
            this.BabaTatko.Name = "BabaTatko";
            this.BabaTatko.Size = new System.Drawing.Size(84, 13);
            this.BabaTatko.TabIndex = 8;
            this.BabaTatko.Text = "Мајка на Татко";
            // 
            // DedoTatko
            // 
            this.DedoTatko.AutoSize = true;
            this.DedoTatko.Location = new System.Drawing.Point(322, 177);
            this.DedoTatko.Name = "DedoTatko";
            this.DedoTatko.Size = new System.Drawing.Size(85, 13);
            this.DedoTatko.TabIndex = 9;
            this.DedoTatko.Text = "Татко на Татко";
            // 
            // DataRaganje
            // 
            this.DataRaganje.AutoSize = true;
            this.DataRaganje.Location = new System.Drawing.Point(322, 220);
            this.DataRaganje.Name = "DataRaganje";
            this.DataRaganje.Size = new System.Drawing.Size(97, 13);
            this.DataRaganje.TabIndex = 10;
            this.DataRaganje.Text = "Датум на раѓање";
            // 
            // TBNaziv
            // 
            this.TBNaziv.Location = new System.Drawing.Point(89, 49);
            this.TBNaziv.Name = "TBNaziv";
            this.TBNaziv.Size = new System.Drawing.Size(100, 20);
            this.TBNaziv.TabIndex = 11;
            this.TBNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.TBNaziv_Validating);
            // 
            // TBPol
            // 
            this.TBPol.Location = new System.Drawing.Point(89, 130);
            this.TBPol.Name = "TBPol";
            this.TBPol.Size = new System.Drawing.Size(100, 20);
            this.TBPol.TabIndex = 12;
            this.TBPol.Validating += new System.ComponentModel.CancelEventHandler(this.TBPol_Validating);
            // 
            // TBVid
            // 
            this.TBVid.Location = new System.Drawing.Point(89, 173);
            this.TBVid.Name = "TBVid";
            this.TBVid.Size = new System.Drawing.Size(100, 20);
            this.TBVid.TabIndex = 13;
            this.TBVid.Validating += new System.ComponentModel.CancelEventHandler(this.TBVid_Validating);
            // 
            // TBMajka
            // 
            this.TBMajka.Location = new System.Drawing.Point(89, 217);
            this.TBMajka.Name = "TBMajka";
            this.TBMajka.Size = new System.Drawing.Size(100, 20);
            this.TBMajka.TabIndex = 14;
            this.TBMajka.Validating += new System.ComponentModel.CancelEventHandler(this.TBMajka_Validating);
            // 
            // TBTatko
            // 
            this.TBTatko.Location = new System.Drawing.Point(89, 261);
            this.TBTatko.Name = "TBTatko";
            this.TBTatko.Size = new System.Drawing.Size(100, 20);
            this.TBTatko.TabIndex = 15;
            this.TBTatko.Validating += new System.ComponentModel.CancelEventHandler(this.TBTatko_Validating);
            // 
            // TBBabaMajka
            // 
            this.TBBabaMajka.Location = new System.Drawing.Point(441, 49);
            this.TBBabaMajka.Name = "TBBabaMajka";
            this.TBBabaMajka.Size = new System.Drawing.Size(100, 20);
            this.TBBabaMajka.TabIndex = 16;
            this.TBBabaMajka.Validating += new System.ComponentModel.CancelEventHandler(this.TBBabaMajka_Validating);
            // 
            // TBDedoMajka
            // 
            this.TBDedoMajka.Location = new System.Drawing.Point(441, 88);
            this.TBDedoMajka.Name = "TBDedoMajka";
            this.TBDedoMajka.Size = new System.Drawing.Size(100, 20);
            this.TBDedoMajka.TabIndex = 17;
            this.TBDedoMajka.Validating += new System.ComponentModel.CancelEventHandler(this.TBDedoMajka_Validating);
            // 
            // TBBabaTatko
            // 
            this.TBBabaTatko.Location = new System.Drawing.Point(441, 131);
            this.TBBabaTatko.Name = "TBBabaTatko";
            this.TBBabaTatko.Size = new System.Drawing.Size(100, 20);
            this.TBBabaTatko.TabIndex = 18;
            this.TBBabaTatko.Validating += new System.ComponentModel.CancelEventHandler(this.TBBabaTatko_Validating);
            // 
            // TBDedoTatko
            // 
            this.TBDedoTatko.Location = new System.Drawing.Point(441, 174);
            this.TBDedoTatko.Name = "TBDedoTatko";
            this.TBDedoTatko.Size = new System.Drawing.Size(100, 20);
            this.TBDedoTatko.TabIndex = 19;
            this.TBDedoTatko.Validating += new System.ComponentModel.CancelEventHandler(this.TBDedoTatko_Validating);
            // 
            // MTBDatum
            // 
            this.MTBDatum.Location = new System.Drawing.Point(441, 217);
            this.MTBDatum.Mask = "00/00/0000";
            this.MTBDatum.Name = "MTBDatum";
            this.MTBDatum.Size = new System.Drawing.Size(100, 20);
            this.MTBDatum.TabIndex = 20;
            this.MTBDatum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MTBDatum.ValidatingType = typeof(System.DateTime);
            this.MTBDatum.Validating += new System.ComponentModel.CancelEventHandler(this.MTBDatum_Validating);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(302, 277);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(110, 32);
            this.Save.TabIndex = 21;
            this.Save.Text = "Зачувај";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "ФМајка";
            // 
            // textBoxFMajka
            // 
            this.textBoxFMajka.Location = new System.Drawing.Point(89, 88);
            this.textBoxFMajka.Name = "textBoxFMajka";
            this.textBoxFMajka.Size = new System.Drawing.Size(100, 20);
            this.textBoxFMajka.TabIndex = 24;
            this.textBoxFMajka.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxFMajka_Validating);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(475, 277);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(110, 32);
            this.Cancel.TabIndex = 25;
            this.Cancel.Text = "Откажи";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // OSFormDodadi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 340);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.textBoxFMajka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.MTBDatum);
            this.Controls.Add(this.TBDedoTatko);
            this.Controls.Add(this.TBBabaTatko);
            this.Controls.Add(this.TBDedoMajka);
            this.Controls.Add(this.TBBabaMajka);
            this.Controls.Add(this.TBTatko);
            this.Controls.Add(this.TBMajka);
            this.Controls.Add(this.TBVid);
            this.Controls.Add(this.TBPol);
            this.Controls.Add(this.TBNaziv);
            this.Controls.Add(this.DataRaganje);
            this.Controls.Add(this.DedoTatko);
            this.Controls.Add(this.BabaTatko);
            this.Controls.Add(this.DedoMajka);
            this.Controls.Add(this.BabaMajka);
            this.Controls.Add(this.Tatko);
            this.Controls.Add(this.Majka);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Vid);
            this.Controls.Add(this.Pol);
            this.Controls.Add(this.Naziv);
            this.Name = "OSFormDodadi";
            this.Text = "Додавање";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Naziv;
        private System.Windows.Forms.Label Pol;
        private System.Windows.Forms.Label Vid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Majka;
        private System.Windows.Forms.Label Tatko;
        private System.Windows.Forms.Label BabaMajka;
        private System.Windows.Forms.Label DedoMajka;
        private System.Windows.Forms.Label BabaTatko;
        private System.Windows.Forms.Label DedoTatko;
        private System.Windows.Forms.Label DataRaganje;
        private System.Windows.Forms.TextBox TBNaziv;
        private System.Windows.Forms.TextBox TBPol;
        private System.Windows.Forms.TextBox TBVid;
        private System.Windows.Forms.TextBox TBMajka;
        private System.Windows.Forms.TextBox TBTatko;
        private System.Windows.Forms.TextBox TBBabaMajka;
        private System.Windows.Forms.TextBox TBDedoMajka;
        private System.Windows.Forms.TextBox TBBabaTatko;
        private System.Windows.Forms.TextBox TBDedoTatko;
        private System.Windows.Forms.MaskedTextBox MTBDatum;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox textBoxFMajka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}