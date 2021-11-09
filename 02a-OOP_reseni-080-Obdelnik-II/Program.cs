using System;

namespace _11_OOP_080_Obdelnik_II
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tento kód není třeba měnit

            Obdelnik obd1 = new Obdelnik(10, 4);
            Console.WriteLine($"Obdélník o stranách {obd1.GetA()} cm a {obd1.GetB()} cm má obvod délky {obd1.Obvod()} cm a obsah o velikosti {obd1.Obsah()} cm^2.");


            Obdelnik obd2 = new Obdelnik(1, 1);
            Console.WriteLine($"Obdélník o stranách {obd2.GetA()} cm a {obd2.GetB()} cm má obvod délky {obd2.Obvod()} cm a obsah o velikosti {obd2.Obsah()} cm^2.");


            Obdelnik obd3 = new Obdelnik(1.1, 2.7);
            Console.WriteLine($"Obdélník o stranách {obd3.GetA()} cm a {obd3.GetB()} cm má obvod délky {obd3.Obvod()} cm a obsah o velikosti {obd3.Obsah()} cm^2.");
        }
    }
}
