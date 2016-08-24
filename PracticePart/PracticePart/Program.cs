using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Students Name:");
            string Name = Console.ReadLine();

            Console.WriteLine("Enter the studen's ID:");
            int Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the FirstMark:");
            int FirstMark = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the SecondMark:");
            int SecondtMark = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the ThirdMark:");
            int ThirdMark = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the FourthtMark:");
            int FourthMark = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the FifthMark:");
            int FifthMark = Convert.ToInt32(Console.ReadLine());

            double Average = (FirstMark + SecondtMark + ThirdMark + FourthMark + FifthMark) / 5;

            double TotalNumber = FirstMark + SecondtMark + ThirdMark + FourthMark + FifthMark;

            Console.WriteLine("the average of the number's:"+Average);
            Console.WriteLine("Addition of the numbers:"+TotalNumber);

            Console.ReadLine();
        }
    }
}
