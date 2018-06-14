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
    public partial class DvizenjeForm : Form
    {
        public DvizenjeForm()
        {
            InitializeComponent();
        }

        private void buttonDodadi_Click(object sender, EventArgs e)
        {
            DvizenjeFormDodadi newForm = new DvizenjeFormDodadi();
            if (newForm.ShowDialog() == DialogResult.Yes)
            {
                DataAcess DA = new DataAcess();
                SqlCommand cmd1 = new SqlCommand("Insert Into tblDvizenje(ID,Skladiste,VidDvizenje,Priem,Datum) " +
                    "Values(0,N'" + newForm.Dvizenje.Skladiste + "',N'" + newForm.Dvizenje.VidDvizenje + "',N'" + newForm.Dvizenje.Priem +  
                    "',cast('" + newForm.Dvizenje.Datum + "' as datetime))", DA.getConnection());
                DA.cmdCommand(cmd1);
            }
        }
        private void buttonIzbrisi_Click(object sender, EventArgs e)
        {
            DvizenjeFormIzbrisi newForm = new DvizenjeFormIzbrisi();
            if (newForm.ShowDialog() == DialogResult.Yes)
            {
                DataAcess DA = new DataAcess();
                SqlCommand cmd1 = new SqlCommand("Delete from tblDvizenje Where Skladiste = N'" + newForm.Skladiste + "' and VidDvizenje = N'" + newForm.VidDvizenje + "' and Priem = N'" + newForm.Priem + "'and Datum = cast('" + newForm.Datum + "' as datetime)", DA.getConnection());
                DA.cmdCommand(cmd1);
            }
        }

        private void buttonPromeni_Click(object sender, EventArgs e)
        {
            DvizenjeFormPromeni newForm = new DvizenjeFormPromeni();
            if (newForm.ShowDialog() == DialogResult.Yes)
            {
                DataAcess DA = new DataAcess();
                SqlCommand cmd1 = new SqlCommand("UPDATE tblDvizenje SET Izdavanje = N'" + newForm.Izdavanje + "' Where Skladiste = N'" + newForm.Skladiste + "' and VidDvizenje = N'" + newForm.VidDvizenje + "' and Priem = N'" + newForm.Priem + "'", DA.getConnection());
                DA.cmdCommand(cmd1);
            }
        }
    }
}
