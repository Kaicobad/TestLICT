using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;  //declaring the variables
            int sum;
            int prduct;
            sum = 0;
            prduct = 1;

            for(i=1; i<=10; i++)
                {
                    sum = sum + i;
                    prduct = prduct * i;
                }
            Console.WriteLine("the sum of 1 to 10 is :" + sum);
                Console.WriteLine();
                Console.WriteLine("the product is:"+prduct);
            Console.ReadLine();
        }
    }
}
