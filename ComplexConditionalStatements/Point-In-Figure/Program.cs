using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_In_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int x1 = 0;
            int y1 = 0;
            int x2 = 2 * h;
            int y2 = 4 * h;

            bool isInside = (x > x1 || x < x2) && (y > y1 || y < y2);
            bool isOutSide = (x < x1 || x > x2) && (y < y1 || y > y2);
            bool isOnBorder = (x == x1 || x == x2) && (y == y1) || (y == y2);

            if (isInside)
            {
                Console.WriteLine("inside");

            }
            else if (isOutSide)
            {
                Console.WriteLine("outside");
            }
            else
            {
                Console.WriteLine("border");
            }



        }
    }
}
