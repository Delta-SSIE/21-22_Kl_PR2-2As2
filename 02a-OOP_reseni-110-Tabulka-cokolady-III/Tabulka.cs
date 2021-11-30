using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_OOP_110_Tabulka_cokolady_II
{
    class Tabulka
    {
        public string Znacka { get; private set; }


        private int _hmotnost;
        public int Hmotnost {
            get
            {
                return _hmotnost;
            }
            private set
            {
                if (value < 0 || value > 1000)
                    throw new ArgumentOutOfRangeException();

                _hmotnost = value;
            } 
        }


        private readonly string[] Druhy = new string[] { "Hořká", "Mléčná", "Bílá" }; //ideálně static, ale ty jsme ještě neřešili
        private string _druh;
        public string Druh
        {
            get
            {
                return _druh;
            }

            private set
            {
                if (!Druhy.Contains(value))
                    throw new ArgumentOutOfRangeException();

                _druh = value;
            }
        }

        public Tabulka(string druh, string znacka, int hmotnost)
        {
            Druh = druh;
            Znacka = znacka;
            Hmotnost = hmotnost;
        }


        public int Odlom()
        {
            int odlomeno = (Hmotnost < 10) ? Hmotnost : Hmotnost / 2;
            Hmotnost -= odlomeno;
            return odlomeno;
        }
    }
}
