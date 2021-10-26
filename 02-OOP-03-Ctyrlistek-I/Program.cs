using System;

namespace _02_OOP_03_Ctyrlistek_I
{
    class Program
    {
        static void Main(string[] args)
        {
            //KomiksovaPostava[] ctyrlistek = new KomiksovaPostava[4];

            //KomiksovaPostava bobik = new KomiksovaPostava();
            //bobik.Jmeno = "Bobík";
            //bobik.Rasa = Rasa.Prase;
            //bobik.OblibenaJidla = new string[] { "Tlačenka", "Guláš", "Vajíčka" };

            //ctyrlistek[0] = bobik;

            //Console.WriteLine(ctyrlistek[0].OblibenaJidla[1]);


            ////Můžeme pracovat i bez dočasného objektu

            //ctyrlistek[1] = new KomiksovaPostava();
            //ctyrlistek[1].Jmeno = "Fifinka";
            //ctyrlistek[1].Rasa = Rasa.Pes;
            //ctyrlistek[1].OblibenaJidla = new string[] { "Salát" };

            KomiksovaPostava[] ctyrlistek = new KomiksovaPostava[] 
            {
                new KomiksovaPostava
                {
                    Jmeno = "Bobík",
                    Rasa = Rasa.Prase,
                    OblibenaJidla = new string[] { "Tlačenka", "Guláš", "Vajíčka" }
                },
                new KomiksovaPostava
                {
                    Jmeno = "Fifinka",
                    Rasa = Rasa.Pes,
                    OblibenaJidla = new string[] { "Salát" }
                },
                new KomiksovaPostava
                {
                    Jmeno = "Pinďa",
                    Rasa = Rasa.Zajíc,
                    OblibenaJidla = new string[] { "Salát", "Mrkev", "Rohlík" }
                },
                new KomiksovaPostava
                {
                    Jmeno = "Myšpulín",
                    Rasa = Rasa.Kočka,
                    OblibenaJidla = new string[] { "Konzerva", "Párek", "Kuře", "Pilulky" }
                }
            };

            for (int i = 0; i < ctyrlistek.Length; i++)
            {
                KomiksovaPostava p = ctyrlistek[i];
                Console.WriteLine($"{p.Jmeno}: {p.SeznamJidel()}");
            }

            foreach (KomiksovaPostava p in ctyrlistek)
            {
                Console.WriteLine($"{p.Jmeno}: {p.SeznamJidel()}");
            }





        }
    }
}
