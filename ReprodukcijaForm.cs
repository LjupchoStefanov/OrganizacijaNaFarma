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
            }
        }

        private void buttonPromeni_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != null)
            {
                Reproduction reproduction = listBox1.SelectedItem as Reproduction;
                ReprodukcijaFormPromeni newForm = new ReprodukcijaFormPromeni(reproduction);
                if (newForm.ShowDialog() == DialogResult.Yes)
                {
                    DataAcess DA = new DataAcess();
                    SqlCommand cmd1 = new SqlCommand("UPDATE tblReprodukcija SET Kontrola = N'" + newForm.Kontrola + "', OprasuvanjeDatum = N'" + newForm.Oprasena + "', ZivoRodeniPrasinja = N'" + newForm.Rodeni + "', MrtvoRodeniPrasinja = N'" + newForm.MrtvoRodeni + "', NevitalniPrasinja = N'" + newForm.Nevitalni + "', OdbivanjeDatum = N'" + newForm.Odbivanje + "', OdbieniPrasinja = N'" + newForm.OdbieniPrasinja + "' Where FMajka = N'" + newForm.Zensko + "'and MTatko = '" + newForm.Masko + "'and OsemenuvanjeDatum = N'" + newForm.Osemenuvanje + "' ", DA.getConnection());
                    DA.cmdCommand(cmd1);
                }
            }
        }

        private void buttonLista_Click(object sender, EventArgs e)
        {
            DataAcess da = new DataAcess();
            SqlConnection conn = da.getConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * from tblReprodukcija where FMajka = '" + tbSifra.Text + "' order by OsemenuvanjeDatum asc");
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            listBox1.Items.Clear();
            while (reader.Read())
            {
                string Zensko = reader["FMajka"].ToString(); 
                string Masko = reader["MTatko"].ToString();
                string Osemena = reader["OsemenuvanjeDatum"].ToString();
                bool Kontrola = Boolean.Parse(reader["Kontrola"].ToString());
                string Oprasena = reader["OprasuvanjeDatum"].ToString();
                float Rodeni = 0;
                if(reader["ZivoRodeniPrasinja"].ToString() != "") Rodeni = float.Parse(reader["ZivoRodeniPrasinja"].ToString());
                float MrtvoRodeni = 0;
                if(reader["MrtvoRodeniPrasinja"].ToString() != "") MrtvoRodeni = float.Parse(reader["MrtvoRodeniPrasinja"].ToString());
                float Nevitalni = 0;
                if(reader["NevitalniPrasinja"].ToString() != "") Nevitalni = float.Parse(reader["NevitalniPrasinja"].ToString());
                string Odbivanje = reader["OdbivanjeDatum"].ToString();
                float OdbieniPrasinja = 0;
                if(reader["OdbieniPrasinja"].ToString() != "") OdbieniPrasinja = float.Parse(reader["OdbieniPrasinja"].ToString());
                listBox1.Items.Add(new Reproduction(Zensko,Masko,Osemena,Kontrola,Oprasena,Rodeni,MrtvoRodeni,Nevitalni,Odbivanje,OdbieniPrasinja).ToString());
            }
            conn.Close();
        }

        private void tbSifra_TextChanged(object sender, EventArgs e)
        {
            buttonLista.Enabled = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonPromeni.Enabled = true;
        }
    }
}
