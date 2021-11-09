using System;

namespace _11_OOP_030_CD_Disky
{
    class Program
    {
        static void Main(string[] args)
        {
            CompactDisc CD = new CompactDisc();
            CD.Title = "Když jde malý bobr spát";
            CD.Artist = "Petr Skoumal";
            CD.Year = 1992;

            //CD.Tracks = new string[3];
            //CD.Tracks[0] = "Prvni";
            //CD.Tracks[1] = "Druhy";
            //CD.Tracks[2] = "Treti";
            CD.Tracks = new string[] { "Prvni", "Druhy", "Treti" };

            Console.WriteLine(CD.Description());
        }
    }
}
