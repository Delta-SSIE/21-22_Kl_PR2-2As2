using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP_04_Kruznice_II
{
    class Kruznice
    {
        private double _polomer;

        public double GetPolomer()
        {
            return _polomer;
        }
        public void SetPolomer(double hodnota)
        {
            if (hodnota < 0)
            {
                //Console.WriteLine("Neplatná hodnota poloměru");
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                _polomer = hodnota;
            }
        } 

        public Kruznice(double polomer)
        {
            SetPolomer(polomer);
        }
        public Kruznice()
        {
            SetPolomer(0);
        }

        public double SpoctiObvod()
        {
            return 2 * Math.PI * _polomer;
        }

        public double SpoctiObsah()
        {
            return Math.PI * _polomer * _polomer;
        }


    }
}
