using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace replit_03_OOP2_020_Pocitadlo
{
    public class Counter
    {
        public int Count { get; protected set; }

        public virtual void Next()
        {
            Count++;
        }

        public virtual void Reset()
        {
            Count = 0;
        }
    }
}
