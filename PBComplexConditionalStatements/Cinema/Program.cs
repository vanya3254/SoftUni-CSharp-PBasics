using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projekcia = Console.ReadLine().ToLower();
            double rows = double.Parse(Console.ReadLine());
            double columns = double.Parse(Console.ReadLine());

            double sum = rows * columns;

            switch (projekcia)
            {
                case "premiere": Console.WriteLine("{0:f2}",(12*sum + " leva")); break;
                case "normal": Console.WriteLine("{0:f2}", (7.50 * sum) + " leva"); break;
                case "discount": Console.WriteLine("{0:f2}", (5 * sum) + " leva");break;
                default: Console.WriteLine("error"); break;
                    
            }


        }
    }
}
