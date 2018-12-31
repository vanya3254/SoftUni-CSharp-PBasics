using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;

                if (number > max)
                {
                    max = number;
                }
            }            
            if (max == (sum-max))
            {
                Console.WriteLine($"Yes Sum = {max}");
            }
            else
            {
                int diff = Math.Abs(max - (sum-max));
                Console.WriteLine($"No Diff = {diff}");
                
            }
        }
    }
}
