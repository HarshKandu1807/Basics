using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalLoops
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var season = Season.Autumn;
            switch (season) 
            {
                case Season.Autumn:
                    Console.WriteLine("Autumn");
                    break;
                case Season.Winter:
                    Console.WriteLine("Winter");
                    break;
                default:
                    Console.WriteLine("");
                    break;

            }
            var t = 10;
            if(t>0 && t <= 10)
            {
                Console.WriteLine("Cold");
            }else if (t > 10 && t <= 20)
            {
                Console.WriteLine("Average");
            }
            else
            {
                Console.WriteLine("Hot");
            }
        }
    }
}
