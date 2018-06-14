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
    public partial class OSFormIzbrisi : Form
    {
        public string Code { get; set; }
        public OSFormIzbrisi()
        {
            InitializeComponent();
            Code = null;
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (tbCode.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(tbCode, "Внеси шифра");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbCode, null);
                e.Cancel = false;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Code = tbCode.Text;
            DialogResult = DialogResult.Yes;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
    }
}
