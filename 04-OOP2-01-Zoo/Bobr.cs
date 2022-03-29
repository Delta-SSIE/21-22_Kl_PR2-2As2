using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP2_01_Zoo
{
    class Bobr : Savec
    {
        protected Bobr(string jmeno) : base(jmeno)
        {
        }

        public override void OzviSe()
        {
            Console.WriteLine("Hlody hlod");
        }
    }
}
