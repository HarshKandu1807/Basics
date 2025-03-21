using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class UniqueNumbers
    {
        public static int Check(int n, int[] a)
        {
            bool c = true;
            for (int  i= 0; i < a.Length; i++)
            {
                if (a[i] == n)
                {
                    Console.WriteLine("The nmber is already present enter a different number");
                    n = Convert.ToInt32(Console.ReadLine());
                    c = false;
                }
            }
            if (c)
            {
                return n;
            }
            return Check(n, a);
        }
        static void Main(string[] args)
        {
            int[] a = new int[5];
            for(int i = 0; i < a.Length; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                a[i] = Check(n,a);
            }
            for(int i = 0; i < 5; i++)
            {
                Console.Write(a[i]+" ");
            }
            Console.WriteLine();
            for(int i = 0; i < a.Length; i++)
            {
                for(int j = i; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        int t = a[i];
                        a[i] = a[j];
                        a[j] = t;
                    }

                }
                Console.Write(a[i]+" ");
            }
        }
    }
}
