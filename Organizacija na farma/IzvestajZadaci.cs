using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class IzvestajZadaci : Form
    {
        public IzvestajZadaci()
        {
            InitializeComponent();
            DataAcess da = new DataAcess();
            SqlConnection conn = da.getConnection();
            List<String> aktivni = new List<string>();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select FMajka From tblOS Where Aktivno = 1");
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {

                while (reader.Read())
                {
                    aktivni.Add(reader["FMajka"].ToString());
                    //listBoxKontrola.Items.Add(reader["FMajka"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
            }
            for (int i = 0; i < aktivni.Count; i++)
            {
                cmd = new SqlCommand("SELECT Top 1 * FROM [Farma].[dbo].[tblReprodukcija] Where FMajka = '" + aktivni[i] + "' order by OsemenuvanjeDatum desc");
                cmd.Connection = conn;
                reader = cmd.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        string Zensko = reader["FMajka"].ToString();
                        string Masko = reader["MTatko"].ToString();
                        string Osemena = reader["OsemenuvanjeDatum"].ToString();
                        string KontrolaDatum = reader["KontrolaDatum"].ToString();
                        bool Kontrola = Boolean.Parse(reader["Kontrola"].ToString());
                        string Oprasena = reader["OprasuvanjeDatum"].ToString();
                        float Rodeni = 0;
                        //if (reader["ZivoRodeniPrasinja"].ToString() != "") Rodeni = float.Parse(reader["ZivoRodeniPrasinja"].ToString());
                        float MrtvoRodeni = 0;
                        //if (reader["MrtvoRodeniPrasinja"].ToString() != "") MrtvoRodeni = float.Parse(reader["MrtvoRodeniPrasinja"].ToString());
                        float Nevitalni = 0;
                        //if (reader["NevitalniPrasinja"].ToString() != "") Nevitalni = float.Parse(reader["NevitalniPrasinja"].ToString());
                        string Odbivanje = reader["OdbivanjeDatum"].ToString();
                        float OdbieniPrasinja = 0;
                        //if (reader["OdbieniPrasinja"].ToString() != "") OdbieniPrasinja = float.Parse(reader["OdbieniPrasinja"].ToString());
                        Reproduction pom = new Reproduction(Zensko, Masko, Osemena, Kontrola, KontrolaDatum, Oprasena, Rodeni, MrtvoRodeni, Nevitalni, Odbivanje, OdbieniPrasinja);
                        if (zaOsemenuvanje(pom))
                        {
                            listBoxOsemenuvanje.Items.Add(pom.Zensko);
                        }
                        else if (zaOdbivanje(pom))
                        {
                            listBoxOdbivanje.Items.Add(pom.Zensko);
                        }
                        else if (zaOprasuvanje(pom))
                        {
                            listBoxOprasuvanje.Items.Add(pom.Zensko);
                        }
                        else if (zaKontrola(pom))
                        {
                            listBoxKontrola.Items.Add(pom.Zensko);
                        }
                        else
                        {
                            MessageBox.Show("Wrong input" + pom.ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    reader.Close();
                }
            }

        }

        public bool zaOsemenuvanje(Reproduction pom)
        {
            return pom.Odbivanje != "";
        }

        public bool zaKontrola(Reproduction pom)
        {
            return pom.KontrolaDatum == "";
        }

        public bool zaOprasuvanje(Reproduction pom)
        {
            return pom.Kontrola;
        }

        public bool zaOdbivanje(Reproduction pom)
        {
            return pom.Oprasena != "";
        }

    }
}