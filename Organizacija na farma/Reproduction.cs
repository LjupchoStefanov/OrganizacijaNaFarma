using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizacija_na_farma
{
    public class Reproduction
    {
        public string Zensko { get; set; }
        public string Masko { get; set; }
        public string Osemena { get; set; }
        public string KontrolaDatum { get; set; }
        public bool Kontrola { get; set; }
        public string Oprasena { get; set; }
        public float Rodeni { get; set; }
        public float MrtvoRodeni { get; set; }
        public float Nevitalni { get; set; }
        public string Odbivanje { get; set; }
        public float OdbieniPrasinja { get; set; }

        public Reproduction(string zensko, string masko, string osemena,string kontrolaDatum, bool kontrola, string oprasena, float rodeni, float mrtvoRodeni, float nevitalni, string odbivanje, float odbienuPrasinja)
        {
            Zensko = zensko;
            Masko = masko;
            Osemena = osemena;
            KontrolaDatum = kontrolaDatum;
            Kontrola = kontrola;
            Oprasena = oprasena;
            Rodeni = rodeni;
            MrtvoRodeni = mrtvoRodeni;
            Nevitalni = nevitalni;
            Odbivanje = odbivanje;
            OdbieniPrasinja = odbienuPrasinja;
        }

        /*public Reproduction(string zensko, string masko, string osemena)
        {
            Zensko = zensko;
            Masko = masko;
            Osemena = osemena;
            Kontrola = false;
            KontrolaDatum = null;
            Oprasena = null;
            Rodeni = 0;
            MrtvoRodeni = 0;
            Nevitalni = 0;
            Odbivanje = null;
            OdbienuPrasinja = 0;
        }*/

        public override string ToString()
        {
            return Zensko + "\t" + Masko + "\t" + Osemena + "\t" + KontrolaDatum + "\t" + Kontrola + "\t" + Oprasena +  Odbivanje;
        }
    }
}