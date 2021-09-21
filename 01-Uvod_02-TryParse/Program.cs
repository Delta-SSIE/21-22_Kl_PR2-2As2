using System;

namespace _01_Uvod_02_TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Napiš celé číslo: ");
            //string nacteno = Console.ReadLine();

            //int cislo = int.Parse(nacteno);
            //int cislo = Convert.ToInt32(nacteno);


            //int cislo;            
            //if (int.TryParse(nacteno, out cislo)) 
            //{  
            //    Console.WriteLine($"Napsal jsi {cislo}.");
            //}
            //else
            //{
            //    Console.WriteLine("To není celé číslo.");
            //}

            Console.WriteLine("Napiš celé číslo: ");
            string nacteno = Console.ReadLine();
            int cislo;

            while (!int.TryParse(nacteno, out cislo))
            {
                Console.WriteLine("Má to být celé číslo, truhlíku!");
                nacteno = Console.ReadLine();
            }

            Console.WriteLine($"Napsal jsi {cislo}.");

        }
    }
}
