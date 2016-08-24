using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;        //taking integer spaces in memory spces
            i = 2;              // initializing i variable with value 2
            j = 10;             //intializing j variable with value 10
                if(i!=0)
                {
                    Console.WriteLine("its not equal to zero");

                    k = j / i; //initializing k with dividation of i and j
                    Console.WriteLine("j devided by i is:" + k);
                    Console.ReadLine();
                }
        }
    }
}
