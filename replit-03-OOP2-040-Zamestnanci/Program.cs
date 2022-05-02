using System;

namespace replit_03_OOP2_040_Zamestnanci
{
    class Program
    {
        static void Main(string[] args)
        {
            Firma company = new Firma();

            StalyZamestnanec Pepa = new StalyZamestnanec("Josef", "Novotný", 28000);
            company.Zamestnej(Pepa);

            StalyZamestnanec Karel = new StalyZamestnanec("Karel", "Smutný", 27000);
            company.Zamestnej(Karel);

            Brigadnik Jarda = new Brigadnik("Jaroslav", "Černý");
            company.Zamestnej(Jarda);
            company.Zamestnej(Jarda); //neobjeví se na výplatnici podruhé
            Jarda.Odpracovano = 98;
            Jarda.HodinovaMzda = 170;

            Dobrovolnik Ivan = new Dobrovolnik("Ivan", "Zelenka");
            company.Zamestnej(Ivan);

            company.Vyplata(); //vypíše plat pro Pepu, Jardu a nulu pro Ivana - Karel tam nebude - celkem 71660,- Kč

        }
    }
}
