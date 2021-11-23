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
        public Obdelnik()
        { }//bez tohoto prázdného konstruktoru by nebylo možné vytvořit obdélník s ještě nedefinovanými stranami
        public Obdelnik(double stranaA, double stranaB)
        {
            Sirka = stranaA; //používáme vlastnost i zevnitř konstruktoru - zajistí kontrolu přípustnosti hodnoty
            Vyska = stranaB;
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
    }
}
