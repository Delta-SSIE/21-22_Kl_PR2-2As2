using System;

namespace _04_OOP2_04_Iface_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Bicykl kolo = new Bicykl(40);
            Sekacka sekacka = new Sekacka(4);
            Motocykl babetta = new Motocykl(1, 42, 22);

            IPojizdny koloJinak = kolo;
            IPojizdny[] jezditka = new IPojizdny[] { kolo, sekacka, babetta };
            Console.WriteLine("celkem to má " + SpocitejKola(jezditka) + " kol.");

            IMotorovy babettaJinak = babetta;
            IMotorovy[] motorizace = new IMotorovy[] { babetta, new StrunovaSekacka(5) };
        }

        static int SpocitejKola(IPojizdny[] pojizdneVeci)
        {
            int pocet = 0;
            foreach (IPojizdny vec in pojizdneVeci)
            {
                pocet += vec.PocetKol;
            }
            return pocet;
        }
    }
    enum TypMotoru
    {
        Benzin,
        Diesel,
        Elektro,
        Vodik,
        Plyn
    }
    interface IPojizdny
    {
        int PocetKol { get; }
    }
    interface IMotorovy
    {
        TypMotoru Motor { get; }
        int MaxVykon { get; }
        void Napln();
    }
    class Sekacka : IPojizdny
    {
        public int PocetKol { get; private set; }

        public Sekacka(int pocetKol)
        {
            PocetKol = pocetKol;
        }
    }
    abstract class DopravniProstredek
    {
        public int Pasazeri { get; private set; }
        public int MaxRychlost { get; private set; }
        public string Popis { get; private set; }

        public DopravniProstredek(int pasazeri, int maxRychlost, string popis)
        {
            Pasazeri = pasazeri;
            MaxRychlost = maxRychlost;
            Popis = popis;
        }
    }

    class Bicykl : DopravniProstredek, IPojizdny
    {

        public Bicykl(int maxRychlost) : base(1, maxRychlost, "Jízdní kolo")
        {
        }

        public int PocetKol => 2;
        //public int PocetKol
        //{
        //    get
        //    {
        //        return 2;
        //    }
        //}
    }

    class Motocykl : DopravniProstredek, IPojizdny, IMotorovy
    {
        public Motocykl(int pasazeri, int maxRychlost, int maxVykon) : base(pasazeri, maxRychlost, "Motocykl")
        {
            MaxVykon = maxVykon;
        }
        public int PocetKol => 2;

        public TypMotoru Motor => TypMotoru.Benzin;

        public int MaxVykon { get; private set; }

        public void Napln()
        {
            Console.WriteLine("Tankuju na beznince");
        }
    }

    class StrunovaSekacka : IMotorovy
    {
        public TypMotoru Motor => TypMotoru.Benzin;
        public int MaxVykon { get; private set; }
        public void Napln()
        {
            Console.WriteLine("Dolévám benzín do nádrže");
        }

        public StrunovaSekacka(int maxVykon)
        {
            MaxVykon = maxVykon;
        }
    }
}
