using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_OOP_100_Pes_III
{

    class Pes
    {
        private string _jmeno;
        public string Jmeno { 
            get
            {
                return _jmeno;
            } 
            private set
            {
                if (value.Contains(' '))
                    throw new ArgumentException("Name can be only one word.");

                _jmeno = value; //v případě kolize názvů musím použít this pro přístup k vlastnostem a metodám objektu
            }
        }

        private int _nohy;
        public int Nohy { 
            get
            {
                return _nohy;
            }
            set
            {
                if (value < 0 || value > 4)
                    throw new ArgumentOutOfRangeException("Invalid leg count (for a dog)");
                else if (value > _nohy)
                    throw new ArgumentException("Once lost, dog's legs don't grow");
                else
                    _nohy = value;
            }
        }

        public Pes(string jmeno)
        {
            _nohy = 4;
            Jmeno = jmeno;
            JeOckovany = false;
        }

        public bool JeOckovany { get; private set; }

        public void Ockuj()
        {
            JeOckovany = true;
        }

        public string PredstavSe()
        {
            return $"Já jsem pes, jmenuju se {Jmeno}, mám {Nohy} nohy a {(JeOckovany ? "jsem" : "nejsem")} očkovaný.";
        }
    }
}
