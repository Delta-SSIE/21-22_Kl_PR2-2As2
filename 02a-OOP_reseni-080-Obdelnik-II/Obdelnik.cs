using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_OOP_080_Obdelnik_II
{
    class Obdelnik
    {
        //        Pozměňte kód třídy `Obdelnik` z minulých úkolů tak, že bude mít
        //* Neveřejné položky `_stranaA` a `_stranaB` (reálná čísla)
        //* Jejich přístupové metody `GetA`, `SetA`, `GetB` a `SetB`, kde settery budou hlídat validitu(=platnost, rozumnost) ukládané hodnoty
        //* Metody `Obvod()` a `Obsah()`
        //* Konstruktor bez parametrů
        //* Konstruktor, kterému lze oba parametry `a` a `b` předat
        //    * Nezapomeňte i v konstruktoru použít settery, neukládejte přímo

        private double _stranaA;
        private double _stranaB;

        public void SetA(double stranaA)
        {
            if (stranaA < 0)
                throw new ArgumentOutOfRangeException();

            _stranaA = stranaA;
        }
        public double GetA()
        {
            return _stranaA;
        }
        public void SetB(double stranaB)
        {
            if (stranaB < 0)
                throw new ArgumentOutOfRangeException();

            _stranaB = stranaB;
        }
        public double GetB()
        {
            return _stranaB;
        }
        public Obdelnik()
        {
            SetA(0);
            SetB(0);
        }
        public Obdelnik(double stranaA, double stranaB)
        {
            SetA(stranaA);
            SetB(stranaB);
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
