using System;

namespace _29_Getters_Setters
{
    class Program
    {
        // Getters & Setters = adds security to fields by Encapsulation.
        //                     They are Accessors found within properties.

        // get accessor, set accessor, value keyword [ defines value being assigned by set(parameter) ]
        static void Main(string[] args)
        {
            Car car1 = new Car(5500);
            Console.WriteLine(car1.Speed);

            Console.ReadKey();
        }
    }

    class Car
    {
        private int speed;
        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                if (value > 500) speed = 500;
                else if (value < 0) speed = 0;
                else speed = value;
            }
        }

        public Car(int speed)
        {
            Speed = speed;
        }
    }
}
