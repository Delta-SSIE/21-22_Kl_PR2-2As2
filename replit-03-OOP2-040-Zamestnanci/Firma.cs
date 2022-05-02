using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace replit_03_OOP2_040_Zamestnanci
{
    class Firma
    {
        private HashSet<Zamestnanec> _zamestnanci = new HashSet<Zamestnanec>();
        public void Zamestnej (Zamestnanec zamestnanec)
        {
            _zamestnanci.Add(zamestnanec);
        }
        public void Propust(Zamestnanec zamestnanec)
        {
            _zamestnanci.Remove(zamestnanec);
        }
        public void Vyplata()
        {
            int celkem = 0;
            foreach (Zamestnanec z in _zamestnanci)
            {
                int mzda = z.Mzda();
                Console.WriteLine($"{z.Prijmeni} {z.Jmeno[0]}.: {mzda},- Kč");
                celkem += mzda;
            }
            Console.WriteLine("".PadRight(15,'-'));
            Console.WriteLine($"Celkem: {celkem},- Kč");
        }
    }
}
