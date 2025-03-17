using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contructors
{
    class Program
    {
        class car
        {
            private string model;
            int year;
            public car(string model, int year)//Parameterized Constructor
            {
                this.model = model;
                this.year = year;
            }
            public car(car c)//Copy constructor
            {
                this.model = c.model;
                this.year = c.year;
            }
            public string Data
            {
                get
                {
                    return model + " " + year.ToString();
                }
            }
        }
        static void Main(string[] args)
        {
            car c1 = new car("lambo", 2023);
            car c2 = new car(c1);
            Console.WriteLine(c1.Data);
            Console.WriteLine(c2.Data);
        }
    }
}
