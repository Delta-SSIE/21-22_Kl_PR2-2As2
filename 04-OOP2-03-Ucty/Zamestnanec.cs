using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP2_03_Ucty
{
    abstract class Zamestnanec
    {
        public string Jmeno { get; private set; }
        public string Prijmeni { get; private set; }

        protected Zamestnanec(string jmeno, string prijmeni)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
        }

        public abstract int Mzda();
    }
}
