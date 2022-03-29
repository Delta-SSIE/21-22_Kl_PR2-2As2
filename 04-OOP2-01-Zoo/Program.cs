using System;

namespace _04_OOP2_01_Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Kun ferda = new Kun("Ferda");
            //ferda.Cvalej();
            //ferda.Dychej();

            Velryba mobyDick = new Velryba("Moby Dick");
            //mobyDick.Plav();
            //mobyDick.Dychej();

            ////ferda.Plav(); //nejde, ferda není velryba

            Savec blesk = new Kun("Blesk");
            ////blesk.Cvalej() // nelze, blesk je sice kun, ale mam ulozeno jen jako savec
            //Kun bleskJinak = (Kun)blesk;

            ////Velryba hybrid = (Velryba)blesk; //nelze, blesk je kun, ne velryba, ale prostredi nezachyti, je to az runtime error

            Savec[] zoo = new Savec[3];
            zoo[0] = ferda;
            zoo[1] = mobyDick;
            zoo[2] = blesk;

            foreach (Savec zvire in zoo)
            {
                zvire.OzviSe();
            }

            // Savec chimera = new Savec(); //nejde - je abstraktní

        }
    }
}
