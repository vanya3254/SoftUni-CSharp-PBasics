using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int starsCount = n % 2 == 0 ? 2 : 1;
            int dashesCount = (n - starsCount) / 2;

            for (int i = 0; i < (n+1)/2; i++)
            {
                string dashes = new string('-', dashesCount);
                string middleDashes = new string('-', n - (dashesCount * 2) -1);
                Console.WriteLine("{0}*{1}{0}", dashes, middleDashes);
                dashesCount--;
            }

        }
    }
}
