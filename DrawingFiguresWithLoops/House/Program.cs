using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //int starsCount = if n% 2 == 0 ? 2 else 1
            int starsCount = n%2 ==0 ?2 :1;
            int roofTopRows = (n + 1)/ 2;
            for (int i = 0; i < roofTopRows; i++)
            {
                int dashesCount = (n - starsCount) / 2;
                string dashes = new string('-', dashesCount);
                string stars = new string('*', starsCount);
                Console.WriteLine("{0}{1}{0}", dashes, stars);
                starsCount += 2;
            }


        }
    }
}
