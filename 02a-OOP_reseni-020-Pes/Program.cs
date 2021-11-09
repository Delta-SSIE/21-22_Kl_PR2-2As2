using System;

namespace _020_Pes
{
    class Program
    {
        static void Main(string[] args)
        {
            //tento kód není třeba měnit

            Pes lord = new Pes();
            lord.Jmeno = "Lord";
            lord.Nohy = 4;
            lord.JeOckovany = true;

            Console.WriteLine(lord.PredstavSe());


            Pes podvratak = new Pes();
            podvratak.Jmeno = "Vořech";
            podvratak.Nohy = 3;
            podvratak.JeOckovany = false;

            Console.WriteLine(podvratak.PredstavSe());

        }
    }
}
