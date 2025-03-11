using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while(i < 10){
                Console.WriteLine(i);
                i++;
            }
            while (true)
            {
                var s=Console.ReadLine();
                Console.WriteLine(s);
                if (!String.IsNullOrWhiteSpace(s))
                {
                    continue;
                }
                break;
            }
        }
    }
}
