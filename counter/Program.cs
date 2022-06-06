using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace counter
{
    class Counter
    {
        public int count;

        public int increment()
        {
            count += 1;
            return count;
        }

        public int decrement()
        {
            count -= 1;
            return count;
        }

        public void currentCount()
        {
            Console.WriteLine(count);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Counter c1 = new Counter();
            c1.count = 0;

            while (true)
            {
                Console.WriteLine("Type (+) or (-) : ");
                string s = Console.ReadLine();
                if (s == "+")
                {
                    c1.increment();
                    c1.currentCount();
                }
                else if (s == "-")
                {
                    c1.decrement();
                    c1.currentCount();
                }
                else
                {
                    Console.WriteLine("Unknown operation.");
                }
            }
        }
    }
}
