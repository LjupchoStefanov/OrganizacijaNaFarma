namespace Organizacija_na_farma
{
    partial class DvizenjeFormDodadi
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
            this.label4 = new System.Windows.Forms.Label();
            this.tbSkladiste = new System.Windows.Forms.TextBox();
            this.tbVid = new System.Windows.Forms.TextBox();
            this.tbPriem = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.mtbDatum = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Складиште";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вид на движење";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Датум";
            // 
            // tbSkladiste
            // 
            this.tbSkladiste.Location = new System.Drawing.Point(26, 58);
            this.tbSkladiste.Name = "tbSkladiste";
            this.tbSkladiste.Size = new System.Drawing.Size(100, 20);
            this.tbSkladiste.TabIndex = 4;
            this.tbSkladiste.Validating += new System.ComponentModel.CancelEventHandler(this.tbSkladiste_Validating);
            // 
            // tbVid
            // 
            this.tbVid.Location = new System.Drawing.Point(26, 128);
            this.tbVid.Name = "tbVid";
            this.tbVid.Size = new System.Drawing.Size(100, 20);
            this.tbVid.TabIndex = 5;
            this.tbVid.Validating += new System.ComponentModel.CancelEventHandler(this.tbVid_Validating);
            // 
            // tbPriem
            // 
            this.tbPriem.Location = new System.Drawing.Point(186, 58);
            this.tbPriem.Name = "tbPriem";
            this.tbPriem.Size = new System.Drawing.Size(100, 20);
            this.tbPriem.TabIndex = 6;
            this.tbPriem.Validating += new System.ComponentModel.CancelEventHandler(this.tbPriem_Validating);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(26, 186);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(120, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Зачувај";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(166, 186);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(120, 23);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Откажи";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Прием";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // mtbDatum
            // 
            this.mtbDatum.Location = new System.Drawing.Point(186, 128);
            this.mtbDatum.Mask = "00/00/0000";
            this.mtbDatum.Name = "mtbDatum";
            this.mtbDatum.Size = new System.Drawing.Size(100, 20);
            this.mtbDatum.TabIndex = 11;
            this.mtbDatum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbDatum.ValidatingType = typeof(System.DateTime);
            this.mtbDatum.Validating += new System.ComponentModel.CancelEventHandler(this.mtbDatum_Validating);
            // 
            // DvizenjeFormDodadi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 227);
            this.Controls.Add(this.mtbDatum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.tbPriem);
            this.Controls.Add(this.tbVid);
            this.Controls.Add(this.tbSkladiste);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DvizenjeFormDodadi";
            this.Text = "DvizenjeFormDodadi";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSkladiste;
        private System.Windows.Forms.TextBox tbVid;
        private System.Windows.Forms.TextBox tbPriem;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.MaskedTextBox mtbDatum;
    }
}