using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            double oddSum = 0.0;
            double oddMin = 10000000000.0;
            double oddMax = -10000000000.0;

            double evenSum = 0.0;
            double evenMin = 10000000000.0;
            double evenMax = -10000000000.0;

            for (int i = 0; i < n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    oddSum += number;

                    if (number > oddMax)
                    {
                        oddMax = number;
                    }


                    if (number < oddMin)
                    {
                        oddMin = number;
                    }

                }
                else
                {
                    evenSum += number;
                    if (number > evenMax)
                    {
                        evenMax = number;
                    }

                    if (number < evenMin)
                    {
                        evenMin = number;
                    }
                }              

            }
            
                Console.WriteLine($"OddSum = {oddSum}");
            if (oddMin == 10000000000.0)
            {
                Console.WriteLine("OddMin = No");
            }
            else
            {
                Console.WriteLine($"OddMin = {oddMin}");
            }
            if (oddMax == -10000000000.0)
            {
                Console.WriteLine("OddMax = No");
            }
            else
            {
                Console.WriteLine($"OddMax = {oddMax}");
            }

                Console.WriteLine($"EvenSum = {evenSum}");
            if (evenMin == 10000000000.0)
            {
                Console.WriteLine("EvenMin = No");
            }
            else
            {
                Console.WriteLine($"EvenMin = {evenMin}");
            }
            if (evenMax == -10000000000.0)
            {
                Console.WriteLine("EvenMax = No");
            }
            else
            {
                Console.WriteLine($"EvenMax = {evenMax}");
            }


                      
        }
    }
}
