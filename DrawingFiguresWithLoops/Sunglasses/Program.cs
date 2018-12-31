using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string stars = new string('*', n * 2);
            string slashes = new string('/', n * 2 - 2);
            string whiteSpaces = new string(' ', n);
            string pipes = new string('|', n);

            for(int row = 0; row < n ; row++) 
            {
                if (row == 0 || row == n-1)
                {
                    Console.WriteLine("{0}{1}{0}", stars, whiteSpaces);
                }
                else
                {
                    if ((n-1)/2 == row)
                    {
                        Console.WriteLine("*{0}*{1}*{0}*", slashes, pipes);

                    }
                    else
                    {
                        Console.WriteLine("*{0}*{1}*{0}*", slashes, whiteSpaces);
                    }
                }
            }
        }
    }
}
