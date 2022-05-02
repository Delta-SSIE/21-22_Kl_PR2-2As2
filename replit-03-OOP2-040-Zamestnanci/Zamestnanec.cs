using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace replit_03_OOP2_040_Zamestnanci
{
    abstract class Zamestnanec
    {
        public string Jmeno { get; init; }
        public string Prijmeni { get; init; }

        protected Zamestnanec(string jmeno, string prijmeni)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
        }

        public abstract int Mzda();
    }
}
