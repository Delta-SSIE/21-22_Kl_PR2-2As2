using System;

namespace _02_OOP_04_Kruznice_II
{
    class Program
    {
        static void Main(string[] args)
        {
            //try 
            //{ 
            //    int.Parse(Console.ReadLine());
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Co to píšeš, truhlíku!");
            //}
            Kruznice o = new Kruznice(-1);

            Kruznice k = new Kruznice();
           
            Console.WriteLine($"Kružnice o poloměru {k.GetPolomer()} cm má obvod {k.SpoctiObvod():0.00} cm a obsah {k.SpoctiObsah():0.00} cm^2.");

            Kruznice l = new Kruznice(1);

            Console.WriteLine($"Kružnice o poloměru {l.GetPolomer()} cm má obvod {l.SpoctiObvod():0.00} cm a obsah {k.SpoctiObsah():0.00} cm^2.");
        }

        //static int Secti(int a, int b)
        //{
        //    return a + b;
        //}

        //static int Secti(int a, int b, int c)
        //{
        //    return a + b + c;
        //}

        //static double Secti(double a, double b)
        //{
        //    return a + b;
        //}

    }
}
