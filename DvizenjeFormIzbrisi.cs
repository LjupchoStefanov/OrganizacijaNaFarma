using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organizacija_na_farma
{
    public partial class DvizenjeFormIzbrisi : Form
    {
        public string Skladiste { get; set; }
        public int Priem { get; set; }
        public string VidDvizenje { get; set; }
        public string Datum { get; set; }
        public DvizenjeFormIzbrisi()
        {
            InitializeComponent();
            Skladiste = null;
            Priem = 0;
            VidDvizenje = null;
            Datum = null;
        }
        public String makeDate(String date)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(date.Substring(6, 4));
            sb.Append(date.Substring(3, 2));
            sb.Append(date.Substring(0, 2));

            return sb.ToString();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private void tbSkladiste_Validating(object sender, CancelEventArgs e)
        {
            if (tbSkladiste.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(tbSkladiste, "Внеси складиште");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbSkladiste, null);
                Skladiste = tbSkladiste.Text;
                e.Cancel = false;
            }
        }

        private void tbVid_Validating(object sender, CancelEventArgs e)
        {
            if (tbVid.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(tbVid, "Внеси вид");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbVid, null);
                VidDvizenje = tbVid.Text;
                e.Cancel = false;
            }
        }

        private void tbPriem_Validating(object sender, CancelEventArgs e)
        {
            if (tbPriem.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(tbPriem, "Внеси прием");
                e.Cancel = true;
            }
            else
            {
                string sh = tbPriem.Text.Trim();
                foreach (char c in sh)
                {
                    if (!Char.IsDigit(c))
                    {
                        errorProvider1.SetError(tbPriem, "Внеси цифри!");
                        e.Cancel = true;
                        return;
                    }
                }
                errorProvider1.SetError(tbPriem, null);
                Priem = int.Parse(tbPriem.Text);
                e.Cancel = false;
            }
        }

        private void mtbDatum_Validating(object sender, CancelEventArgs e)
        {
            if (mtbDatum.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(mtbDatum, "Внеси датум");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(mtbDatum, null);
                Datum = makeDate(mtbDatum.Text);
                e.Cancel = false;
            }
        }
    }
}
