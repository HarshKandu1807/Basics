using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random1
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(r.Next(0,10));
                Console.WriteLine((char)('a'+r.Next(0,10)));
            }
        }
    }
}
