using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020_Pes
{
    class Pes
    {
        public string Jmeno;
        public int Nohy;
        public bool JeOckovany;

        public string PredstavSe()
        {
            return $"Já jsem pes, jmenuju se {Jmeno}, mám {Nohy} nohy a {(JeOckovany ? "jsem očkovaný" : "nejsem očkovaný")}";
        }
    }
}
