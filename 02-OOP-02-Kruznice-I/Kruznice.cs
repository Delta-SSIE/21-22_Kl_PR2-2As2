using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP_02_Kruznice_I
{
    class Kruznice
    {
        public double Polomer;

        public double SpoctiObvod()
        {
            return 2 * Math.PI * Polomer;
        }

        public double SpoctiObsah()
        {
            return Math.PI * Polomer * Polomer;
        }
    }
}
