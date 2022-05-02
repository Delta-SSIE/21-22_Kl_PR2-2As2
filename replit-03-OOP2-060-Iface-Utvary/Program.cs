using System;

namespace replit_03_OOP2_060_Iface_Utvary
{
    class Program
    {
        static void Main(string[] args)
        {
            Obdelnik o = new Obdelnik(10, 5);
            Ctverec c = new Ctverec(5);
            Trojuhelnik t = new Trojuhelnik(3, 4, 5);
            Kruh k = new Kruh(2);

            IUtvar[] utvary = new IUtvar[4];
            utvary[0] = o;
            utvary[1] = c;
            utvary[2] = t;
            utvary[3] = k;

            double sumObvod = 0;
            double sumObsah = 0;
            foreach(IUtvar u in utvary)
            {
                Console.WriteLine(u.ToString());
                sumObvod += u.GetObvod();
                sumObsah += u.GetObsah();
            }
            Console.WriteLine("Obvod celkem: " + sumObvod);
            Console.WriteLine("Obsah celkem: " + sumObsah);


        }

        static void Popis(IUtvar utvar)
        {
            Console.WriteLine($"{utvar.Nazev} má obvod {utvar.GetObvod()} a obsah {utvar.GetObsah()}");

        }
    }
}
