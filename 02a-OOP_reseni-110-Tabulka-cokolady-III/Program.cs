using System;

namespace _11_OOP_110_Tabulka_cokolady_II
{
    class Program
    {
        static void Main(string[] args)
        {
            //všimněte si elegantního používání vlastností v kódu. Díky tomu je dobře čitelný i když neporušujeme zapouzdření.
            //tento kód není třeba měnit

            Tabulka dobrota = new Tabulka("Hořká", "Mooooo", 120);

            while (dobrota.Hmotnost > 0)
            {
                int puvodni = dobrota.Hmotnost;
                int odlomeno = dobrota.Odlom();
                int zbyde = dobrota.Hmotnost;

                Console.WriteLine($"Tabulka měla hmotnost {puvodni} gramů, odlomili jsme {odlomeno} gramů a zbylo {zbyde} gramů.");
            }

            Tabulka macek = new Tabulka("Mléčná", "BigBlackBar", 3000);
            //až ověříte, že se správně testují hmotnosti a sami si doděláte jiné testy vlastností, kód si zakomentujte, ať nerozbíjí program
        }
    }    
}
