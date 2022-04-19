using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP2_03_Ucty
{
    class Firma
    {
        private List<Zamestnanec> _zamestnanci = new List<Zamestnanec>();

        public void Zamestnej (Zamestnanec zamestnanec)
        {
            if (_zamestnanci.Contains(zamestnanec))
                return;

            _zamestnanci.Add(zamestnanec);
        }
        public void Propust(Zamestnanec zamestnanec)
        {
            _zamestnanci.Remove(zamestnanec);
        }
        public void Vyplata()
        {
            int suma = 0;
            foreach (Zamestnanec z in _zamestnanci)
            {
                Console.WriteLine($"{z.Prijmeni}, {z.Jmeno}: {z.Mzda()} Kč");
                suma += z.Mzda();
            }
            Console.WriteLine("----------------");
            Console.WriteLine($"Celkem: {suma} Kč");
        }
    }
}
