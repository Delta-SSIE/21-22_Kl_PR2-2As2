using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP_06_Ucet
{
    class Ucet
    {
        private double _zustatek;
        private List<string> _log;

        public double Zustatek
        {
            get
            {
                return _zustatek;
            }
        }

        public Ucet()
        {
            _log = new List<string>();
            _log.Add("Účet založen");

        }

        public void Uloz(double vklad)
        {
            if (vklad <= 0)
                throw new System.ArgumentOutOfRangeException("Záporná hodnota vkladu");

            _log.Add($"Vklad {vklad}");
            _zustatek += vklad;
        }

        public bool Vyber(double castka)
        {
            if (_zustatek < castka) //když není dost peněz
            {
                _log.Add($"Neúspěšný pokus o výber {castka}.");
                return false;
            }

            _zustatek -= castka;
            _log.Add($"Vybráno {castka}.");
            return true;
        }

        public void Urokuj(double urokovaMira)
        {
            _zustatek *= 1 + urokovaMira / 100;
            _log.Add($"Úrokováno s mírou {urokovaMira}.");
        }

        public override string ToString() //použije se při konverzi na řetězec, třeba v Console.WriteLine
        {
            return $"Účet se zůstatkem {_zustatek}.";
        }

        public string GetTransactionLog()
        {
            return string.Join(System.Environment.NewLine, _log);
        }
    }
}
