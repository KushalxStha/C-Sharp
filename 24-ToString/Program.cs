using System;

namespace _24_ToString
{
    class Program
    {
        static void Main(string[] args)
        {
            // ToString() = Converts an object to its String Representation
            //              so that it is suitable for display

            Person person1 = new Person("Alice", 30, "Engineer");
            Person person2 = new Person("Bob", 25, "Designer");

            // Using ToString() implicitly
            Console.WriteLine(person1);  // Calls person1.ToString()
            Console.WriteLine(person2);  // Calls person2.ToString()

            // Example of using ToString() with string interpolation
            Console.WriteLine($"Person Details: {person1}");

            Console.ReadKey();
        }
    }
    class Person
    {
        public string Name;
        public int Age;
        public string Occupation;

        public Person(string name, int age, string occupation)
        {
            this.Name = name;
            this.Age = age;
            this.Occupation = occupation;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Occupation: {Occupation}";
        }
    }
}
