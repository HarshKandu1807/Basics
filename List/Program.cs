using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 1, 2, 3, 4, 5 };
            //Add a Element
            list.Add(1);
            list.AddRange(new int[3] { 5, 6, 7 });
            foreach(var n in list)
            {
                Console.WriteLine(n);
            }
            //Remove Element
            list.Remove(2);//Remove a perticuLar index
            list.RemoveAt(4);//Remove element at the index
            foreach (var n in list)
            {
                Console.WriteLine(n);
            }
            //to remove all the occurance of the element use for loop do not use foreach loop it will throw exception
            for (var i = 0; i < list.Count; i++)
            {
                if (list[i] == 1)
                {
                    list.Remove(list[i]);
                }
            }
            //IndexOf to find the index of element
            list.IndexOf(5);
            list.LastIndexOf(5);
            foreach (var n in list)
            {
                Console.WriteLine(n);
            }
            //Contians find the list contins the element or not
            var a=list.Contains(5);
            Console.WriteLine(a);
            //Count length or total number of element present in the list
            Console.WriteLine(list.Count());

        }
    }
}
