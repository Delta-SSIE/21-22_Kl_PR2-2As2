using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP_08_Geometrie
{
    class Obdelnik
    {

        private double _sirka;
        public double Sirka
        {
            get
            {
                return _sirka;
            }
            private set
            {
                if (value >= 0)
                    _sirka = value;
                else
                    throw new ArgumentOutOfRangeException();
            }
        }
        private double _vyska;
        public double Vyska
        {
            get
            {
                return _vyska;
            }
            set
            {
                if (value >= 0)
                    _vyska = value;
                else
                    throw new ArgumentOutOfRangeException();
            }
        }
        public Bod LevyHorni { get; private set; }
        public Bod PravyHorni
        {
            get
            {
                double x = LevyHorni.X + Sirka;
                double y = LevyHorni.Y;
                return new Bod(x, y);
            }
        }
        public Bod LevyDolni
        {
            get
            {
                double x = LevyHorni.X;
                double y = LevyHorni.Y + Vyska;
                return new Bod(x, y);
            }
        }
        public Bod PravyDolni
        {
            get
            {
                double x = LevyHorni.X + Sirka;
                double y = LevyHorni.Y + Vyska;
                return new Bod(x, y);
            }
        }

        //public Obdelnik()
        //{ }//bez tohoto prázdného konstruktoru by nebylo možné vytvořit obdélník s ještě nedefinovanými stranami
        public Obdelnik(double stranaA, double stranaB, Bod levyHorniRoh)
        {
            Sirka = stranaA; //používáme vlastnost i zevnitř konstruktoru - zajistí kontrolu přípustnosti hodnoty
            Vyska = stranaB;
            LevyHorni = levyHorniRoh;
        }

        public Obdelnik(Bod levyHorniRoh, Bod pravyDolniRoh)
        {
            LevyHorni = levyHorniRoh;
            Sirka = pravyDolniRoh.X - LevyHorni.X;
            Vyska = pravyDolniRoh.Y - LevyHorni.Y;
        }

        public double Obsah()
        {
            return _sirka * _vyska;
        }
        public double Obvod()
        {
            return 2 * (_sirka + _vyska);
        }

        public override string ToString()
        {
            return $"Obdélník [{_sirka}, {_vyska}]";
        }

        public bool Obsahuje(Bod bod)
        {
            return  bod.X >= LevyHorni.X
                    && bod.X <= PravyDolni.X
                    && bod.Y >= LevyHorni.Y
                    && bod.Y <= PravyDolni.Y;
        }
    }
}
