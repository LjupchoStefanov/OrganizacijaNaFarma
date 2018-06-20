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
    public partial class ReprodukcijaForm : Form
    {
        public ReprodukcijaForm()
        {
            InitializeComponent();
        }

        private void Refresh()
        {
            dataGridView1.Rows.Clear();
            DataAcess da = new DataAcess();
            SqlConnection conn = da.getConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * from tblReprodukcija where FMajka = '" + tbSifra.Text + "' order by OsemenuvanjeDatum asc");
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string Zensko = reader["FMajka"].ToString();
                string Masko = reader["MTatko"].ToString();
                string Osemena = reader["OsemenuvanjeDatum"].ToString();
                bool Kontrola = Boolean.Parse(reader["Kontrola"].ToString());
                string Oprasena = reader["OprasuvanjeDatum"].ToString();
                string KontrolaDatum = reader["KontrolaDatum"].ToString();
                float Rodeni = 0;
                if (reader["ZivoRodeniPrasinja"].ToString().Length != 0) Rodeni = float.Parse(reader["ZivoRodeniPrasinja"].ToString());
                float MrtvoRodeni = 0;
                if (reader["MrtvoRodeniPrasinja"].ToString().Length != 0) MrtvoRodeni = float.Parse(reader["MrtvoRodeniPrasinja"].ToString());
                float Nevitalni = 0;
                if (reader["NevitalniPrasinja"].ToString().Length != 0) Nevitalni = float.Parse(reader["NevitalniPrasinja"].ToString());
                string Odbivanje = reader["OdbivanjeDatum"].ToString();
                float OdbieniPrasinja = 0;
                if (reader["OdbieniPrasinja"].ToString() != "") OdbieniPrasinja = float.Parse(reader["OdbieniPrasinja"].ToString());
                int n = dataGridView1.Rows.Add();
                
                dataGridView1.Rows[n].Cells[0].Value = Zensko;
                dataGridView1.Rows[n].Cells[1].Value = Masko;
                dataGridView1.Rows[n].Cells[2].Value = Osemena;
                dataGridView1.Rows[n].Cells[3].Value = KontrolaDatum;
                dataGridView1.Rows[n].Cells[4].Value = Kontrola;
                dataGridView1.Rows[n].Cells[5].Value = Oprasena;
                dataGridView1.Rows[n].Cells[6].Value = Rodeni;
                dataGridView1.Rows[n].Cells[7].Value = MrtvoRodeni;
                dataGridView1.Rows[n].Cells[8].Value = Nevitalni;
                dataGridView1.Rows[n].Cells[9].Value = Odbivanje;
                dataGridView1.Rows[n].Cells[10].Value =OdbieniPrasinja;
                

                //listBox1.Items.Add(new Reproduction(Zensko, Masko, Osemena, Kontrola, KontrolaDatum, Oprasena, Rodeni, MrtvoRodeni, Nevitalni, Odbivanje, OdbieniPrasinja).ToString());
            }
            conn.Close();
        }

        private void buttonDodadi_Click(object sender, EventArgs e)
        {
            ReprodukcijaFormDodadi newForm = new ReprodukcijaFormDodadi();
            if (newForm.ShowDialog() == DialogResult.Yes)
            {
                DataAcess DA = new DataAcess();
                SqlCommand cmd1 = new SqlCommand("Insert Into tblReprodukcija(ID,FMajka,MTatko,OsemenuvanjeDatum,Kontrola) " +
                    "Values(0,N'" + newForm.Reprodukcija.Zensko + "',N'" + newForm.Reprodukcija.Masko + 
                    "',cast('" + newForm.Reprodukcija.Osemena + "' as datetime),'" + newForm.Reprodukcija.Kontrola + "')", DA.getConnection());
                DA.cmdCommand(cmd1);
                Refresh();
            }
        }

        private void buttonIzbrisi_Click(object sender, EventArgs e)
        {
            ReprodukcijaFormIzbrisi newForm = new ReprodukcijaFormIzbrisi();
            if (newForm.ShowDialog() == DialogResult.Yes)
            {
                DataAcess DA = new DataAcess();
                SqlCommand cmd1 = new SqlCommand("Delete from tblReprodukcija Where FMajka = N'" + newForm.Zensko + "' and MTatko = N'" + newForm.Masko + "'and OsemenuvanjeDatum = cast('" + newForm.Osemenuvanje + "' as datetime)", DA.getConnection());
                DA.cmdCommand(cmd1);
                Refresh();
            }
        }

        private void buttonPromeni_Click(object sender, EventArgs e)
        {
                ReprodukcijaFormPromeni newForm = new ReprodukcijaFormPromeni(tbSifra.Text);
                 newForm.ShowDialog();
                 Refresh();
        }

        private void buttonLista_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void tbSifra_TextChanged(object sender, EventArgs e)
        {
            buttonLista.Enabled = true;
            buttonPromeni.Enabled = true;
        }

    }
}
