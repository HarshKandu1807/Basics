using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum1
{
    public enum Vehicle
    {
        car=1,
        bike=2,
        scooty=3
    }
    class Program
    {
        static void Main(string[] args)
        {
            var a = Vehicle.bike;
            Console.WriteLine((int)a);
            var b = 3;
            Console.WriteLine((Vehicle)b);//integer to Enum(Method)
            Console.WriteLine(a.ToString());//Convert Enum to string
            var c = "car";
            Console.WriteLine((Vehicle)Enum.Parse(typeof(Vehicle), c)); //Convert String to Enum
            Console.WriteLine(a);//Enum default consider the value as a string
        }
    }
}
