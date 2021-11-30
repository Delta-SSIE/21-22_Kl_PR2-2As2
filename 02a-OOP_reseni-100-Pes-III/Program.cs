using System;

namespace _11_OOP_100_Pes_III
{
    class Program
    {
        static void Main(string[] args)
        {
            Pes lord = new Pes("Lord");
            try
            {
                lord.Ockuj();
                Console.WriteLine(lord.PredstavSe());
            }
            catch (Exception e)
            {
                Console.WriteLine("Byla vložena neplatná hodnota ({0})", e.Message);
            }

            try
            {
                Pes podvratak = new Pes("Vořech");
                podvratak.Nohy = 3;
                Console.WriteLine(podvratak.PredstavSe());
            }
            catch (Exception e)
            {
                Console.WriteLine("Byla vložena neplatná hodnota ({0})", e.Message);
            }

            try
            {
                Pes mutant = new Pes("Mutantík");
                mutant.Nohy = 5;
                Console.WriteLine(mutant.PredstavSe());
            }
            catch (Exception e)
            {
                Console.WriteLine("Byla vložena neplatná hodnota ({0})", e.Message);
            }

            try
            {
                Pes regen = new Pes("Robodog");
                regen.Nohy--;
                regen.Nohy++;
                Console.WriteLine(regen.PredstavSe());
            }
            catch (Exception e)
            {
                Console.WriteLine("Byla vložena neplatná hodnota ({0})", e.Message);
            }

            try
            {
                Pes slechtic = new Pes("Juan Ricardo Esteban Rodriquez de La Santorini");
                slechtic.Nohy = 3;
                slechtic.Ockuj();
                Console.WriteLine(slechtic.PredstavSe());
            }
            catch (Exception e)
            {
                Console.WriteLine("Byla vložena neplatná hodnota ({0})", e.Message);
            }

        }    
    }
}
