using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsiusToFarenhaitApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Celsius value of degrees: ");
            var celsius = double.Parse(Console.ReadLine());
            var farenhait = (celsius * 1.8) + 32;

            Console.WriteLine("Farenhait value of degrees: " + Math.Round(farenhait, 2));


        }
    }
}
