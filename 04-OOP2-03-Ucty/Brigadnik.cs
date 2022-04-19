using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP2_03_Ucty
{
    class Brigadnik : Zamestnanec
    {
        public int HodinovaMzda { get; set; }
        public int Odpracovano { get; set; }
        public Brigadnik(string jmeno, string prijmeni) : base(jmeno, prijmeni)
        {
        }
        public override int Mzda()
        {
            return HodinovaMzda * Odpracovano;
        }
    }
}
