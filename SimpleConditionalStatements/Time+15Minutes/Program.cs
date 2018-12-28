using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());

            min += 15;
            if (min > 59)
            {
                hour += 1;
                min -= 60;
            }
            if (hour > 23)
            {
                hour = hour - 24;
                
            }
            if (min < 10)
            {
                Console.WriteLine("{0}:0{1}", hour, min);
            }
            else
            {
                Console.WriteLine("{0}:{1}", hour, min);
            }
        }
    }
}
