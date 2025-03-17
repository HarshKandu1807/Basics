using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise2
{
    class Sum
    {
        static void Main(string[] args)
        {
            int n = 0;
            while (true)
            {
                var s = Console.ReadLine();
                if (s.ToLower() == "ok")
                {
                    break;
                }
                n += Convert.ToInt32(s);
            }
            Console.WriteLine(n);
        }
    }
}
