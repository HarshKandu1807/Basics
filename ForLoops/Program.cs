using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            for(int i = 10; i > 0; i--)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            var name = "Harsh";
            for(int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
            foreach(var ch in name)
            {
                Console.WriteLine(ch);
            }
            var arr = new int[5] { 1, 2, 3, 4, 5 };
            foreach(var num in arr)
            {
                Console.WriteLine(num);
            }
        }
    }
}
