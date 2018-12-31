using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine().ToLower();
            double holidays = double.Parse(Console.ReadLine());
            double weekendAtHome = double.Parse(Console.ReadLine());

            double weekendInSofia = (48 - weekendAtHome) * 3/4;
            double playsInHolidays = holidays * 2 / 3;
            double totalPlays = weekendInSofia + weekendAtHome + playsInHolidays;

            switch (year)
            {
                case "leap":
                    Console.WriteLine(Math.Floor(totalPlays + (totalPlays*0.15)));
                    break;
                case "normal":
                    Console.WriteLine(Math.Floor(totalPlays));
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }

        }
    }
}
