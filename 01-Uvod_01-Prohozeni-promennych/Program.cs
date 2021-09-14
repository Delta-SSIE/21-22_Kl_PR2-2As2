using System;

namespace _01_Uvod_01_Prohozeni_promennych
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;

            //double quotient = (double)x / y;
            //Console.WriteLine($"Podíl je {quotient}");

            //temporary variable

            //int temp = x;
            //x = y;
            //y = temp;


            //destructuring
            //(x, y) = (y, x);


            //odčítání
            //x = x + y;
            //y = x - y;
            //x = x - y;


            //xor

            x = x ^ y;
            y = x ^ y;
            x = x ^ y;

            Console.WriteLine($"x:{x}, y:{y}");

        }
    }
}
