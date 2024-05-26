using System;

namespace _22_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.honk();
            Console.WriteLine($"Car model is {car1.model}.");

            Console.ReadKey();
        }
    }
    // Base Class (Parent)
    class Vehicle
    {
        public void honk()
        {
            Console.WriteLine("It can honk.");
        }
    }

    // Derived Class (Child)
    class Car: Vehicle
    {
        public string model="Ferrari";
    }
}
