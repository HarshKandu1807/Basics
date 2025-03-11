using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime1
{
    class Program
    {
        static void Main(string[] args)
        {
            var dt = new DateTime(2015,2,18);
            var now = DateTime.Now;
            var today = DateTime.Today;
            Console.WriteLine(now);
            Console.WriteLine(today);
            Console.WriteLine(dt);
            var tomw = now.AddDays(1);
            var n = dt.AddMonths(1);
            var yest = now.AddDays(-1);
            Console.WriteLine(tomw);
            Console.WriteLine(yest);
            Console.WriteLine(dt);
            Console.WriteLine(n);
            Console.WriteLine(now.ToString());
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(dt.ToString());
        }
    }
}
