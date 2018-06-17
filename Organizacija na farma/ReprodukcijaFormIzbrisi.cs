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
    public partial class ReprodukcijaFormIzbrisi : Form
    {
        public string Zensko { get; set; }
        public string Masko { get; set; }
        public string Osemenuvanje { get; set; }
        public ReprodukcijaFormIzbrisi()
        {
            InitializeComponent();
            Zensko = null;
            Masko = null;
            Osemenuvanje = null;
        }

        private void tbZensko_Validating(object sender, CancelEventArgs e)
        {
            if (tbZensko.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(tbZensko, "Внеси шифра на женско");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbZensko, null);
                Zensko = tbZensko.Text;
                e.Cancel = false;
            }
        }

        private void tbMasko_Validating(object sender, CancelEventArgs e)
        {
            if (tbMasko.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(tbMasko, "Внеси шифра на машко");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbMasko, null);
                Masko = tbMasko.Text;
                e.Cancel = false;
            }
        }

        private void mtbDatumOsemenuvanje_Validating(object sender, CancelEventArgs e)
        {
            if (mtbDatumOsemenuvanje.Text.Trim().Length == 6)
            {
                errorProvider1.SetError(mtbDatumOsemenuvanje, "Внеси датум на осеменување");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(mtbDatumOsemenuvanje, null);
                Osemenuvanje = MakeDate.makeDate(mtbDatumOsemenuvanje.Text);
                e.Cancel = false;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
    }
}
