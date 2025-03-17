using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            for(int i = 0; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    c++;
                }
            }
            Console.WriteLine(c);
        }
    }
}
