using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greatest_Common_Divisor
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            while (secondNum !=0)
            {
                int temp = secondNum;
                secondNum = firstNum % secondNum;
                firstNum = temp;
            }
            Console.WriteLine(firstNum);
        }
    }
}
