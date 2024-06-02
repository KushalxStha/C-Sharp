using System;

namespace _25_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            // Polymorphism = Greek word that means to "have many forms"
            //                Objects can be identified by more than one type
            //                Ex: A dog is also: Canine, Animal, Organism ...

            Bike bike = new Bike();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            Vehicle[] vehicle = { bike, bicycle, boat };

            foreach (Vehicle v in vehicle)
            {
                v.Go();
            }
            Console.ReadKey();
        }
    }

    class Vehicle
    {
        public virtual void Go()
        {

        }
    }

    class Bike : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The car is moving.");
        }
    }
    class Bicycle : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The bicycle is moving.");
        }
    }
    class Boat : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The boat is moving.");
        }
    }
}
