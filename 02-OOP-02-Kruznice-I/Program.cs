using System;

namespace _02_OOP_02_Kruznice_I
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Kruznice k = new Kruznice();
            k.Polomer = 1;

            Console.WriteLine($"Kružnice o poloměru {k.Polomer} cm má obvod {k.SpoctiObvod():0.00} cm a obsah {k.SpoctiObsah():0.00} cm^2.");
        }
    }
}
