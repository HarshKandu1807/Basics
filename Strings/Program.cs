using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = "Harsh";
            var last = "Kandu";
            String name = first + " " + last;
            string[] str = new string[3] { "Vishal", "Yash", "Harsh" };
            var fullname = string.Format("My Full Name is {0} {1}", first, last);
            var names = string.Join(",",str);
            Console.WriteLine(name);
            Console.WriteLine(names);
            Console.WriteLine(fullname);
            Console.WriteLine("Hello\nMy Name is Harsh Kandu\nPercentage\t70");
        }
    }
}
