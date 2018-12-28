using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USDtoBGNApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("USD: ");
            var usd = double.Parse(Console.ReadLine());
            var leva = usd * 1.79549;

            Console.WriteLine("Leva: " + Math.Round(leva, 2));

        }
    }
}
