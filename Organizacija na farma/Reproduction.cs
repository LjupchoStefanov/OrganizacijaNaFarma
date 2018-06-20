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
            return String.Format("{0,-10}{1,-12:C} {2, 30} {3, 25} {4, -33}{5, 30}{6, 35}{7, 27}{8, 24}{9, 40}{10, 30}",Zensko, Masko, Osemena, KontrolaDatum, Kontrola, Oprasena, Rodeni, MrtvoRodeni, Nevitalni, Odbivanje, OdbieniPrasinja);
        }
    }
}
