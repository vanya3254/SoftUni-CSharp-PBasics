using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter score: ");
            double bonusScore = 0.0;
            double num = double.Parse(Console.ReadLine());

            if (num <= 100)
            {
                bonusScore += 5;
            }
            else if (num < 1000)
            {
                bonusScore += num * 20/100.0;
            }
            else if (num >= 1000)
            {
                bonusScore += num * 10/100.0;
            }
            if (num %2 ==0)
            {
                bonusScore += 1;
            }
            else if (num %10 ==5)
            {
                bonusScore += 2;
            }
            double result = num + bonusScore;
            Console.WriteLine("Bonus score: " + bonusScore);
            Console.WriteLine("Total score: " + result);

        }
    }
}
