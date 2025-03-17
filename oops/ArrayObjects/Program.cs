using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ArrayObjects
{
    class Car
    {
        public string model;
        public int year;
        public Car(string model)
        {
            this.model = model;
        }
        public Car(string model, int year)
        {
            this.model = model;
            this.year = year;
        }
    }
    class Program
    {
        public static int Year(Car c,int y)
        {
            c.year = y;
            return y;
        }
        public static Car Copy(Car c)
        {
            return new Car(c.model, c.year);
        }
        static void Main(string[] args)
        {
            //Arrays of Objects
            Car[] c = new Car[2];
            Car c1 = new Car("Mustang");
            Car c2 = new Car("Lambo");
            c[0] = c1;
            c[1] = c2;
            foreach(Car c3 in c)
            {
                Console.WriteLine(c3.model);
            }
            //or
            Car[] cr = { new Car("Mustang"), new Car("Lambo") };
            foreach(Car cr1 in cr)
            {
                Console.WriteLine(cr1.model);
            }
            //Objects as argument
            Car car = new Car("Mustang", 2022);
            Year(car, 2021);
            Console.WriteLine(car.model+" "+car.year);
            Car car1=Copy(car);
            Console.WriteLine(car1.model+" "+car1.year);
        }
    }

}
