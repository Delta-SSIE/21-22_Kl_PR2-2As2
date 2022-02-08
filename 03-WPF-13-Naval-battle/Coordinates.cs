using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_WPF_13_Naval_battle
{
    class Coordinates
    {
        public int X { get; set; }
        public int Y { get; set; }
        public override string ToString()
        {
            return $"[{X}, {Y}]";
        }
    }
}
