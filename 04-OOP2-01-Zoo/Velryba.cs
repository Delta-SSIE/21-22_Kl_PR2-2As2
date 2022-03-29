using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP2_01_Zoo
{
    class Velryba : Savec
    {
        public Velryba(string jmeno) : base(jmeno)
        {
        }

        public void Plav()
        {
            Console.WriteLine("Šplouch");
        }
        public override void OzviSe()
        {
            Console.WriteLine("Huí huí");
        }
    }
}
