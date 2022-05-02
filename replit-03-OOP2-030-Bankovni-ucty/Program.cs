using System;

namespace replit_03_OOP2_030_Bankovni_ucty
{
    class Program
    {
        static void Main(string[] args)
        {
            Ucet ucet1 = new Ucet();
            ucet1.Uloz(50);
            ucet1.Uloz(120);
            Console.WriteLine("Stav by měl být 170, ve skutečnosti je " + ucet1.Stav); //měl by vypsat 170

            ucet1.Vyber(60);
            Console.WriteLine("Stav by měl být 110, ve skutečnosti je " + ucet1.Stav); //měl by vypsat 110

            try {
                ucet1.Uloz(-20);
                Console.WriteLine("Pokud se vypíše tento text, není vše správně ošetřeno");
            } catch { 
                Console.WriteLine("Správně zachycený záporný vklad");
            }

            try
            {
                ucet1.Vyber(-20);
                Console.WriteLine("Pokud se vypíše tento text, není vše správně ošetřeno");
            }
            catch
            {
                Console.WriteLine("Správně zachycený záporný výběr");
            }

            try
            {
                ucet1.Vyber(2000);
                Console.WriteLine("Pokud se vypíše tento text, není vše správně ošetřeno");
            }
            catch
            {
                Console.WriteLine("Správně zachycený nadrozměrný výběr");
            }

            SporiciUcet ucet2 = new SporiciUcet();
            ucet2.Uloz(1000);
            ucet2.UrokovaMira = 3.1;
            ucet2.Urokuj();
            Console.WriteLine("Stav by měl být 1031, ve skutečnosti je " + ucet2.Stav);


            UcetSPoplatkem ucet3 = new UcetSPoplatkem();
            ucet3.PoplatekZaVklad = 10;
            ucet3.PoplatekZaVyber = 20;

            try
            {
                ucet3.Uloz(5);
                Console.WriteLine("Pokud se vypíše tento text, není vše správně ošetřeno");
            }
            catch
            {
                Console.WriteLine("Správně zachycená přiliš malá úložka při zpoplatnění");
            }

            ucet3.Uloz(20);
            Console.WriteLine("Stav by měl být 10, ve skutečnosti je " + ucet3.Stav);
            ucet3.Uloz(100);
            Console.WriteLine("Stav by měl být 100, ve skutečnosti je " + ucet3.Stav);

            try
            {
                ucet3.Vyber(90);
                Console.WriteLine("Pokud se vypíše tento text, není vše správně ošetřeno");
            }
            catch
            {
                Console.WriteLine("Správně zachycená přiliš velká úložka při zpoplatnění");
            }
            Console.WriteLine("Stav by měl být 100, ve skutečnosti je " + ucet3.Stav);

            ucet3.Vyber(50);
            Console.WriteLine("Stav by měl být 30, ve skutečnosti je " + ucet3.Stav);


        }
    }
}
