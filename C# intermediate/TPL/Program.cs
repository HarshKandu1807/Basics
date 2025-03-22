using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPL
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task t1 = new Task(() => Dowork(1,2500));
            //t1.Start();
            //Task t2 = new Task(() => Dowork(2,2000));
            //t2.Start();
            //Task t3 = new Task(() => Dowork(3,1500));
            //t3.Start();
            Task t1 = Task.Factory.StartNew(() => Dowork(1, 2000)).ContinueWith((prev) => DoOtherwork(4,1000));//the DoOtherwork will only start when the task 1 is finshed
            Task t2 = Task.Factory.StartNew(() => Dowork(2, 2500));//factory.startnew will automatically execute the task wahen it is assingned
            Task t3 = Task.Factory.StartNew(() => Dowork(3, 1500));


            Console.WriteLine("Press Enter to exit");
            Console.ReadKey();
        }
        static void Dowork(int id,int sleep)
        {
            Console.WriteLine("Task {0} begin",id);
            Thread.Sleep(sleep);
            Console.WriteLine("Task {0} end",id);

        }
        static void DoOtherwork(int id, int sleep)
        {
            Console.WriteLine("Task {0} begin", id);
            Thread.Sleep(sleep);
            Console.WriteLine("Task {0} end", id);

        }
    }
}
