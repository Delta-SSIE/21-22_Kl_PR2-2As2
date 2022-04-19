using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP2_03_Ucty
{
    class Dobrovolnik : Zamestnanec
    {
        public Dobrovolnik(string jmeno, string prijmeni) : base(jmeno, prijmeni)
        {
        }
        public override int Mzda()
        {
            return 0;
        }
    }
}
