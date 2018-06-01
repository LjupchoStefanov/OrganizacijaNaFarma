using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizacija_na_farma
{
    public class Reproduction
    {
        public int ID { get; set; }
        public OS Zensko { get; set; }
        public OS Masko { get; set; }
        public Nullable<DateTime> Osemena { get; set; }
        public Nullable<bool> Kontrola { get; set; }
        public Nullable<DateTime> KontrolaDatum { get; set; }
        public Nullable<DateTime> Oprasena { get; set; }
        public float Rodeni { get; set; }
        public float MrtvoRodeni { get; set; }
        public float Nevitalni { get; set; }
        public Nullable<DateTime> Odbivanje { get; set; }
        public float OdbienuPrasinja { get; set; }

        public Reproduction(int iD, OS zensko, OS masko, DateTime? osemena)
        {
            ID = iD;
            Zensko = zensko;
            Masko = masko;
            Osemena = osemena;
            Kontrola = null;
            KontrolaDatum = null;
            Oprasena = null;
            Rodeni = 0;
            MrtvoRodeni = 0;
            Nevitalni = 0;
            Odbivanje = null;
            OdbienuPrasinja = 0;
        }
    }
}
