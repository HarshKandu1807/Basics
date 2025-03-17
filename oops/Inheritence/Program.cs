using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    class Program
    {
        abstract class Vehical //cannot create the object of the abstract class its methos can only use to by the other classes
        {
            public void Speed()
            {
                Console.WriteLine("The car is running");
            }
        }
        class Car : Vehical
        {
            public void Wheels(int n=4)
            {
                Console.WriteLine("There are total "+n+" wheels");
            }
        }
        class Bike : Vehical
        {
            public void Wheels(int n=2)
            {
                Console.WriteLine("There are total " + n + " wheels");
            }
        }
        class Lambo:Car
        {
            public void Model()
            {
                Console.WriteLine("Rac car");
            }
        }
        interface Sides
        {
            void M1(int n);
        }
        interface Color
        {
            void M2();
        }
        class Rectangle : Sides, Color
        {
            public void M1(int n = 4)
            {
                Console.WriteLine("No of sides is "+n);
            }
            public void M2()
            {
                Console.WriteLine("Black");
            }
        }

        static void Main(string[] args)
        {
            Car c = new Car();
            c.Speed();
            c.Wheels();
            Bike b = new Bike();
            b.Speed();
            b.Wheels();
            Lambo l = new Lambo();
            l.Wheels();
            l.Model();
            l.Speed();
            Rectangle r = new Rectangle();
            r.M1();
            r.M2();
        }
    }
}
