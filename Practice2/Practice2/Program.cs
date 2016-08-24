using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a, b, c;
            a = 10;
            b = 13;

            if(a<b)
            {
                Console.WriteLine("a is less then b");
            }
            if (a == b)
            {
                Console.WriteLine("dont print this");
            }
            Console.WriteLine();

            c = a - b;

            if (c == 0 && c>0 && c ==1)
            {
                Console.WriteLine("c is positve or non negative");
            }
            if (c < 0)
            {
                Console.WriteLine("c is  negative");
            }

            Console.ReadLine();
        }
    }
}
