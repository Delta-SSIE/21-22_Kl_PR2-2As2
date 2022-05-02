using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace replit_03_OOP2_040_Zamestnanci
{
    class StalyZamestnanec : Zamestnanec
    {
        private int _mzda;
        public StalyZamestnanec(string jmeno, string prijmeni, int mzda) : base(jmeno, prijmeni)
        {
            _mzda = mzda;
        }
        public override int Mzda() => _mzda;
    }
}
