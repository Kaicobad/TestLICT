using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, rem, sum = 0;
            Console.WriteLine("enter the number:");
            num = Convert.ToInt32(Console.ReadLine());
            while(num > 0)
            {
                rem = num % 10;
                sum += rem;
                num = num / 10;
            }
            Console.WriteLine("sum of digit:"+sum);
            Console.ReadLine();
            
        }
    }
}
