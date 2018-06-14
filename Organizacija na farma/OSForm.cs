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
    public partial class OSForm : Form
    {
        public OSForm()
        {
            InitializeComponent();
        }

        private void buttonDodadi_Click(object sender, EventArgs e)
        {
            OSFormDodadi newForm = new OSFormDodadi();
            if (newForm.ShowDialog() == DialogResult.Yes)
            {
                DataAcess DA = new DataAcess();
                SqlCommand cmd1 = new SqlCommand("Insert Into tblOS(IDF,FMajka,Naziv2,Pol,VID,FF,MM,FFF,FMM,MMF,MMM,RagjanjeDatum,Aktivno) " +
                    "Values(0,N'"+ newForm.OS.Sifra +"',N'" + newForm.OS.Naziv + "',N'" + newForm.OS.Gender + "',N'" + newForm.OS.Vid + "',N'" + newForm.OS.Majka + "',N'" + newForm.OS.Tatko + "'" +
                    ",N'" + newForm.OS.BabaMajka + "',N'" + newForm.OS.DedoMajka + "',N'" + newForm.OS.BabaTatko + "',N'" + newForm.OS.DedoTatko + "',cast('" + newForm.OS.BirthDate + "' as datetime),'" + newForm.OS.Aktivno + "')", DA.getConnection());
                DA.cmdCommand(cmd1);
            }
        }

        private void buttonIzbrisi_Click(object sender, EventArgs e)
        {
            OSFormIzbrisi newForm = new OSFormIzbrisi();
            if (newForm.ShowDialog() == DialogResult.Yes)
            {
                DataAcess DA = new DataAcess();
                SqlCommand cmd1 = new SqlCommand("Delete from tblOs Where FMajka = N'" + newForm.Code + "'", DA.getConnection());
                DA.cmdCommand(cmd1);
            }
        }
        private void buttonPromeni_Click(object sender, EventArgs e)
        {
            OSFormPromeni newForm = new OSFormPromeni();
            if (newForm.ShowDialog() == DialogResult.Yes)
            {
                DataAcess DA = new DataAcess();
                SqlCommand cmd1 = new SqlCommand("UPDATE tblOS SET IzlezDatum = N'" + newForm.Datum + "', Aktivno = N'" + newForm.Aktivno + "' Where FMajka = N'" + newForm.Code + "'", DA.getConnection());
                DA.cmdCommand(cmd1);
            }
        }

    }
}
