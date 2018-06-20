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
    public partial class OSFormPromeni : Form
    {
        public string Datum { get; set; }
        public bool Aktivno { get; set; }
        public string Code { get; set; }
        public OSFormPromeni()
        {
            InitializeComponent();
            Datum = null;
            Aktivno = true;
            Code = null; 
        }

        private void tbCode_Validating(object sender, CancelEventArgs e)
        {
            if (tbCode.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(tbCode, "Внеси шифра");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbCode, null);
                Code = tbCode.Text;
                e.Cancel = false;
            }
        }

        private void mtbDatum_Validating(object sender, CancelEventArgs e)
        {
            if (mtbDatum.Text.Trim().Length != 10)
            {
                errorProvider1.SetError(mtbDatum, "Внеси датум");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(mtbDatum, null);
                Datum = MakeDate.makeDate(mtbDatum.Text);
                Aktivno = false;
                e.Cancel = false;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (tbCode.Text.Length != 0 && mtbDatum.Text.Length == 10) DialogResult = DialogResult.Yes;
            else MessageBox.Show("Внеси ги сите податоци!");
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

    }
}
