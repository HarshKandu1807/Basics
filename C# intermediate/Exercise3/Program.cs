using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            String s=Console.ReadLine();
            List<String> str = new List<string>();
            while (s != "")
            {
                str.Add(s);
                s = Console.ReadLine();
            }
            if (str.Count == 0)
            {
                Console.WriteLine("No one liked Your Post");
            }else if (str.Count == 1)
            {
                Console.WriteLine(str[0] + " liked Your Post");
            }else if(str.Count==2)
            {
                Console.WriteLine(str[0] + " & " + str[1] + " liked Your Post");

            }else
            {
                Console.WriteLine(str[0] + ", " + str[1]+" & "+(str.Count-2)+" Others liked Your Post");
            }
        }
    }
}
