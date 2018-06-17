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
        public bool Kontrola { get; set; }
        public string KontrolaDatum { get; set; }
        public string Oprasena { get; set; }
        public float Rodeni { get; set; }
        public float MrtvoRodeni { get; set; }
        public float Nevitalni { get; set; }
        public string Odbivanje { get; set; }
        public float OdbieniPrasinja { get; set; }

        public Reproduction(string zensko, string masko, string osemena, bool kontrola, string kontrolaDatum, string oprasena, float rodeni, float mrtvoRodeni, float nevitalni, string odbivanje, float odbieniPrasinja)
        {
            Zensko = zensko;
            Masko = masko;
            Osemena = osemena;
            Kontrola = kontrola;
            KontrolaDatum = kontrolaDatum;
            Oprasena = oprasena;
            Rodeni = rodeni;
            MrtvoRodeni = mrtvoRodeni;
            Nevitalni = nevitalni;
            Odbivanje = odbivanje;
            OdbieniPrasinja = odbieniPrasinja;
        }

        public override string ToString()
        {
            return String.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t{9}\t{10}", Zensko, Masko, Osemena, Kontrola,KontrolaDatum, Oprasena, Rodeni, MrtvoRodeni, Nevitalni, Odbivanje, OdbieniPrasinja);
        }
    }
}
