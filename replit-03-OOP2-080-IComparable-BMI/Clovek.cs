using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace replit_03_OOP2_080_IComparable_BMI
{
    class Clovek : IComparable
    {
        const double IdealniBMI = 22;
        public string Jmeno { get; private set; }
        public double Hmotnost { get; private set; }
        public double Vyska { get; private set; }

        public double BMI => Hmotnost / (Vyska * Vyska / 10000);
        //public double BMI
        //{
        //    get
        //    {
        //        return Hmotnost / (Vyska * Vyska / 10000);
        //    }
        //}

        public Clovek(string jmeno, double hmotnost, double vyska)
        {
            if (jmeno.Length < 1) throw new ArgumentException("Příliš krátké jméno");
            if (hmotnost <= 0) throw new ArgumentOutOfRangeException();
            if (vyska <= 0) throw new ArgumentOutOfRangeException();

            this.Jmeno = jmeno;
            this.Hmotnost = hmotnost;
            this.Vyska = vyska;
        }

        public override string ToString()
        {
            return $"{Jmeno} ({BMI:0.00})";
        }

        public int CompareTo(object obj)
        {
            Clovek druhy = obj as Clovek;
            if (druhy == null)
                return 1;

            double mujRozdil = Math.Abs(this.BMI - IdealniBMI);
            double druhyRozdil = Math.Abs(druhy.BMI - IdealniBMI);

            if (mujRozdil < druhyRozdil)
                return -1;
            else if (mujRozdil == druhyRozdil)
                return 0;
            else
                return 1;
        }
    }
}
