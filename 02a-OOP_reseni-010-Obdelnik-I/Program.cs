using System;

namespace _11_OOP_010_Obdelnik_I
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tento kód není třeba měnit

            Obdelnik obd1 = new Obdelnik();
            obd1.StranaA = 10;
            obd1.StranaB = 4;

            Console.WriteLine($"Obdélník o stranách {obd1.StranaA} cm a {obd1.StranaB} cm má obvod délky {obd1.Obvod()} cm a obsah o velikosti {obd1.Obsah()} cm^2.");


            Obdelnik obd2 = new Obdelnik();
            obd2.StranaA = 1;
            obd2.StranaB = 1;

            Console.WriteLine($"Obdélník o stranách {obd2.StranaA} cm a {obd2.StranaB} cm má obvod délky {obd2.Obvod()} cm a obsah o velikosti {obd2.Obsah()} cm^2.");


            Obdelnik obd3 = new Obdelnik();
            obd3.StranaA = 1.1;
            obd3.StranaB = 2.7;

            Console.WriteLine($"Obdélník o stranách {obd3.StranaA} cm a {obd3.StranaB} cm má obvod délky {obd3.Obvod()} cm a obsah o velikosti {obd3.Obsah()} cm^2.");
        }
    }
}
