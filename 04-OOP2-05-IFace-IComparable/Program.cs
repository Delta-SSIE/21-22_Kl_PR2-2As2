using System;

namespace _04_OOP2_05_IFace_IComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            Strom[] sad = new Strom[]
            {
                new Strom() {Druh = "Jabloň", Vyska = 5.5},
                new Strom() {Druh = "Smrk", Vyska = 12},
                new Strom() {Druh = "Hrušeň", Vyska = 8.2},
                new Strom() {Druh = "Třešeň", Vyska = 3.3},
                new Strom() {Druh = "Švestka", Vyska = 4.1}
            };

            foreach (Strom strom in sad)
            {
                Console.WriteLine($"{strom.Druh}: {strom.Vyska}");
            }

            Console.WriteLine();

            Array.Sort(sad);

            foreach (Strom strom in sad)
            {
                Console.WriteLine($"{strom.Druh}: {strom.Vyska}");
            }
        }
    }
    class Strom : IComparable
    {
        public string Druh { get; set; }
        public double Vyska { get; set; }

        public int CompareTo(object obj)
        {
            Strom druhy = obj as Strom;
            if (druhy == null)
                return 1;
            return Vyska.CompareTo(druhy.Vyska);
        }

        //int IComparable.CompareTo(object obj)
        //{
        //    Strom druhy = obj as Strom;
        //    if (druhy == null)
        //        return 1;
        //    return Math.Sign(this.Vyska - druhy.Vyska);
        //}

        //public int CompareTo(object obj)
        //{
        //    Strom druhy = obj as Strom;
        //    if (druhy == null)
        //        return 1;

        //    if (this.Vyska < druhy.Vyska)
        //        return -1;
        //    else if (this.Vyska == druhy.Vyska)
        //        return 0;
        //    else
        //        return 1;

        //    //return Math.Sign(this.Vyska - druhy.Vyska);
        //}
    }
}
