using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methoverride
{
    class Program
    {
        //The animal,cat and dog can also be the example for polymorplism because animals can be of multiple form.
        class Animal
        {
            public virtual void Speaks()
            {
                Console.WriteLine("Speaks *brrrr*");
            }
        }
        class Dog:Animal
        {
            public override void Speaks()
            {
                Console.WriteLine("Speaks *Woof");
            }
        }
        class Cat : Animal
        {
            public override void Speaks()
            {
                Console.WriteLine("Speaks *Meow");
            }
        }
        class Car
        {
            string model;
            string make;
            public Car(string model ,string make){
                this.model=model;
                this.make = make;
            }
            public override string ToString()
            {
                return "This is a "+make+" "+model;
            }
        }
        static void Main(string[] args)
        {
            Dog d = new Dog();
            Cat c = new Cat();
            d.Speaks();
            c.Speaks();
            Car cr = new Car("Car", "Lambo");
            Console.WriteLine(cr);
            //Polymorphism
            Car1 car = new Car1();
            Bike b = new Bike();
            Vehical[] v = { car, b };
            foreach(Vehical v1 in v)
            {
                v1.Go();
            }
        }
        //Polymorphism
        class Vehical
        {
            public virtual void Go()
            {

            }
        }
        class Car1:Vehical
        {
            public override void Go()
            {
                Console.WriteLine("The car is Running");
            }
        }
        class Bike : Vehical
        {
            public override void Go()
            {
                Console.WriteLine("The Bike is running");
            }
        }
    }
}
