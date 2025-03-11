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
            var arr = new int[] { 1, 2, 7, 3, 5, 4, 12, 11 };
            //Length
            var l = arr.Length;
            //Clear()
            Array.Clear(arr,0,2);
            foreach(var n in arr)
            {
                Console.WriteLine(n);
            }
            //Copy()
            var arr1 = new int[4];
            Array.Copy(arr, arr1, 4);
            foreach(var n in arr1)
            {
                Console.WriteLine(n);
            }
            //IndexOf()
            var n1 = Array.IndexOf(arr, 5);
            Console.WriteLine(n1);
            //Reverse()
            Array.Reverse(arr);
            foreach(var n in arr)
            {
                Console.WriteLine(n);
            }
            //Sort()
            Array.Sort(arr);
            foreach(var n in arr)
            {
                Console.WriteLine(n);
            }
        }
    }
}
