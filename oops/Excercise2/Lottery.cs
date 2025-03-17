using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise2
{
    class Lottery
    {
        static void Main(string[] args)
        {
            var r = new Random();
            int w = r.Next(1, 10);
            Console.WriteLine("Enter a number:");
            int l = Convert.ToInt32(Console.ReadLine());
            if (l == w)
            {
                Console.WriteLine("You Won "+w+" "+l);
            }
            else
            {
                Console.WriteLine("You Lose you choose "+l+" which is wrong the correct number is "+w);
            }

        }
    }
}
