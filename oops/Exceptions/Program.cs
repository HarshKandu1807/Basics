using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter 1st no:");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 2nd no:");
                int y = Convert.ToInt32(Console.ReadLine());
                double r = (double)x / y;
                Console.WriteLine(r);
            }catch(FormatException e)
            {
                Console.WriteLine("Enter only numbers");
            }catch(Exception e)//Handles all types  of exception
            {
                Console.WriteLine("Something went Wrong!");
            }
            finally//Always Execute
            {
                Console.WriteLine("Thanks for visiting");
            }
            Console.ReadKey();
        }
    }
}
