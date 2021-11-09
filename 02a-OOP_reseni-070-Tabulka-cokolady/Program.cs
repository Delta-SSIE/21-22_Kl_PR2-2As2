using System;

namespace _11_OOP_070_Tabulka_cokolady
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabulka dobrota = new Tabulka();
            //zde nastavte další vlastnosti
            dobrota.SetDruh("Hořká");
            dobrota.SetZnacka("Mooooo");
            dobrota.SetHmotnost(120);

            while (dobrota.GetHmotnost() > 0)
            {
                int puvodni = dobrota.GetHmotnost();
                int odlomeno = dobrota.Odlom();
                int zbyde = dobrota.GetHmotnost();

                Console.WriteLine($"Tabulka měla hmotnost {puvodni} gramů, odlomili jsme {odlomeno} gramů a zbylo {zbyde} gramů.");
            }

            Tabulka macek = new Tabulka();
            //macek.SetHmotnost(3000);
            //až ověříte, že se správně testují hmotnosti a sami si doděláte jiné testy vlastností, kód si zakomentujte, ať nerozbíjí program
        }
    }
}
