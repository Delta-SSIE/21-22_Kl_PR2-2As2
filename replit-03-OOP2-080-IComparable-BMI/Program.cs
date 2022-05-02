using System;

namespace replit_03_OOP2_080_IComparable_BMI
{
    class Program
    {
        public static void Main(string[] args)
        {
            Clovek pepa = new Clovek("Josef", 95, 175);
            Clovek majka = new Clovek("Marie", 53, 162);
            Clovek jarda = new Clovek("Jaroslav", 120, 170);
            Clovek tonca = new Clovek("Antonie", 72, 178);
            Clovek kaja = new Clovek("Karel", 63, 178);
            Clovek tom = new Clovek("Tomáš", 94, 201);

            Clovek[] lide = { pepa, majka, jarda, tonca, kaja, tom };
            Array.Sort(lide);

            Console.WriteLine("Pole lidé po setřízení:");
            foreach (Clovek c in lide)
                Console.WriteLine(c);
        }
    }
}
