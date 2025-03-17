using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise2
{
    class Max
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();
            var a = str.Split(',');
            var n = Convert.ToInt32(a[0]);
            foreach (var s in a)
            {
                var n1 = Convert.ToInt32(s);
                if (n1 > n)
                {
                    n = n1;
                }
            }
            Console.WriteLine(n);
        }
    }
}
