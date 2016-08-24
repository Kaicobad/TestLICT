using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapingBetwwnNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            int b = 10;

            a = a + b - a;
            b = a + b - a;

            Console.WriteLine("a is:",a);
            Console.WriteLine("b is:",b);

            Console.ReadLine();
        }
    }
}
