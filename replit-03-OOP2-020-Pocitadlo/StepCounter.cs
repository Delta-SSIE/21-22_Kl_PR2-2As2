using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace replit_03_OOP2_020_Pocitadlo
{
    public class StepCounter : Counter
    {
        public int Step { get; private set; }

        public StepCounter(int step)
        {
            Step = step;
        }

        public override void Next()
        {
            Count += Step;
        }
    }
}
