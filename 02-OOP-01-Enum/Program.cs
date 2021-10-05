using System;

namespace _02_OOP_01_Enum
{
    enum Obdobi : byte { Jaro, Leto, Podzim, Zima, Fujtajbl = Podzim };

    class Program
    {
        static void Main(string[] args)
        {
            Obdobi chladne = Obdobi.Jaro;
            Console.WriteLine(chladne);

            Obdobi teple = chladne + 1;
            Console.WriteLine(teple);

            Obdobi dalsi = teple + 2;
            Console.WriteLine(dalsi);

            dalsi++;
            Console.WriteLine(dalsi);

            Obdobi barevne = (Obdobi)2;
            Console.WriteLine(barevne);

            //char pismeno = (char)('a' + 3);

            dalsi = (Obdobi)255;
            dalsi++;
            Console.WriteLine(dalsi);

            
        }
    }
}
