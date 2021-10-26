using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP_03_Ctyrlistek_I
{
    enum Rasa { Pes, Kočka, Zajíc, Prase };
    class KomiksovaPostava
    {
        public string Jmeno;
        public Rasa Rasa; public bool JeStastny;
        public string[] OblibenaJidla;
        public int[] StastnaCisla;
        public string SeznamJidel()
        {
            return string.Join(", ", OblibenaJidla);
        }
    }

}
