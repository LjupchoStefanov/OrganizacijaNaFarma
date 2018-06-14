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
            OSForm individualForm = new OSForm();
            individualForm.Show();
        }

        private void buttonReproduction_Click(object sender, EventArgs e)
        {
            //ReproductionForm reprodukcija = new ReproductionForm();
            //reprodukcija.Show();
        }

        private void buttonMovment_Click(object sender, EventArgs e)
        {
            //DvizenjeForm dvizenje = new DvizenjeForm();
            //dvizenje.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataAcess DA = new DataAcess();
            SqlConnection conn = DA.getConnection();

            SqlCommand cmd1 = new SqlCommand("INSERT INTO tblDvizenje(ID, Skladiste, VidDvizenje, Priem) VALUES(15055, N'Прасилиштеt', N'Попис', 20)", conn);
            SqlCommand cmd2 = new SqlCommand("UPDATE tblDvizenje SET Datum = cast('20181220' as datetime) Where ID = 15055", conn);
            SqlCommand cmd = new SqlCommand("SELECT Skladiste FROM [Farma].[dbo].[tblDvizenje] WHERE ID = 15055", conn);
            DA.cmdInesrt(cmd1);
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            IzvestajZadaci zadaci = new IzvestajZadaci();
            zadaci.Show();
        }
    }
}
