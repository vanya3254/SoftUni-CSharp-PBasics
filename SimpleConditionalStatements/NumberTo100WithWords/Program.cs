using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberTo100WithWords
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num < 0 || num > 100)
            { Console.WriteLine("Invalid number"); }
            else if (num == 0)
            { Console.WriteLine("zero"); }
            else if (num == 100)
            { Console.WriteLine("one hundred"); }
            else if (num >= 10 && num < 20)
            {
                if (num == 10) { Console.WriteLine("ten"); }
                if (num == 11) { Console.WriteLine("eleven"); }
                if (num == 12) { Console.WriteLine("twelve"); }
                if (num == 13) { Console.WriteLine("thirteen"); }
                if (num == 14) { Console.WriteLine("fourteen"); }
                if (num == 15) { Console.WriteLine("fifteen"); }
                if (num == 16) { Console.WriteLine("sixteen"); }
                if (num == 17) { Console.WriteLine("seventeen"); }
                if (num == 18) { Console.WriteLine("eighteen"); }
                if (num == 19) { Console.WriteLine("nineteen"); }
            }
            else
            {
                int i1 = num / 10;
                int i2 = num % 10;

                if (i1 == 2) { Console.Write("twenty"); }
                else if (i1 == 3) { Console.Write("thirty"); }
                else if (i1 == 4) { Console.Write("forty"); }
                else if (i1 == 5) { Console.Write("fifty"); }
                else if (i1 == 6) { Console.Write("sixty"); }
                else if (i1 == 7) { Console.Write("seventy"); }
                else if (i1 == 8) { Console.Write("eighty"); }
                else if (i1 == 9) { Console.Write("ninety"); }

                if (i1 != 0 && i2 != 0) { Console.Write(" "); }
                if (i2 == 1) { Console.Write("one"); }
                else if (i2 == 2) { Console.Write("two"); }
                else if (i2 == 3) { Console.Write("three"); }
                else if (i2 == 4) { Console.Write("four"); }
                else if (i2 == 5) { Console.Write("five"); }
                else if (i2 == 6) { Console.Write("six"); }
                else if (i2 == 7) { Console.Write("seven"); }
                else if (i2 == 8) { Console.Write("eight"); }
                else if (i2 == 9) { Console.Write("nine"); }
                Console.WriteLine();
            }

        }
        

           
    }
}
