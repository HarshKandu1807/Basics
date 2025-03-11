using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "  Harsh Kandu ";
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.ToLower());
            Console.WriteLine(str.Trim());//Removes spaces at end and at start of the string
            int i = str.IndexOf(' ');
            Console.WriteLine(str.Substring(0,i));
            Console.WriteLine(str.Substring(i+1));
            Console.WriteLine(str.Replace('h','H'));
            Console.WriteLine(str.Replace("Harsh","Yash").Trim());
            if(String.IsNullOrWhiteSpace(" "))//check the string is empty or have whitespace or null
                Console.WriteLine("Invalid");//String.IsNullOrEmpty() do not detect the whitespace
            Console.WriteLine(str.Split(' '));
            //String to integer conversion
            string s = "1234";
            int c = Convert.ToInt32(s);
            Console.WriteLine(c);
            //Integer to string conversion
            int n = 1234;
            Console.WriteLine(n.ToString());
            Console.WriteLine(n.ToString("C"));//convert to currency in dollar
            Console.WriteLine(n.ToString("C0"));//convert to currency in dollar and remove all decimal till 0 places
            Console.WriteLine(n.ToString("D6"));//convert to decimal
            Console.WriteLine(n.ToString("X"));//convert to hexadecimal
            float f = 12.12124414121f;
            Console.WriteLine(f.ToString("E"));//convert to exponential
            Console.WriteLine(f.ToString("F2"));//fix the decimal till 2nd place
            double d = 12.2123214214211242412;
            Console.WriteLine(d.ToString());
        }
    }
}
