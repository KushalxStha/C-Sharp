using System;

namespace _26_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Interface = Defines a "Contract" that all the classes inheriting from should follow.

            //             An Interface declares "what a class should have"
            //             An Inheriting class defines "how it should do it"

            // Benefits: Security + Multiple Inheritace + 'plug-and-play'
            
            var rabbit = new Rabbit();
            rabbit.Flee();

            var tiger = new Tiger();
            tiger.Hunt();

            var fish = new Fish();
            fish.Flee();
            fish.Hunt();

            Console.ReadKey();
        }
    }

    interface IPrey
    {
        void Flee();  // Only Declaration No Implementation
    }
    interface IPredator
    {
        void Hunt();
    }

    class Rabbit: IPrey
    {
        public void Flee()  // Implementation is the job of Class
        {
            Console.WriteLine("The Rabbit is running away.");
        }
    }

    class Tiger: IPredator
    {
        public void Hunt()
        {
            Console.WriteLine("The Tiger is hunting for food.");
        }
    }

    // Multiple Inheritance
    class Fish: IPrey, IPredator
    {
        public void Flee()
        {
            Console.WriteLine("The fish is running away.");
        }
        public void Hunt()
        {
            Console.WriteLine("The fish is searching for smaller fish.");
        }
    }
}
