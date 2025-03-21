using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread main = Thread.CurrentThread;
            main.Name = "Main Thread";
            Thread t = new Thread(CountDown);
            Thread t1 = new Thread(() => CountUp("Timer #1"));
            t.Start();
            t1.Start();
            Count();
            Console.WriteLine(main.Name+" is Complete");

        }
        public static void Count()
        {
            for(int i = 100; i < 120; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }
        public static void CountDown()
        {
            for(int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }
        public static void CountUp(String n)
        {
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }
    }
}
