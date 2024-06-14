using System;

namespace _32_Auto_implemented_Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("BMW");
            Console.WriteLine(car1.Model);

            Console.ReadKey();
        }
    }

    class Car
    {
        //private string model;
        //public string Model
        //{
        //    get { return model; }
        //    set { model = value; }
        //}

        public string Model { get; set; }  // Shortcut for above

        public Car(string model)
        {
            this.Model = model;
        }
    }
}
