using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicals
{
    class Program
    {
        public static int SecondLarge(int[] a)
        {

            int m = a[1];
            int sm = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (m < a[i])
                {
                    m = a[i];
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (sm < a[i] && m != a[i])
                {
                    sm = a[i];
                }
            }
            return sm;
        }
        public static int fib(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if(n==1)
            {
                return 1;
            }
            return fib(n-1)+fib(n-2);

        }
        public static bool pali(string p)
        {
            int l = 0, h = p.Length-1;
            while (l < h)
            {
                if (p[l] != p[h])
                {
                    return false;
                }
                l++;
                h--;
            }
            return true;
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            switch(s){
                case "sm":
                    int n = Convert.ToInt32(Console.ReadLine());
                    int[] a = new int[n];
                    for (int j = 0; j < n; j++)
                    {
                        a[j] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine(SecondLarge(a));
                    break;
                case "rv":
                    int  i= Convert.ToInt32(Console.ReadLine());
                    int ri = 0;
                    while (i > 0)
                    {
                        int r = i % 10;
                        ri = ri * 10 + r;
                        i = i / 10;
                    }
                    Console.WriteLine(ri);
                    break;
                case "sw":
                    int a1 = Convert.ToInt32(Console.ReadLine());
                    int b1 = Convert.ToInt32(Console.ReadLine());
                    a1 = a1 + b1;
                    b1 = a1 - b1;
                    a1 = a1 - b1;
                    Console.WriteLine(a1+" "+b1);
                    break;
                case "rvs":
                    string str = Console.ReadLine();
                    string rstr = "";
                    for(int j = str.Length-1; j >= 0; j--)
                    {
                        rstr += str[j];
                    }
                    Console.WriteLine(rstr);
                    break;
                case "fibr":
                    int f = Convert.ToInt32(Console.ReadLine());
                    for(int j = 0; j < f; j++)
                    {
                        Console.WriteLine(fib(j));
                    }
                    break;
                case "fib":
                    int f1 = Convert.ToInt32(Console.ReadLine());
                    int n1 = 0, n2 = 1;
                    for(int j = 0; j < f1; j++)
                    {
                        Console.WriteLine(n1);
                        int t = n1;
                        n1 = n2;
                        n2 = t + n2;
                    }
                    break;
                case "palid":
                    string p = Console.ReadLine().ToLower();
                    if (pali(p))
                    {
                        Console.WriteLine("Palindrome");
                    }
                    else
                    {
                        Console.WriteLine("Not a Palindrome");
                    }
                    break;
                case "UL":
                    string ul = Console.ReadLine();
                    int u = 0, l = 0;
                    foreach(char e in ul)
                    {
                        if (e >= 'a' && e <= 'z')
                        {
                            u++;
                        }
                        if (e >= 'A' && e <= 'Z')
                        {
                            l++;
                        }
                    }
                    Console.WriteLine(u+" "+l);
                    break;
                case "even":
                    int num = Convert.ToInt32(Console.ReadLine());
                    List<int> list = new List<int>();
                    for(int j = 0; j < num; j++)
                    {
                        list.Add(Convert.ToInt32(Console.ReadLine()));
                        
                    }
                    foreach(int e in list)
                    {
                        if (e % 2 == 0)
                        {
                            Console.WriteLine(e);
                        }
                    }
                    break;
                case "prime":
                    int pr = Convert.ToInt32(Console.ReadLine());
                    
                    for(int j = 2; j <= pr; j++)
                    {
                        bool b = true;
                        for (int k = 2; k*k < j; k++)
                        {
                            if (j % k == 0)
                            {
                                b = false;
                            }
                        }
                        if (b)
                        {
                            Console.WriteLine(j);
                        }
                    }
                    break;


            }
        }
    }
}
