using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_OOP_090_Obdelnik_III
{
    class Obdelnik
    {

        private double _stranaA;
        private double _stranaB;

        public double StranaA
        {
            get
            {
                return _stranaA;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();

                _stranaA = value;
            }
        }
        public double StranaB
        {
            get
            {
                return _stranaB;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();

                _stranaB = value;
            }
        }

        public Obdelnik()
        {
            StranaA = 0;
            StranaB = 0;
        }
        public Obdelnik(double stranaA, double stranaB)
        {
            StranaA = stranaA;
            StranaB = stranaB;
        }

        public double Obvod()
        {
            return 2 * (_stranaA + _stranaB);
        }

        public double Obsah()
        {
            return _stranaA * _stranaB;
        }
    }
}
