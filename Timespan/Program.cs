using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timespan
{
    class Program
    {
        static void Main(string[] args)
        {
            var timespan = new TimeSpan(1,2,3);
            var timespan1 = new TimeSpan(1, 0, 0);
            var timespan2 = TimeSpan.FromHours(1);
            Console.WriteLine(timespan);
            Console.WriteLine(timespan1);
            Console.WriteLine(timespan2);
            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine(duration);
            //Properties
            Console.WriteLine(timespan.Minutes);
            Console.WriteLine(timespan.TotalMinutes);
            //Add
            Console.WriteLine(timespan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine(timespan.Subtract(TimeSpan.FromMinutes(2)));
            //ToString
            Console.WriteLine(timespan.ToString());
            //Parse
            Console.WriteLine(TimeSpan.Parse("2:4:7"));
        }
    }
}
