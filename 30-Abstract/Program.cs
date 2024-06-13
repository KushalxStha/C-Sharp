using System;

namespace _30_Abstract
{
    class Program
    {
        // Abstraction = process of hiding certain details and showing only essential info.
        // Abstract classes = modifier that indicates missing components or incomplete implementation
        static void Main()
        {
            Dog myDog = new Dog();
            myDog.Name = "Rex";
            Console.WriteLine($"My dog's name is {myDog.Name}");
            myDog.MakeSound(); // Outputs "Bark!"
            myDog.Sleep();     // Outputs "Sleeping..."

            Console.ReadKey();
        }
    }
    abstract class Animal
    {
        public abstract string Name { get; set; } // Abstract property

        public abstract void MakeSound();  // Abstract method (does not have a body)

        public void Sleep()  // Regular method
        {
            Console.WriteLine("Sleeping...");
        }
    }

    class Dog : Animal
    {
        private string name;

        // Implementing the abstract property
        public override string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Implementing the abstract method
        public override void MakeSound()
        {
            Console.WriteLine("Bark!");
        }
    }
}
