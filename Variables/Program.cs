using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            byte num = 1;
            const int n = 3;
            short s = 44;
            int sum = n+s;
            long l = 516834333;
            float f = 2.25f;
            double d = 2.555;
            double div = (double)l/d;
            decimal de = 3.55m;
            char c = 'A';
            string str = "ABCD";
            bool bo = true;
            Console.WriteLine("num"+" "+num);
            Console.WriteLine(n);
            Console.WriteLine(s);
            Console.WriteLine(l);
            Console.WriteLine(f);
            Console.WriteLine(d);
            Console.WriteLine(de);
            Console.WriteLine(c);
            Console.WriteLine(str);
            Console.WriteLine(sum);
            Console.WriteLine(div);
            Console.WriteLine(bo);
            Console.WriteLine("{0} {1}",byte.MinValue,byte.MaxValue);
        }
    }
}
