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
    public partial class ReproductionForm : Form
    {
        public ReproductionForm()
        {
            InitializeComponent();
        }

        private void buttonOsemenuvanje_Click(object sender, EventArgs e)
        {
            OsemenuvajeForm osemenuvanje = new OsemenuvajeForm();
            osemenuvanje.Show();
        }

        private void buttonKontrola_Click(object sender, EventArgs e)
        {
            ControlForm kontrola = new ControlForm();
            kontrola.Show();
        }

        private void buttonOprasuvanje_Click(object sender, EventArgs e)
        {
            OprasuvanjeForm oprasuvanje = new OprasuvanjeForm();
            oprasuvanje.Show();
        }

        private void buttonOdbivanje_Click(object sender, EventArgs e)
        {
            OdbivanjeForm odbivanje = new OdbivanjeForm();
            odbivanje.Show();
        }
    }
}
