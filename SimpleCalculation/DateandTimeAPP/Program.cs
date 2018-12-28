using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateandTimeAPP
{
    class Program
    {
        public static CultureInfo InvariantCulture { get; private set; }

        static void Main(string[] args)
        {
            CultureInfo provider = InvariantCulture;

            string dateFormat = "dd-MM-yyyy";
            DateTime date = DateTime.ParseExact(Console.ReadLine(), dateFormat, provider);
            DateTime date2 = date.AddDays(999);
            Console.WriteLine(date2.ToString(dateFormat));
           
        }
    }
}
