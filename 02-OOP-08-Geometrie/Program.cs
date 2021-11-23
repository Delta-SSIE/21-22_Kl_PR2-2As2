using System;

namespace _02_OOP_08_Geometrie
{
    class Program
    {
        static void Main(string[] args)
        {
            Obdelnik ABCD = new Obdelnik(5, 7, new Bod(-1,-1));
            Console.WriteLine(ABCD.LevyHorni);
            Console.WriteLine(ABCD.PravyHorni);
            Console.WriteLine(ABCD.LevyDolni);
            Console.WriteLine(ABCD.PravyDolni);

            Obdelnik EFGH = new Obdelnik(new Bod(2, 1), new Bod(4, 6));
            Console.WriteLine(EFGH);

            Bod bod;

            bod = new Bod(3, 5);
            if (EFGH.Obsahuje(bod))
            {
                Console.WriteLine($"{bod} je uvnitř obdélníka");
            }
            else
            {
                Console.WriteLine($"{bod} leží mimo obdélník");
            }

            bod = new Bod(-3, 5);
            if (EFGH.Obsahuje(bod))
            {
                Console.WriteLine($"{bod} je uvnitř obdélníka");
            }
            else
            {
                Console.WriteLine($"{bod} leží mimo obdélník");
            }
        }
    }
}
