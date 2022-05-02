using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace replit_03_OOP2_070_IComparable_Body
{
    class Bod : IComparable
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Bod(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return string.Format("Bod [{0};{1}]", this.X, this.Y);
        }

        public double VzdalenostOdStredu()
        {
            return Math.Sqrt(this.X * this.X + this.Y * this.Y);
        }

        public int CompareTo(object obj)
        {
            Bod druhyBod = obj as Bod;
            if (druhyBod == null)
                return 1;

            //uplne by stacilo
            //return Math.Sign(this.VzdalenostOdStredu() - druhyBod.VzdalenostOdStredu());

            double rozdilVzdalenosti = this.VzdalenostOdStredu() - druhyBod.VzdalenostOdStredu();
            if (rozdilVzdalenosti < 1)
                return -1;
            else if (rozdilVzdalenosti == 0)
                return 0;
            return +1;
        }
    }
}
