using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_OOP_050_Prebirani_pole
{
    enum SexType : byte { Male, Female }

    class Person
    {
        public string Name;
        public string Surname;
        public int Age;
        public SexType Sex;

        public string IntroduceSelf()
        {
            return $"{Surname}, {Name}, ({(Sex == SexType.Male ? "Male" : "Female")}, {Age} years)";
        }
    }
}
