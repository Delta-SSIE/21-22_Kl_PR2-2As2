using System;

namespace _11_OOP_060_Pes_II
{
    class Program
    {
        public static void Main(string[] args)
        {

            Pes lord = new Pes();
            try
            {
                lord.SetJmeno("Lord");
                lord.SetNohy(4);
                lord.SetOckovany(true);
                Console.WriteLine(lord.PredstavSe());
            }
            catch (Exception e)
            {
                Console.WriteLine("Byla vložena neplatná hodnota ({0})", e.Message);
            }

            try
            {
                Pes podvratak = new Pes();
                podvratak.SetJmeno("Vořech");
                podvratak.SetNohy(3);
                podvratak.SetOckovany(false);
                Console.WriteLine(podvratak.PredstavSe());
            }
            catch (Exception e)
            {
                Console.WriteLine("Byla vložena neplatná hodnota ({0})", e.Message);
            }

            try
            {
                Pes mutant = new Pes();
                mutant.SetJmeno("Mutantík");
                mutant.SetNohy(5);
                mutant.SetOckovany(false);
                Console.WriteLine(mutant.PredstavSe());
            }
            catch (Exception e)
            {
                Console.WriteLine("Byla vložena neplatná hodnota ({0})", e.Message );
            }

            try
            {
                Pes slechtic = new Pes();
                slechtic.SetJmeno("Juan Ricardo Esteban Rodriquez de La Santorini");
                slechtic.SetNohy(3);
                slechtic.SetOckovany(false);
                Console.WriteLine(slechtic.PredstavSe());
            }
            catch (Exception e)
            {
                Console.WriteLine("Byla vložena neplatná hodnota ({0})", e.Message);
            }

        }

    }
}
