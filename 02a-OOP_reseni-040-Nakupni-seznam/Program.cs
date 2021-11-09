using System;

namespace _040_Nakupni_seznam
{
    class Program
    {
        public static void Main(string[] args)
        {
            // kód metody Main si jen prohlédněte ale neměňte

            Polozka[] seznam = new Polozka[3]; //nákupní seznam představuje pole se 3 položkami, zatím prázdnými

            Polozka vejce = new Polozka(); //vytvořím novou položku
            vejce.Nazev = "vejce";
            vejce.Pocet = 12;
            seznam[0] = vejce; //uložím ji do seznamu

            seznam[1] = new Polozka(); // mohu i bez dočasné proměnné
            seznam[1].Nazev = "rohlíky";
            seznam[1].Pocet = 10;

            seznam[2] = new Polozka //mohu použít inicializaci jako je v ukázce z videa
            {
                Nazev = "chleba",
                Pocet = 1
            };

            //teď je seznam naplněn. Dokážete ho vypsat?
            VypisSeznam1(seznam);
            VypisSeznam2(seznam);
        }

        public static void VypisSeznam1(Polozka[] nakupniSeznam)
        {
            foreach (Polozka polozka in nakupniSeznam)
            {
                Console.WriteLine($"{polozka.Pocet}x {polozka.Nazev}");
            }
        }

        public static void VypisSeznam2(Polozka[] nakupniSeznam)
        {
            for (int i = 0; i < nakupniSeznam.Length; i++)
            {
                Console.WriteLine($"{nakupniSeznam[i].Pocet}x {nakupniSeznam[i].Nazev}");
            }
        }
    }
}
