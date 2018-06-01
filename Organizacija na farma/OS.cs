using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizacija_na_farma
{
    public class OS
    {
        public int ID { get; set; }
        public string Sifra { get; set; }
        public string Naziv { get; set; }
        public string Gender { set; get; }
        public int Vid { get; set; }
        public string Majka { get; set; }
        public string Tatko { get; set; }
        public string BabaMajka { get; set; }
        public string DedoMajka { get; set; }
        public string BabaTatko { get; set; }
        public string DedoTatko { get; set; }
        public Nullable<DateTime> BirthDate { get; set; }
        public Nullable<DateTime> IzlelDatum { get; set; }
        public bool Aktivno { get; set; }

        public OS(int iD, string sifra, string naziv, string gender, int vid, string majka, string tatko, string babaMajka, string dedoMajka, string babaTatko, string dedoTatko, DateTime birthDate)
        {
            ID = iD;
            Sifra = sifra;
            Naziv = naziv;
            Gender = gender;
            Vid = vid;
            Majka = majka;
            Tatko = tatko;
            BabaMajka = babaMajka;
            DedoMajka = dedoMajka;
            BabaTatko = babaTatko;
            DedoTatko = dedoTatko;
            BirthDate = birthDate;
            IzlelDatum = null;
            Aktivno = true;
        }

        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2}\t{3}",Sifra,Naziv,Gender);
        }
    }
}
