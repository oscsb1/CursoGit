using System;
using System.Collections.Generic;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime d1 = DateTime.ParseExact("2020/02/13 ", "yyyy/MM/dd ", CultureInfo.InvariantCulture);

            TimeSpan t1;
                  
            t1 = d1.Subtract(DateTime.Now);
            Console.WriteLine(t1.TotalHours);







        }
    }
}
