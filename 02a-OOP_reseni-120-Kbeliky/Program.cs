using System;

namespace _11_OOP_120_Kbeliky
{
    class Program
    {
        static void Main(string[] args)
        {
            Nadoba trilitrak = new Nadoba(3);
            Nadoba petilitrak = new Nadoba(5);
            petilitrak.Napln();
            petilitrak.PrelejDo(trilitrak);

            Console.WriteLine(trilitrak);
            Console.WriteLine(petilitrak);

            Console.WriteLine();

            // 4 litry
            trilitrak = new Nadoba(3);
            petilitrak = new Nadoba(5);
            petilitrak.Napln();
            petilitrak.PrelejDo(trilitrak);
            trilitrak.Vylij();
            petilitrak.PrelejDo(trilitrak);
            petilitrak.Napln();
            petilitrak.PrelejDo(trilitrak);
            trilitrak.Vylij();
            Console.WriteLine(petilitrak);
        }
    }
}
