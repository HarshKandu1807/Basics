using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    int n = Convert.ToInt32(Console.ReadLine());
                    int n1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(n / n1);
                }
                catch (Exception e)
                {
                    string s = @"C:\Users\Nimap\source\repos\InnerException\log.txt";
                    if (File.Exists(s))
                    {
                        StreamWriter sr = new StreamWriter(s);
                        sr.Write(e.GetType().Name);
                        sr.WriteLine();
                        sr.Write(e.Message);
                        sr.Close();
                        Console.WriteLine("There is a problem");
                    }
                    else
                    {
                        throw new FileNotFoundException(s + " sis not present ", e);
                    }
                }
            }catch(Exception ex)
            {
                Console.WriteLine("Current Exception: {0}",ex.GetType().Name);
                Console.WriteLine("Inner Exception: {0}" , ex.InnerException.GetType().Name);
            }
        }
    }
}
