using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace replit_03_OOP2_030_Bankovni_ucty
{
    class Ucet
    {
        public double Stav { get; protected set; }
        public virtual void Uloz(double castka)
        {
            if (castka <= 0)
                throw new ArgumentException("Lze uložit jen kladné částky");
            Stav += castka;
        }
        public virtual void Vyber(double castka)
        {
            if (castka <= 0)
                throw new ArgumentException("Lze uložit jen kladné částky");
            if (castka > Stav)
                throw new Exception("Nelze vybrat víc, než na účtě je");
            Stav -= castka;
        }
        public override string ToString()
        {
            return $"Účet, aktuální stav {Stav} Kč";
        }
    }
}
