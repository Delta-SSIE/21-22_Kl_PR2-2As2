using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_OOP_060_Pes_II
{
    class Pes
    {
        private string jmeno; //pro private datové položky používáme malá písmena
        private int nohy;
        private bool jeOckovany;

        public void SetJmeno(string jmeno)
        {
            if (jmeno.Contains(' '))
                throw new ArgumentException("Name can be only one word.");

            this.jmeno = jmeno; //v případě kolize názvů musím použít this pro přístup k vlastnostem a metodám objektu
        }
        public string GetJmeno()
        {
            return this.jmeno; //zde není použítí this chyba ale není ani nutné, prostředí VS to napovídá
        }

        public void SetNohy(int nohy)
        {
            if (nohy > 4 || nohy < 0)
                throw new ArgumentOutOfRangeException();

            this.nohy = nohy;
        }
        public int GetNohy()
        {
            return nohy;
        }

        public void SetOckovany(bool jeOckovany)
        {
            this.jeOckovany = jeOckovany;
        }
        public bool GetOckovany()
        {
            return jeOckovany;
        }

        public string PredstavSe()
        {
            return $"Já jsem pes, jmenuju se {jmeno}, mám {nohy} nohy a {(jeOckovany ? "jsem" : "nejsem")} očkovaný.";
        }
    }

}
