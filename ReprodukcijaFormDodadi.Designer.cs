namespace Organizacija_na_farma
{
    partial class ReprodukcijaFormDodadi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbZensko = new System.Windows.Forms.TextBox();
            this.tbMasko = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.mtbDatumOsemenuvanje = new System.Windows.Forms.MaskedTextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Внеси шифра женско";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Внеси шифра машко";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Внеси датум на осеменување";
            // 
            // tbZensko
            // 
            this.tbZensko.Location = new System.Drawing.Point(24, 51);
            this.tbZensko.Name = "tbZensko";
            this.tbZensko.Size = new System.Drawing.Size(100, 20);
            this.tbZensko.TabIndex = 3;
            this.tbZensko.Validating += new System.ComponentModel.CancelEventHandler(this.tbZensko_Validating);
            // 
            // tbMasko
            // 
            this.tbMasko.Location = new System.Drawing.Point(24, 112);
            this.tbMasko.Name = "tbMasko";
            this.tbMasko.Size = new System.Drawing.Size(100, 20);
            this.tbMasko.TabIndex = 4;
            this.tbMasko.Validating += new System.ComponentModel.CancelEventHandler(this.tbMasko_Validating);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(24, 213);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 23);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Зачувај";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // mtbDatumOsemenuvanje
            // 
            this.mtbDatumOsemenuvanje.Location = new System.Drawing.Point(24, 177);
            this.mtbDatumOsemenuvanje.Mask = "00/00/0000";
            this.mtbDatumOsemenuvanje.Name = "mtbDatumOsemenuvanje";
            this.mtbDatumOsemenuvanje.Size = new System.Drawing.Size(100, 20);
            this.mtbDatumOsemenuvanje.TabIndex = 8;
            this.mtbDatumOsemenuvanje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbDatumOsemenuvanje.ValidatingType = typeof(System.DateTime);
            this.mtbDatumOsemenuvanje.Validating += new System.ComponentModel.CancelEventHandler(this.mtbDatumOsemenuvanje_Validating);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(151, 213);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 23);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Откажи";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click_1);
            // 
            // ReprodukcijaFormDodadi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.mtbDatumOsemenuvanje);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.tbMasko);
            this.Controls.Add(this.tbZensko);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReprodukcijaFormDodadi";
            this.Text = "ReprodukcijaFormDodadi";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbZensko;
        private System.Windows.Forms.TextBox tbMasko;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MaskedTextBox mtbDatumOsemenuvanje;
        private System.Windows.Forms.Button buttonCancel;
    }
}