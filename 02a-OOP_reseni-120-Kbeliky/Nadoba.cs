using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_OOP_120_Kbeliky
{
    class Nadoba
    {
        public double Objem { get; private set; }
        public double ObjemVody { get; private set; }
        public double VolnyObjem
        {
            get { return Objem - ObjemVody; }
        }

        public Nadoba(double objem)
        {
            if (objem <= 0)
                throw new ArgumentOutOfRangeException();

            Objem = objem;
            ObjemVody = 0;
        }

        public void Napln()
        {
            ObjemVody = Objem;
        }

        public void Vylij()
        {
            ObjemVody = 0;
        }

        public void PrelejDo(Nadoba druhaNadoba)
        {
            double prelito;
            if (druhaNadoba.VolnyObjem >= this.ObjemVody)
                prelito = this.ObjemVody;
            else
                prelito = druhaNadoba.VolnyObjem;

            druhaNadoba.ObjemVody += prelito;
            this.ObjemVody -= prelito;
        }

        public void Prilej(Nadoba druhaNadoba)
        {
            druhaNadoba.PrelejDo(this);
        }

        public override string ToString()
        {
            return $"Nádoba ({ObjemVody} l z max. {Objem})";
        }

    }
}
