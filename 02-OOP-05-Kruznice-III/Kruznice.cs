using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP_05_Kruznice_III
{
    class Kruznice
    {
        private double _polomer;
        public double Polomer
        {
            get
            {
                return _polomer;
            }
            //get => _polomer; //jiný zápis getteru
            private set
            {
                if (value < 0)
                {
                    //Console.WriteLine("Neplatná hodnota poloměru");
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    _polomer = value;
                }
            }
        }

        public Kruznice(double polomer)
        {
            Polomer = polomer;
        }
        public Kruznice()
        {
            Polomer = 0;
        }

        public double Obvod
        {
            get
            {
                return 2 * Math.PI * _polomer;
            }
        }

        public double Obsah
        {
            get
            {
                return Math.PI * _polomer * _polomer;
            }
        }




    }
}
