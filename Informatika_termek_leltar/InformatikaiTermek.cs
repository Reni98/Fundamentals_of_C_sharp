using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informatikai_Leltar
{

    internal class InformatikaiTermek
    {
        public string Nev { get; set; }
        public string Tipus { get; set; }
        public double Ar { get; set; }

        public InformatikaiTermek(string nev, string tipus, double ar)
        {
            Nev = nev;
            Tipus = tipus;
            Ar = ar;
        }
    }
}
