using System;

namespace _02_OOP_06_Ucet
{
    class Program
    {
        static void Main(string[] args)
        {
            Ucet prasatko = new Ucet();
            Console.WriteLine($"Na účtu je {prasatko.Zustatek}");

            prasatko.Uloz(100);
            Console.WriteLine($"Na účtu je {prasatko.Zustatek}");

            prasatko.Uloz(120);
            Console.WriteLine($"Na účtu je {prasatko.Zustatek}");

            double castka = 50;

            if (prasatko.Vyber(castka))
                Console.WriteLine($"Vybral jsem {castka}.");
            else
                Console.WriteLine($"Nepodařilo se vybrat {castka}.");

            Console.WriteLine($"Na účtu je {prasatko.Zustatek}.");


            castka = 2500;

            if (prasatko.Vyber(castka))
                Console.WriteLine($"Vybral jsem {castka}.");
            else
                Console.WriteLine($"Nepodařilo se vybrat {castka}.");

            Console.WriteLine($"Na účtu je {prasatko.Zustatek}.");

            prasatko.Urokuj(15);
            Console.WriteLine($"Na účtu je {prasatko.Zustatek}.");

            Console.WriteLine(prasatko);

            Console.WriteLine();
            Console.WriteLine(prasatko.GetTransactionLog());


            //prasatko.Uloz(100);

            //int obdobi = 0;
            //double urokovaMira = 7;

            //while (prasatko.Zustatek < 200)
            //{
            //    obdobi++;
            //    prasatko.Urokuj(urokovaMira);
            //}

            //Console.WriteLine($"Na zdvojnásobení vkladu při úrokové míře {urokovaMira} je třeba {obdobi} úrokovacích období.");
        }
    }
}
