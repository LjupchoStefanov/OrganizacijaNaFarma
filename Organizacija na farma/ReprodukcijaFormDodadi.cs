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
    public partial class ReprodukcijaFormDodadi : Form
    {
        public Reproduction Reprodukcija { get; set; }
        public ReprodukcijaFormDodadi()
        {
            InitializeComponent();
            Reprodukcija = new Reproduction(null, null, null, false, null, null, 0,0,0,null,0);
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
                Reprodukcija.Zensko = tbZensko.Text;
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
                Reprodukcija.Masko = tbMasko.Text;
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
                Reprodukcija.Osemena = MakeDate.makeDate(mtbDatumOsemenuvanje.Text);
                e.Cancel = false;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void buttonCancel_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

    }
}
