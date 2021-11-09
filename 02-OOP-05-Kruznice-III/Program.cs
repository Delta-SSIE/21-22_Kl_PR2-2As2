using System;

namespace _02_OOP_05_Kruznice_III
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            { 
                Kruznice o = new Kruznice(-1);
            }
            catch
            {
                Console.WriteLine("Nesmyslná hodnota poloměru.");
            }



            Kruznice k = new Kruznice();

            Console.WriteLine($"Kružnice o poloměru {k.Polomer} cm má obvod {k.SpoctiObvod():0.00} cm a obsah {k.Obsah:0.00} cm^2.");

            Kruznice l = new Kruznice(1);
            //l.Polomer = 4; //nelze, pokud máme private set

            Console.WriteLine($"Kružnice o poloměru {l.Polomer} cm má obvod {l.SpoctiObvod():0.00} cm a obsah {k.Obsah:0.00} cm^2.");

            // l.Obsah = 6; nelze - není setter, je readonly
        }
    }
}
