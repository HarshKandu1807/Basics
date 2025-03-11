using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Multiply;

namespace Classes
{
    public class Operation
    {
        public int All(int a,int b,int c)
        {
            return (a + b * c) / a;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new Addition();
            obj.Add(1,2);
            Mul obj1 = new Mul();
            var mul = obj1.M(2, 3);
            Console.WriteLine(mul);
            Division d = new Division();
            var div = d.Div(5, 2);
            Console.WriteLine(div);
            Subtract.Sub(3, 2);
            Operation o = new Operation();
            var opr = o.All(2, 3, 4);
            Console.WriteLine(opr);
        }
    }
}
