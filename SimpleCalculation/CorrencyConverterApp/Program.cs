using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrencyConverterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num = decimal.Parse(Console.ReadLine());
            string Currency1 = Console.ReadLine();
            string Currency2 = Console.ReadLine();
            decimal valuta1 = 0.0m;
            decimal valuta2 = 0.0m;

            if (Currency1 == "BGN") 
            {
                valuta1 = 1m;
            }
            else if (Currency1 == "USD") 
            {
                valuta1 = 1.79549m;
            }
            else if (Currency1 == "EUR") 
            {
                valuta1 = 1.95583m;
            }
            else if (Currency1 == "GBP") 
            {
                valuta1 = 2.53405m;
            }
            if (Currency2 == "BGN") 
            {
                valuta2 = 1m;
            }
            else if (Currency2 == "USD") 
            {
                valuta2 = 1.79549m;
            }
            else if (Currency2 == "EUR") 
            {
                valuta2 = 1.95583m;
            }
            else if (Currency2 == "GBP") 
            {
                valuta2 = 2.53405m;
            } 
            decimal result = num * (valuta1 / valuta2);
            Console.WriteLine(Math.Round(result, 2));

        }    
    }
}
