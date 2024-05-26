using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Method_OverRiding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Method Overriding = Provides a new version of a method Inherited from a parent class
            //                     Inherited method must be: abstract, virtual, or already overriden
            //                     Used with ToString(), polymorphism
            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.speak();
            cat.speak();

            Console.ReadKey();
        }
    }

    class Animal
    {
        public virtual void speak()
        {
            Console.WriteLine("The animal goes ....");
        }
    }

    class Dog: Animal
    {
        public override void speak()
        {
            Console.WriteLine("The dog goes *woof*");
        }
    }

    class Cat: Animal
    {
        public override void speak()
        {
            Console.WriteLine("The cat goes *meow*");
        }
    }
}
