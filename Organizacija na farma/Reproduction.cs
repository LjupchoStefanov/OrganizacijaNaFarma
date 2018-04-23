using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizacija_na_farma
{
    public class Reproduction
    {
        public int id { get; set; }
        public Female zensko { get; set; }
        public Male masko { get; set; }
        public DateTime osemena { get; set; }
        public DateTime kontrola { get; set; }
        public DateTime oprasena { get; set; }
        public int rodeni { get; set; }
        public int mrtvoRodeni { get; set; }
        public int nevitalni { get; set; }
        public DateTime odbivanje { get; set; }
        public int odbienuPrasinja { get; set; }

    }
}
