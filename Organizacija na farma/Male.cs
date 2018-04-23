using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizacija_na_farma
{
    public class Male : Individual
    {
        public enum typeStatus { otstranet, ploden }
        public DateTime removed { get; set; }
        public typeStatus status { get; set; }

        public Male(int id, string gender, int f, string name, string type, string mother, string father, DateTime birth) 
            :base(id, gender, f, name, type, mother, father, birth)
        {
            status = typeStatus.ploden;
        }
    }
}
