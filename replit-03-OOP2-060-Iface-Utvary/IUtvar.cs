using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace replit_03_OOP2_060_Iface_Utvary
{
    interface IUtvar
    {
        string Nazev { get; }
        double GetObvod();
        double GetObsah();
    }
}
