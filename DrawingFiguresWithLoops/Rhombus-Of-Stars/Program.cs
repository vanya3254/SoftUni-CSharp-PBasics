using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhombus_Of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int whiteSpaces = n - 1;
            for (int row = 1; row <= n; row++)
            {
                for (int spacesCount = 1; spacesCount <= whiteSpaces; spacesCount++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int starsCount = 1; starsCount < row; starsCount++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
                whiteSpaces--;           

            }
            whiteSpaces = 1;
            for (int row = 1; row <= n-1; row++)
            {
                for (int spacesCount = 1; spacesCount <= whiteSpaces; spacesCount++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int starsCount = 1; starsCount <= n-1-row; starsCount++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
                whiteSpaces++;
            }
        }
    }
}
