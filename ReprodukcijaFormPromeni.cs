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
    public partial class ReprodukcijaFormPromeni : Form
    {
        public string Zensko { get; set; }
        public string Masko { get; set; }
        public string Osemenuvanje { get; set; }
        public bool Kontrola { get; set; }
        public string Oprasena { get; set; }
        public float Rodeni { get; set; }
        public float MrtvoRodeni { get; set; }
        public float Nevitalni { get; set; }
        public string Odbivanje { get; set; }
        public float OdbieniPrasinja { get; set; }
        public ReprodukcijaFormPromeni(Reproduction reproduction)
        {
            InitializeComponent();
            Zensko = reproduction.Zensko;
            Masko = reproduction.Masko;
            Osemenuvanje = reproduction.Osemena;
            Kontrola = reproduction.Kontrola;
            Oprasena = reproduction.Oprasena;
            Rodeni = reproduction.Rodeni;
            MrtvoRodeni = reproduction.MrtvoRodeni;
            Nevitalni = reproduction.Nevitalni;
            Odbivanje = reproduction.Odbivanje;
            OdbieniPrasinja = reproduction.OdbieniPrasinja;
        }

        public String makeDate(String date)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(date.Substring(6, 4));
            sb.Append(date.Substring(3, 2));
            sb.Append(date.Substring(0, 2));

            return sb.ToString();
        }

        public bool Cifri(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (cbKontrola.Checked)
            {
                Kontrola = true;
            }
            if (mtbOprasuvanje.Text.Length != 6)
            {
                Oprasena = makeDate(mtbOprasuvanje.Text);
            }
            if (tbRodeni.Text.Length != 0)
            {
                if (Cifri(tbRodeni.Text))
                {
                    Rodeni = float.Parse(tbRodeni.Text);
                }
            }
            if (tbMrtvi.Text.Length != 0)
            {
                if (Cifri(tbMrtvi.Text))
                {
                    MrtvoRodeni = float.Parse(tbMrtvi.Text);
                }
            }
            if (tbNevitalni.Text.Length != 0)
            {
                if (Cifri(tbNevitalni.Text))
                {
                    Nevitalni = float.Parse(tbNevitalni.Text);
                }
            }
            if (mtbOdbivanje.Text.Length != 6)
            {
                Odbivanje = makeDate(mtbOdbivanje.Text);
            }
            if (tbOdbieni.Text.Length != 0)
            {
                if (Cifri(tbOdbieni.Text))
                {
                    OdbieniPrasinja = float.Parse(tbOdbieni.Text);
                }
            }
            DialogResult = DialogResult.Yes;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

    }
}
