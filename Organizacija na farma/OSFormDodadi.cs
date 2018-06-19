using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organizacija_na_farma
{

    public partial class OSFormDodadi : Form
    {
        public OS OS { get; set; }
        public OSFormDodadi()
        {
            InitializeComponent();
            OS = new OS(null,null,null,null,null,null,null,null,null,null,null);
        }

        private void TBNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (TBNaziv.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(TBNaziv, "Внеси назив");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(TBNaziv, null);
                OS.Naziv = TBNaziv.Text;
                e.Cancel = false;
            }
        }

        private void textBoxFMajka_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxFMajka.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(textBoxFMajka, "Внеси шифра");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBoxFMajka, null);
                OS.Sifra = TBNaziv.Text;
                e.Cancel = false;
            }
        }
        
       private void TBVid_Validating(object sender, CancelEventArgs e)
        {
            if (TBVid.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(TBVid, "Внеси вид");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(TBVid, null);
                OS.Vid = TBVid.Text;
                e.Cancel = false;
            }
        }
 
        private void TBMajka_Validating(object sender, CancelEventArgs e)
        {
            if (TBMajka.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(TBMajka, "Внеси мајка");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(TBMajka, null);
                OS.Majka = TBVid.Text;
                e.Cancel = false;
            }
        }

        private void TBTatko_Validating(object sender, CancelEventArgs e)
        {
            if (TBTatko.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(TBTatko, "Внеси татко");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(TBTatko, null);
                OS.Tatko = TBVid.Text;
                e.Cancel = false;
            }
        }

        private void TBBabaMajka_Validating(object sender, CancelEventArgs e)
        {
            if (TBBabaMajka.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(TBBabaMajka, "Внеси мајка од мајка");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(TBBabaMajka, null);
                OS.BabaMajka = TBVid.Text;
                e.Cancel = false;
            }
        }

        private void TBDedoMajka_Validating(object sender, CancelEventArgs e)
        {
            if (TBDedoMajka.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(TBDedoMajka, "Внеси дедо од мајка");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(TBDedoMajka, null);
                OS.DedoMajka = TBVid.Text;
                e.Cancel = false;
            }
        }

        private void TBBabaTatko_Validating(object sender, CancelEventArgs e)
        {
            if (TBBabaTatko.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(TBBabaTatko, "Внеси мајка од татко");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(TBBabaTatko, null);
                OS.BabaTatko = TBVid.Text;
                e.Cancel = false;
            }
        }

        private void TBDedoTatko_Validating(object sender, CancelEventArgs e)
        {
            if (TBDedoTatko.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(TBDedoTatko, "Внеси дедо од татко");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(TBDedoTatko, null);
                OS.DedoTatko = TBVid.Text;
                e.Cancel = false;
            }
        }

        private void MTBDatum_Validating(object sender, CancelEventArgs e)
        {
            if (MTBDatum.Text.Trim().Length != 10)
            {
                errorProvider1.SetError(MTBDatum, "Внеси датум");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(MTBDatum, null);
                OS.BirthDate = MakeDate.makeDate(MTBDatum.Text); ;
                e.Cancel = false;
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (TBNaziv.Text.Trim().Length != 0 && textBoxFMajka.Text.Trim().Length != 0 && TBVid.Text.Trim().Length != 0 && TBMajka.Text.Trim().Length != 0 && TBTatko.Text.Trim().Length != 0 && TBBabaMajka.Text.Trim().Length != 0 && TBDedoMajka.Text.Trim().Length != 0 && TBBabaTatko.Text.Trim().Length != 0 && TBDedoTatko.Text.Trim().Length != 0 && MTBDatum.Text.Trim().Length == 10 && comboBox1.SelectedIndex != -1) DialogResult = DialogResult.Yes;
            else
            {
                MessageBox.Show("Внеси ги сите податоци!");
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                errorProvider1.SetError(comboBox1, "Внеси пол");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(comboBox1, null);
                OS.Gender = comboBox1.SelectedItem.ToString();
                e.Cancel = false;
            }
        }
    }
}
