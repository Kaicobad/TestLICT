using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstromgNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number, Reminder, Sum = 0;

            Console.WriteLine("enter the number:");
            Number = Convert.ToInt32(Console.ReadLine());

            for (int i = Number; i > 0; i = i / 10)
            {
                Reminder = i % 10;
                //Number = Number / 10;
                Sum = Sum + Reminder * Reminder * Reminder;
            }
            if (Sum==Number)
            {
                Console.WriteLine("the number is armstrog");
            }
            else
            {
                Console.WriteLine("number is not armstrong");
               
            }
            Console.ReadLine();

        }
    }
}
