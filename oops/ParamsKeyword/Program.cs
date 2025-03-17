using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsKeyword
{
    class Program
    {
        public double Checkout(params double[] prices)
        {
            double total = 0;
            foreach(double price in prices)
            {
                total += price;
            }
            return total;
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            double total = obj.Checkout(3.12,21.2,3.13,2.8,7.4);
            Console.WriteLine(total);
        }
    }
}
