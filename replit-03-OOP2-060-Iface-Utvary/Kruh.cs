using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace replit_03_OOP2_060_Iface_Utvary
{
    class Kruh : IUtvar
    {        
        public double Polomer { get; private set; }

        public string Nazev { get => "kruh"; }
        public Kruh(double polomer)
        {
            Polomer = polomer;
        }

        public double GetObvod()
        {
            return 2 * Math.PI * Polomer;
        }
        public double GetObsah()
        {
            return Math.PI * Polomer * Polomer;
        }
        public override string ToString()
        {
            return $"{Nazev} o poloměru {Polomer}.";
        }
    }
}
