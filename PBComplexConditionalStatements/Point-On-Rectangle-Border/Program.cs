using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_On_Rectangle_Border
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double targetX = double.Parse(Console.ReadLine());
            double targetY = double.Parse(Console.ReadLine());

            bool isYbetween = targetY >= y1 && targetY <= y2;
            bool isXOnBorder = (targetX == x1 || targetX == x2) && isYbetween;

            bool isXbetween = targetX >= x1 && targetX <= x2;
            bool isYOInBorder = (targetY == y1 || targetY == y2) && isXbetween;

            if (isXOnBorder || isYOInBorder)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }


        }
    }
}
