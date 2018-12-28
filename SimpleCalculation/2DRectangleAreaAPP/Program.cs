using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DRectangleAreaAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please insert x1: ");
            var x1 = double.Parse(Console.ReadLine());

            Console.Write("Please insert y1: ");
            var y1 = double.Parse(Console.ReadLine());

            Console.Write("Please insert x2: ");
            var x2 = double.Parse(Console.ReadLine());

            Console.Write("Please insert y2: ");
            var y2 = double.Parse(Console.ReadLine());

            var weight = Math.Max(x1, x2) - Math.Min(x1, x2);
            var height = Math.Max(y1, y2) - Math.Min(y1, y2);
            Console.WriteLine("Area is = " + (weight * height));
            Console.WriteLine("Perimeter is = " + (2*(weight+height)));
                        }
    }
}
