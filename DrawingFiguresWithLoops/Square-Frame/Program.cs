using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string topAndBottRow = "+ ";
            for (int i = 0; i < n-2; i++)
            {
                topAndBottRow += "- ";
            }
            topAndBottRow += "+";
            
            string middleRow = "| ";
            for (int i = 0; i < n - 2; i++)
            {
                middleRow += "- ";
            }
            middleRow += "|";
            Console.WriteLine(topAndBottRow);

            for (int i = 0; i < n-2; i++)
            {
                Console.WriteLine(middleRow);
            }
            Console.WriteLine(topAndBottRow);

        }
    }
}
