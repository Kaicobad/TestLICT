using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int rem, reverse_num = 0;
            Console.WriteLine("Enter the Number:");
            int num = Convert.ToInt32(Console.ReadLine());

            while (num > 0)
            {
                rem = num % 10;
                reverse_num = reverse_num * 10 + rem;
                num = num / 10;
            }
            

            Console.WriteLine("reverse number is :"+reverse_num);
             
            Console.ReadLine();

            return;
        }
    }
}
