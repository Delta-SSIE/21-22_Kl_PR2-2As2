using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_OOP_030_CD_Disky
{
    class CompactDisc
    {
        public string Title;
        public string Artist;
        public int Year;
        public string[] Tracks;

        public string Description()
        {
            return $"\"{Title}\" by {Artist} was published at {Year}. It contains {Tracks.Length} tracks.";
        }
    }
}
