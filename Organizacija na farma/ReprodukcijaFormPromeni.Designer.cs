namespace Organizacija_na_farma
{
    partial class ReprodukcijaFormPromeni
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
            this.cbKontrola = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbRodeni = new System.Windows.Forms.TextBox();
            this.tbNevitalni = new System.Windows.Forms.TextBox();
            this.tbOdbieni = new System.Windows.Forms.TextBox();
            this.mtbOprasuvanje = new System.Windows.Forms.MaskedTextBox();
            this.mtbOdbivanje = new System.Windows.Forms.MaskedTextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.tbMrtvi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbKontrola
            // 
            this.cbKontrola.AutoSize = true;
            this.cbKontrola.Location = new System.Drawing.Point(30, 32);
            this.cbKontrola.Name = "cbKontrola";
            this.cbKontrola.Size = new System.Drawing.Size(80, 17);
            this.cbKontrola.TabIndex = 0;
            this.cbKontrola.Text = "Контрола?";
            this.cbKontrola.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Датум на опрасување";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Родени";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Датму на одбивање";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Одбиени прасиња";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(373, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Невитални";
            // 
            // tbRodeni
            // 
            this.tbRodeni.Location = new System.Drawing.Point(30, 197);
            this.tbRodeni.Name = "tbRodeni";
            this.tbRodeni.Size = new System.Drawing.Size(100, 20);
            this.tbRodeni.TabIndex = 7;
            // 
            // tbNevitalni
            // 
            this.tbNevitalni.Location = new System.Drawing.Point(352, 119);
            this.tbNevitalni.Name = "tbNevitalni";
            this.tbNevitalni.Size = new System.Drawing.Size(100, 20);
            this.tbNevitalni.TabIndex = 8;
            // 
            // tbOdbieni
            // 
            this.tbOdbieni.Location = new System.Drawing.Point(196, 197);
            this.tbOdbieni.Name = "tbOdbieni";
            this.tbOdbieni.Size = new System.Drawing.Size(100, 20);
            this.tbOdbieni.TabIndex = 9;
            // 
            // mtbOprasuvanje
            // 
            this.mtbOprasuvanje.Location = new System.Drawing.Point(30, 119);
            this.mtbOprasuvanje.Mask = "00/00/0000";
            this.mtbOprasuvanje.Name = "mtbOprasuvanje";
            this.mtbOprasuvanje.Size = new System.Drawing.Size(100, 20);
            this.mtbOprasuvanje.TabIndex = 10;
            this.mtbOprasuvanje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbOprasuvanje.ValidatingType = typeof(System.DateTime);
            // 
            // mtbOdbivanje
            // 
            this.mtbOdbivanje.Location = new System.Drawing.Point(352, 197);
            this.mtbOdbivanje.Mask = "00/00/0000";
            this.mtbOdbivanje.Name = "mtbOdbivanje";
            this.mtbOdbivanje.Size = new System.Drawing.Size(100, 20);
            this.mtbOdbivanje.TabIndex = 11;
            this.mtbOdbivanje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbOdbivanje.ValidatingType = typeof(System.DateTime);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(199, 246);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(113, 23);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Зачувај";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(341, 246);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(118, 23);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Откажи";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(208, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Мртви родени";
            // 
            // tbMrtvi
            // 
            this.tbMrtvi.Location = new System.Drawing.Point(199, 119);
            this.tbMrtvi.Name = "tbMrtvi";
            this.tbMrtvi.Size = new System.Drawing.Size(100, 20);
            this.tbMrtvi.TabIndex = 21;
            // 
            // ReprodukcijaFormPromeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 303);
            this.Controls.Add(this.tbMrtvi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.mtbOdbivanje);
            this.Controls.Add(this.mtbOprasuvanje);
            this.Controls.Add(this.tbOdbieni);
            this.Controls.Add(this.tbNevitalni);
            this.Controls.Add(this.tbRodeni);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbKontrola);
            this.Name = "ReprodukcijaFormPromeni";
            this.Text = "ReprodukcijaFormPromeni";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbKontrola;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbRodeni;
        private System.Windows.Forms.TextBox tbNevitalni;
        private System.Windows.Forms.TextBox tbOdbieni;
        private System.Windows.Forms.MaskedTextBox mtbOprasuvanje;
        private System.Windows.Forms.MaskedTextBox mtbOdbivanje;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox tbMrtvi;
        private System.Windows.Forms.Label label9;
    }
}