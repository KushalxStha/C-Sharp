using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Static
{
    internal class Program
    {
        // Static: Modifier to declare a static member, which belongs to Class itself
        //         rather than to any specific object.
        // Objects cannot be created from Static Class.
        static void Main(string[] args)
        {
            Car car1 = new Car("Toyota");
            Car car2 = new Car("Mustang");
            Car car3 = new Car("Ferrari");

            Console.WriteLine("No. of Cars: "+Car.numberOfCars);
            Car.StartRace();

            Console.ReadKey();
        }
    }
}

class Car
{
    public string model;
    public static int numberOfCars;

    public Car(string models)
    {
        this.model = models;
        numberOfCars++;
    }

    public static void StartRace()
    {
        Console.WriteLine("The race has begun!");
    }
}
