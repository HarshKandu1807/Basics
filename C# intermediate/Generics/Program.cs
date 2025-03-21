using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        public static void Display<Thing>(Thing[] A)
        {
            foreach(Thing i in A)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3 };
            double[] d = { 1.2, 2.5, 3.4 };
            string[] s = { "A", "B", "C" };
            Display(a);
            Display(d);
            Display(s);
        }
    }
}
