using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizacija_na_farma
{
    public class Female :Individual
    {
        public enum typeStatus { servis, dojna, otstraneta, sprasna};
        public enum typeFaza { osemena, oplodena, oprasena, odbiena };
        public typeStatus status { get; set; }
        public typeFaza faza { get; set; }
        public DateTime removed { get; set; }
        public int days { get; set; }

        public Female(int id, string gender, int f, string name, string type, string mother, string father, DateTime birth)
            : base(id, gender, f, name, type, mother, father, birth)
        {
            status = typeStatus.sprasna;
            days = 0;
        }
    }
}
