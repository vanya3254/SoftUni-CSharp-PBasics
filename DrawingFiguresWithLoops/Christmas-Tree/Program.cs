using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            
            for (int row = 0; row < n+1; row++)
            {
                Console.Write(new string(' ', n - row));
                Console.Write(new string('*', row));             
                Console.Write(" | ");
                Console.WriteLine(new string('*', row));

                //drugo reshenie
                //    string spaces = new string(' ', n - row);
                //string stars = new string('*', row);
                //Console.WriteLine("{0}{1} | {1}", spaces, rows);

            }

        }
    }
}
