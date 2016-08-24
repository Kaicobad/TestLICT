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

           int x = a + b; ;

            a = x - a;
            b = x - b;

            Console.WriteLine("a =\t"+a);
            Console.WriteLine("b =\t"+b);

            Console.ReadLine();
        }
    }
}
