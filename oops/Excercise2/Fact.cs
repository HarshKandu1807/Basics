using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise2
{
    class Fact
    {
        public static int Factorial(int n)
        {
            if (n <= 0)
            {
                return 1;
            }
            return n*Factorial(n - 1);
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int f = Factorial(n);
            Console.WriteLine(f);
        }
    }
}
