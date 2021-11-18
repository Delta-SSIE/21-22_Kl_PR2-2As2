using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP_07_Bod
{
    class Bod
    {
        //private double _x, _y;

        //public double X {
        //    get
        //    {
        //        return _x;
        //    }

        //    private set
        //    {
        //        _x = value;
        //    }
        //}

        //public double Y
        //{
        //    get
        //    {
        //        return _y;
        //    }

        //    private set
        //    {
        //        _y = value;
        //    }
        //}
        public double X {get; private set;}
        public double Y { get; private set;}

        public bool ShodnyS(Bod jinyBod)
        {
            return X == jinyBod.X && Y == jinyBod.Y;
        }

        public double VzdalenostOd(Bod jinyBod)
        {
            double dx = X - jinyBod.X;
            double dy = Y - jinyBod.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        public Bod(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"bod[{X}, {Y}]";
        }


    }
}
