using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace replit_03_OOP2_030_Bankovni_ucty
{
    class UcetSPoplatkem : Ucet
    {
        public double PoplatekZaVyber { get; set; }
        public double PoplatekZaVklad { get; set; }
        public override void Uloz(double castka)
        {
            if (Stav + castka < PoplatekZaVklad)
                throw new ArgumentException("Vložením tak malé částky by se účet dostal do minusu");
            base.Uloz(castka);
            Stav -= PoplatekZaVklad;
        }
        public override void Vyber(double castka)
        {
            if (Stav < castka + PoplatekZaVyber)
                throw new ArgumentException("Tak velkou částku nelze vybrat");

            base.Vyber(castka);
            Stav -= PoplatekZaVyber;
        }
    }
}
