using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_In_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            while (n <= 0 || n >= 100)
            {
                Console.WriteLine("Invalid Number");
                Console.WriteLine("Enter number in the range[1...100]");
                n = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Number is valid");
            Console.WriteLine("The number is: " + n);
        }
    }
}
