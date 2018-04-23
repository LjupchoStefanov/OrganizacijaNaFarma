using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizacija_na_farma
{
    public class Dvizenje
    {
        public enum location { bFaza, prasiliste, toviliste};
        public enum reason { izlezOdFarma, kupeno, prenos, prinudnoZaklano, uginato, rodeno};
        public DateTime datum { get; set; }
        public int kolicina { get; set; }
        public location lokacija { get; set; }
        public reason pricina { get; set; }

        public Dvizenje(DateTime datum, int kolicina, location lokacija, reason pricina)
        {
            this.datum = datum;
            this.kolicina = kolicina;
            this.lokacija = lokacija;
            this.pricina = pricina;
        }
    }
}
