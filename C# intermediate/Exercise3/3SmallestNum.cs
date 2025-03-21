using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class _3SmallestNum
    {
        public static void Elements(string[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i; j < a.Length; j++)
                {
                    if (Convert.ToInt32(a[i]) >= Convert.ToInt32(a[j]))
                    {
                        String t = a[i];
                        a[i] = a[j];
                        a[j] = t;
                    }
                }
                Console.WriteLine(a[i]);
            }
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] a = s.Split(',');
            int l = a.Length;
            while (l < 5)
            {
                Console.WriteLine("Re-try");
                s = Console.ReadLine();
                a = s.Split(',');
                l = a.Length;
            }
            Elements(a);
            Console.WriteLine(a[0]+" " + a[1]+" " + a[2]);
        }
    }
}
