using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Unique
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            HashSet<int> h = new HashSet<int>();
            while (s != "Quit")
            {
                int n = Convert.ToInt32(s);
                h.Add(n);
                s = Console.ReadLine();
            }
            foreach (int i in h)
            {
                Console.WriteLine(i);
            }
        }
    }
}
