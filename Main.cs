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
    public partial class Main : Form
    {
        public List<int> s;
        public Main()
        {
            InitializeComponent();
        }

        private void buttonIndividual_Click(object sender, EventArgs e)
        {
            OSForm OSForm= new OSForm();
            OSForm.Show();
        }

        private void buttonReproduction_Click(object sender, EventArgs e)
        {
            ReprodukcijaForm reprodukcija = new ReprodukcijaForm();
            reprodukcija.Show();
        }

        private void buttonMovment_Click(object sender, EventArgs e)
        {
            DvizenjeForm dvizenje = new DvizenjeForm();
            dvizenje.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
