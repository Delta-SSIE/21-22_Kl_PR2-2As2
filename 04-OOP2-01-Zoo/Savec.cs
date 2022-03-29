using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP2_01_Zoo
{
    abstract class Savec
    {
        protected string Jmeno { get; private set; }

        public Savec(string jmeno)
        {
            Jmeno = jmeno;
            //Console.WriteLine("Narodil se savec");
        }

        public void Dychej()
        {
            Console.WriteLine("Nádech - výdech ...");
        }
        public void SajMleko()
        {
            Console.WriteLine("Mňam");
        }
        //public virtual void OzviSe()
        //{
        //    Console.WriteLine("Dělám zvuk");
        //}
        public abstract void OzviSe();
    }
}
