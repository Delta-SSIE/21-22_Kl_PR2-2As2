using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace replit_03_OOP2_030_Bankovni_ucty
{
    class SporiciUcet : Ucet
    {
        public double UrokovaMira { get; set; }
        public void Urokuj()
        {
            Stav += Stav * UrokovaMira / 100;
        }
    }
}
