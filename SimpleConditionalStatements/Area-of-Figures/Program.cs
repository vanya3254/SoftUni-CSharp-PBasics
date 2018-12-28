using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string fig1 = "square";
            string fig2 = "rectangle";
            string fig3 = "circle";
            string fig4 = "triangle";
            var figure = Console.ReadLine();
            if (figure == fig1)
            {
                double a = double.Parse(Console.ReadLine());
                double area = a * a;
                Console.WriteLine(Math.Round(area, 3));
            }
            else if (figure == fig2)
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double area = a * b;
                Console.WriteLine(Math.Round(area, 3));

            }
            else if (figure == fig3)
            {
                double a = double.Parse(Console.ReadLine());
                double area = Math.PI * a * a;
                Console.WriteLine(Math.Round(area, 3));

            }
            else if (figure == fig4)
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double area = (a * b)*1/2;
                Console.WriteLine(Math.Round(area, 3));

            }
            
            
        }
    }
}
