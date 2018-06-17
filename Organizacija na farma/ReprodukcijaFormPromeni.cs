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
    public partial class ReprodukcijaFormPromeni : Form
    {
        public string Zensko { get; set; }
        public string Masko { get; set; }
        public string Osemena { get; set; }
        public bool Kontrola { get; set; }
        public string Oprasena { get; set; }
        public float Rodeni { get; set; }
        public float MrtvoRodeni { get; set; }
        public float Nevitalni { get; set; }
        public string Odbivanje { get; set; }
        public float OdbieniPrasinja { get; set; }

        public ReprodukcijaFormPromeni(String zensko)
        {
            InitializeComponent();
            //select* from tblReprodukcija Where FMajka = '1182' order by OsemenuvanjeDatum desc
            DataAcess da = new DataAcess();
            SqlConnection conn = da.getConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select Top 1 * from tblReprodukcija Where FMajka = '" + zensko +"' order by OsemenuvanjeDatum desc");
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Zensko = reader["Fmajka"].ToString();
                tbZensko.Text = reader["FMajka"].ToString();
                Masko = reader["Mtatko"].ToString();
                tbMasko.Text = reader["Mtatko"].ToString();
                Osemena = reader["OsemenuvanjeDatum"].ToString();
                tbDatumOsemenuvanje.Text = reader["OsemenuvanjeDatum"].ToString();
                if(reader["KontrolaDatum"].ToString().Length != 0)
                {
                    textBox1.Text = reader["KontrolaDatum"].ToString();
                    comboBox1.Text = "Да";
                        if(reader["OprasuvanjeDatum"].ToString().Length != 0)
                        {
                                 textBox2.Text = reader["OprasuvanjeDatum"].ToString();
                                 numericUpDown1.Value = decimal.Parse(reader["ZivoRodeniPrasinja"].ToString());
                                 numericUpDown2.Value = decimal.Parse(reader["MrtvoRodeniPrasinja"].ToString());
                                 numericUpDown3.Value = decimal.Parse(reader["NevitalniPrasnija"].ToString());
                                /*if (reader["OdbivanjeDatum"].ToString().Length != 0)
                                {
                                    textBox3.Text = reader["OprasuvanjeDatum"].ToString();
                                    numericUpDown4.Value = int.Parse(reader["OdbieniPrasinja"].ToString());
                                }
                                else
                                {
                                    mtbDatumOdbivanje.Enabled = true;
                                    numericUpDown4.Enabled = true;
                                }*/
                           
                        }
                        else
                        {
                            mtbDatumOprasuvanje.Enabled = true;
                            numericUpDown1.Enabled = true;
                            numericUpDown2.Enabled = true;
                            numericUpDown3.Enabled = true;
                        }
                    }
                else
                {
                    mtbDatumKontrola.Enabled = true;
                    comboBox1.Enabled = true;
                }
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAcess DA = new DataAcess();
            if (mtbDatumKontrola.Enabled)
            {
                SqlCommand cmd1 = new SqlCommand("UPDATE tblReprodukcija SET KontrolaDatum = cast('" + MakeDate.makeDate(mtbDatumKontrola.Text) + "' as datetime)  Where FMajka = N'" + tbZensko.Text + "' and MTatko = N'" + tbMasko.Text + "'and OsemenuvanjeDatum = cast('" + tbDatumOsemenuvanje.Text + "' as datetime)", DA.getConnection());
                DA.cmdCommand(cmd1);
                if (comboBox1.SelectedIndex != -1)
                {
                    cmd1 = new SqlCommand("UPDATE tblReprodukcija SET Kontrola = '1' Where FMajka = N'" + tbZensko.Text + "' and MTatko = N'" + tbMasko.Text + "'and OsemenuvanjeDatum = cast('" + tbDatumOsemenuvanje.Text + "' as datetime)", DA.getConnection());
                    DA.cmdCommand(cmd1);
                }
                else
                {
                    MessageBox.Show("Неуспешна контрола");
                    mtbDatumKontrola.Enabled = false;
                    comboBox1.Enabled = false;
                    DialogResult = DialogResult.No;
                }

            }
         
            if (mtbDatumOprasuvanje.Enabled)
                {
                    SqlCommand cmd1 = new SqlCommand("UPDATE tblReprodukcija SET OprasuvanjeDatum = cast('" + MakeDate.makeDate(mtbDatumOprasuvanje.Text) + "' as datetime) Where FMajka = N'" + tbZensko.Text + "' and MTatko = N'" + tbMasko.Text + "'and OsemenuvanjeDatum = cast('" + tbDatumOsemenuvanje.Text + "' as datetime)", DA.getConnection());
                    DA.cmdCommand(cmd1);
                    cmd1 = new SqlCommand("UPDATE tblReprodukcija SET ZivoRodeniPrasinja = '" + (int)numericUpDown1.Value + "',MrtvoRodeniPrasinja = N'" + (int)numericUpDown2.Value + "',NevitalniPrasinja = N'" + (int)numericUpDown3.Value + "' Where FMajka = N'" + tbZensko.Text + "' and MTatko = N'" + tbMasko.Text + "'and OsemenuvanjeDatum = cast('" + tbDatumOsemenuvanje.Text + "' as datetime)", DA.getConnection());
                    DA.cmdCommand(cmd1);
                }
            if (mtbDatumOdbivanje.Enabled)
                {
                    SqlCommand cmd1 = new SqlCommand("UPDATE tblReprodukcija SET OdbivanjeDatum = cast('" + MakeDate.makeDate(mtbDatumOprasuvanje.Text) + "' as datetime) Where FMajka = N'" + tbZensko.Text + "' and MTatko = N'" + tbMasko.Text + "'and OsemenuvanjeDatum = cast('" + tbDatumOsemenuvanje.Text + "' as datetime)", DA.getConnection());
                    DA.cmdCommand(cmd1);
                    cmd1 = new SqlCommand("UPDATE tblReprodukcija SET OdbieniPrasinja = '" + (int)numericUpDown4.Value + "',MrtvoRodeniPrasinja = N'" + (int)numericUpDown2.Value + "',NevitalniPrasinja = N'" + (int)numericUpDown3.Value + "' Where FMajka = N'" + tbZensko.Text + "' and MTatko = N'" + tbMasko.Text + "'and OsemenuvanjeDatum = cast('" + tbDatumOsemenuvanje.Text + "' as datetime)", DA.getConnection());
                    DA.cmdCommand(cmd1);
            }
               DialogResult = DialogResult.Yes; 
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
    }
}
