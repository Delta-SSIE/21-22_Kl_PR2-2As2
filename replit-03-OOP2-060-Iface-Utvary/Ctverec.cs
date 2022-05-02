using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace replit_03_OOP2_060_Iface_Utvary
{
    class Ctverec : Obdelnik
    {
        public Ctverec(double strana) : base(strana, strana)
        {
        }

        public override string Nazev { get => "čtverec"; }
        public override string ToString()
        {
            return $"Čtverec o straně {StranaA}";
        }
    }
}
