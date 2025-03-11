using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit
            byte i = 1;
            int b = i;
            //Explicite
            int j = 4;
            byte c = (byte)j;
            //Non-compatible
            var str = "1234";
            int k = Convert.ToInt32(str);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(k);

        }
    }
}
