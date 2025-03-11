using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3 };
            Console.WriteLine(num[0]);
            bool[] arr = new bool[3];
            arr[0] = true;
            string[] str = new string[3];
            str[0]= "Harsh";
            int[] n = new int[3];
            var n1 = new int[3];
            n[0] = 2;
            n1[0] = 5;
            Console.WriteLine(arr[0]+" "+ num[1]);
        }
    }
}
