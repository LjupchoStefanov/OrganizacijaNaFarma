namespace Organizacija_na_farma
{
    partial class IndividualForm
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
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonDeleteMale = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonUpdateFeMale = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(13, 31);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(75, 23);
            this.buttonNew.TabIndex = 0;
            this.buttonNew.Text = "Нов Внес";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonDeleteMale
            // 
            this.buttonDeleteMale.Location = new System.Drawing.Point(12, 102);
            this.buttonDeleteMale.Name = "buttonDeleteMale";
            this.buttonDeleteMale.Size = new System.Drawing.Size(106, 23);
            this.buttonDeleteMale.TabIndex = 1;
            this.buttonDeleteMale.Text = "Избриши машко";
            this.buttonDeleteMale.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(166, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Избриши женско";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateFeMale
            // 
            this.buttonUpdateFeMale.Location = new System.Drawing.Point(166, 31);
            this.buttonUpdateFeMale.Name = "buttonUpdateFeMale";
            this.buttonUpdateFeMale.Size = new System.Drawing.Size(106, 23);
            this.buttonUpdateFeMale.TabIndex = 3;
            this.buttonUpdateFeMale.Text = "Смени Маторица";
            this.buttonUpdateFeMale.UseVisualStyleBackColor = true;
            // 
            // IndividualForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonUpdateFeMale);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonDeleteMale);
            this.Controls.Add(this.buttonNew);
            this.Name = "IndividualForm";
            this.Text = "IndividualForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonDeleteMale;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonUpdateFeMale;
    }
}