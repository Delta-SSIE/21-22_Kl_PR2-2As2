using System;

namespace _01_Hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int a = 15;
            //string stav = a > 10 ? "velké" : "malé";

            //if (a > 10)
            //    stav = "velké";
            //else
            //    stav = "male";

            //string stav = a < 5 ? "prťavé" 
            //            : a < 7 ? "malé"
            //            : a < 10 ? "tak akorát"
            //            : "velké";


            //Console.WriteLine($"Číslo je {stav}.");


            //int i = 10;
            //while (i < 20)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //int i = 20;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //while (i < 20);


            //for (int i = 1; i < 30; i++)
            //{
            //    if (i % 8 == 0)
            //        continue;
            //        //break;
            //    Console.WriteLine(i);
            //}

            //int[] cisla = new int[5];
            //int[] cisla = { 0, 1, 1, 2, 3, 5, 8, 13 };

            //for (int i = cisla.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(cisla[i]);
            //}

            Console.WriteLine(  Vynasob(1, 2, 3) );


        }

        /// <summary>
        /// Vynásobí mezi sebou tři čísla
        /// </summary>
        /// <param name="cislo1">První číslo</param>
        /// <param name="cislo2">Druhé číslo</param>
        /// <param name="cislo3">Třetí číslo</param>
        /// <returns>Součin</returns>
        static double Vynasob (double cislo1, double cislo2, double cislo3)
        {
            double vysledek = cislo1 * cislo2 * cislo3;
            return vysledek;
        }
    }
}
