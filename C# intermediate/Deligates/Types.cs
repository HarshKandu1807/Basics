using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deligates
{
    class Types
    {
        static void Main(string[] args)
        {
            Func<int, int, int> addDelegate = (a,b)=>a+b;
            Console.WriteLine("Sum: " + addDelegate(10,20));

            Action<string> printDelegate = msg => Console.WriteLine(msg);
            printDelegate("Hello");

            Predicate<int> EvenDelegate = n => n%2==0;
            Console.WriteLine("Is 4 even? " + EvenDelegate(4));
            Console.ReadKey();
        }
    }
}
