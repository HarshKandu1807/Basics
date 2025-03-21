using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class ReverseString
    {
        public static string Reverse(String[] c,string s)
        {
            string rs = "";
            int j = 0;
            for(int i = 0; i < s.Length; i++)
            {
                rs += c[i];
            }
            return rs;
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int l = s.Length;
            String[] c = new String[l];
            int j = 0;
            for (int i = s.Length-1; i >= 0; i--)
            {
                c[j++] += s[i];
            }
            Console.WriteLine(Reverse(c,s));
        }
    }
}
