using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_OOP_070_Tabulka_cokolady
{
    class Tabulka
    {
        private string _znacka;
        private int _hmotnost;
        private string _druh;

        private readonly string[] Druhy = new string[] { "Hořká", "Mléčná", "Bílá" }; //ideálně static, ale ty jsme ještě neřešili

        public void SetZnacka(string znacka)
        {
            _znacka = znacka;
        }
        public string GetZnacka()
        {
            return _znacka;
        }

        public void SetHmotnost(int hmotnost)
        {
            if (hmotnost < 0 || hmotnost > 1000)
                throw new ArgumentOutOfRangeException();
            
            _hmotnost = hmotnost;
        }
        public int GetHmotnost()
        {
            return _hmotnost;
        }

        public void SetDruh(string druh)
        {
            if (!Druhy.Contains(druh))
                throw new ArgumentOutOfRangeException();
            
            _druh = druh;
        }
        public string GetDruh()
        {
            return _druh;
        }

        public int Odlom()
        {
            int odlomeno = (_hmotnost < 10) ? _hmotnost : _hmotnost / 2;
            _hmotnost -= odlomeno;
            return odlomeno;
        }

    }
}
