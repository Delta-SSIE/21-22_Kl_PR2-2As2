using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace replit_03_OOP2_020_Pocitadlo
{
    public class DownCounter : StepCounter
    {
        public int InitValue { get; private set; }

        public bool IsFinished
        {
            get
            {
                return Count <= 0;
            }
        }

        public DownCounter(int step, int initValue) : base(-step)
        {
            Count = InitValue = initValue;
        }

        public override void Reset()
        {
            Count = InitValue;
        }
    }
}
