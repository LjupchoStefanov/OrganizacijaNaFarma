﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizacija_na_farma
{
    public class Dvizenje
    {
        public string Skladiste { get; set; }
        public string VidDvizenje { get; set; }
        public int Priem { get; set; }
        public int Izdavanje { get; set; }
        public string Datum { get; set; }

        public Dvizenje(string skladiste, string vidDvizenje, int priem, string datum)
        {
            Skladiste = skladiste;
            VidDvizenje = vidDvizenje;
            Priem = priem;
            Datum = datum;
        }
    }
}
