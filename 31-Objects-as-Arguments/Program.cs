using System;

namespace _31_Objects_as_Arguments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Ferrari", "Yellow");
            ChangeColor(car1, "Blue");
            Car car2 = Copy(car1);
            
            Console.WriteLine(car1.Color + " " + car1.Model);
            Console.WriteLine(car2.Color + " " + car2.Model);

            Console.ReadKey();
        }

        // Passing Object as an Argument
        static void ChangeColor(Car car, string color)
        {
            car.Color = color;
        }

        public static Car Copy(Car car)
        {
            return new Car(car.Model, car.Color);
        }
    }

    class Car
    {
        public string Model;
        public string Color;

        public Car(string model, string color)
        {
            this.Model = model;
            this.Color = color;
        }
    }
}
