using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaTriangleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a :");
            var a = double.Parse(Console.ReadLine());
            Console.Write("Enter h :");
            var h = double.Parse(Console.ReadLine());
            var area = a * h / 2;

            Console.WriteLine("Triangle area = " + Math.Round(area, 2));
        }
    }
}
