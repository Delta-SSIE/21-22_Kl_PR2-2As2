using System;
using System.Linq;

namespace _11_OOP_050_Prebirani_pole
{
    class Program
    {
        public static void Main(string[] args)
        {

            //vytvoříme jeden zkušební objekt
            Person tom = new Person
            {
                Name = "Tom",
                Surname = "Riddle",
                Age = 9,
                Sex = SexType.Male
            };

            //ověříme, že jsme správně zapsali jeho představení
            //Console.WriteLine(tom.IntroduceSelf());

            // nyní připravíme pole osob
            Person[] friends = new Person[]
            {
                new Person {
                    Name = "Thomas",
                    Surname = "Carter",
                    Age = 17,
                    Sex = SexType.Male
                },
                new Person {
                    Name = "Lillian",
                    Surname = "Carter",
                    Age = 19,
                    Sex = SexType.Female
                },
                new Person {
                    Name = "Jim",
                    Surname = "Pearson",
                    Age = 54,
                    Sex = SexType.Male
                },
                new Person {
                    Name = "Lou",
                    Surname = "Lacey",
                    Age = 36,
                    Sex = SexType.Female
                },
                new Person {
                    Name = "Minnie",
                    Surname = "Stanfords",
                    Age = 84,
                    Sex = SexType.Female
                },
                new Person {
                    Name = "Quincy",
                    Surname = "Dean",
                    Age = 12,
                    Sex = SexType.Male
                },
                new Person {
                    Name = "Steve",
                    Surname = "Blake",
                    Age = 61,
                    Sex = SexType.Male
                },
                new Person {
                    Name = "Andrew",
                    Surname = "Holmes",
                    Age = 33,
                    Sex = SexType.Male
                }
            };

            FindKids(friends);
            Console.WriteLine();
            FindWomen(friends);

            Console.WriteLine();
            Console.WriteLine();

            FindKids2(friends);
            Console.WriteLine();
            FindWomen2(friends);

            Console.WriteLine();
            Console.WriteLine();

            FindKids3(friends);
            Console.WriteLine();
            FindWomen3(friends);


        }
        static void FindKids(Person[] list)
        {
            // projde celý seznam - pole list a na dětech (ty jsou pod 18 let) zavolá metodu IntroduceSelf()
            // dospělých si nevšímá
            foreach (Person person in list)
            { 
                if (person.Age < 18)
                {
                    Console.WriteLine( person.IntroduceSelf() );
                }        
            }
        }

        static void FindWomen(Person[] list)
        {
            // projde celý seznam - pole list a na ženách zavolá metodu IntroduceSelf()
            // chlapů si nevšímá
            foreach (Person person in list)
            {
                if (person.Sex == SexType.Female)
                {
                    Console.WriteLine( person.IntroduceSelf() );
                }
            }
        }

        static void FindKids2(Person[] list)
        {
            foreach (Person person in list.Where( x => x.Age < 18))
            {
                Console.WriteLine(person.IntroduceSelf());
            }
        }
        static void FindWomen2(Person[] list)
        {
            foreach (Person person in list.Where(x => x.Sex == SexType.Female))
            {
                Console.WriteLine(person.IntroduceSelf());
            }
        }

        static void FindAnybody(Person[] list, Func<Person, bool> filter)
        {
            foreach (Person person in list)
            {
                if (filter(person))
                    Console.WriteLine(person.IntroduceSelf());
            }
        }

        static void FindKids3(Person[] list)
        {
            FindAnybody(list, x => x.Age < 18);
        }

        static bool IsWoman(Person p)
        {
            return p.Sex == SexType.Female;
        }

        static void FindWomen3(Person[] list)
        {
            FindAnybody(list, IsWoman);
        }
    }
}

