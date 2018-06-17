using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizacija_na_farma
{
    public class MakeDate
    {
        public static string makeDate(String date)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(date.Substring(6, 4));
            sb.Append(date.Substring(3, 2));
            sb.Append(date.Substring(0, 2));

            return sb.ToString();
        }
    }
}
