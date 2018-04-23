using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizacija_na_farma
{
    public class Individual
    {
        public int id { get; set; }
        public string gender { set; get; }
        public int f { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string mother { get; set; }
        public string father { get; set; }
        public DateTime birth { get; set; }

        public Individual(int id, string gender, int f, string name, string type, string mother, string father, DateTime birth)
        {
            this.id = id;
            this.gender = gender;
            this.f = f;
            this.name = name;
            this.type = type;
            this.mother = mother;
            this.father = father;
            this.birth = birth;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
