using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    class Program
    {
        public class Person
        {
            public int Age;
        }
        static void Main(string[] args)
        {
            //Value Type
            int a = 10;
            int b = a;
            Console.WriteLine(string.Format("a:{0},b{1}", a, b));
            b++;
            Console.WriteLine(string.Format("a:{0},b{1}",a,b));
            var num = 1;
            Inc(num);//add 10 to num and print it and destroy the value.
            Console.WriteLine(num);//as the value is destroyed it will only print 1.

            //Reference Type
            var arr = new int[3] { 1, 2, 3 };
            var arr1 = arr;
            Console.WriteLine(string.Format("arr[0]:{0},arr1[0]:{1}", arr[0], arr1[0]));
            arr1[0] = 0;
            Console.WriteLine(string.Format("arr[0]:{0},arr1[0]:{1}", arr[0], arr1[0]));

            var person = new Person() { Age = 20 };
            Age1(person);
            Console.WriteLine(person.Age);
        }
        public static void Inc(int num)
        {
            num += 10;
            Console.WriteLine(num);//it will add the 10 to num and then print it an destroy the value of num while
                                   //exiting the method or funtion.
        }
        public static void Age1(Person age1)
        {
            age1.Age += 10;
        }
    }
}
