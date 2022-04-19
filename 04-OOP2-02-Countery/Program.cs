using System;

namespace _04_OOP2_02_Countery
{
    class Program
    {
        static void Main(string[] args)
        {
            //napočítáme do 5, pak resetujeme a pro jistotu vypíšeme
            Counter c = new Counter();

            Console.WriteLine(c.Count);

            for (int i = 0; i < 5; i++)
            {
                c.Next();
                Console.WriteLine(c.Count);
            }

            c.Reset();
            Console.WriteLine(c.Count); //teď by měla být nula

            Console.WriteLine();

            //napočítáme do 15, po 5
            StepCounter sc = new StepCounter(5);

            Console.WriteLine(sc.Count);

            for (int i = 0; i < 3; i++)
            {
                sc.Next();
                Console.WriteLine(sc.Count);
            }

            Console.WriteLine();

            // odpočítáme ze 100 po 10
            DownCounter dc = new DownCounter(10, 100);

            Console.WriteLine(dc.Count);
            while (!dc.IsFinished)
            {
                dc.Next();
                Console.WriteLine(dc.Count);
            }

            //zresetujeme a odpočítáme ještě jednou
            Console.WriteLine();

            dc.Reset();

            Console.WriteLine(dc.Count);
            while (!dc.IsFinished)
            {
                dc.Next();
                Console.WriteLine(dc.Count);
            }


        }
    }
    class Counter
    {
        public int Count { get; protected set; }
        public virtual void Next()
        {
            Count++;
        }
        public virtual void Reset()
        {
            Count = 0;
        }
    }
    class StepCounter : Counter
    {
        private int _step;

        public StepCounter(int step)
        {
            _step = step;
        }
        public override void Next()
        {
            Count += _step;
        }
    }
    class DownCounter : StepCounter
    {
        private int _initialValue;
        public DownCounter(int step, int initialValue) : base(-step)
        {
            _initialValue = initialValue;
            Reset();
        }
        public override void Reset()
        {
            Count = _initialValue;
        }
        //public bool IsFinished => Count <= 0;
        public bool IsFinished
        {
            get
            {
                return Count <= 0;
                //if (Count <= 0)
                //    return true;
                //else
                //    return false;
            }
        }
    }
}
