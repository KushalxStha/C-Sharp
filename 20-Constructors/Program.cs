using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Constructor = A special method in a class.
            //               Same name as the class.
            //               Can be used to assign arguments to fields when creating an objects.

            Human human1 = new Human("Ram", 30);
            Human human2 = new Human("Sita", 28);

            human1.Eat();
            human1.Sleep();

            human2.Eat();
            human2.Sleep();

            Console.ReadKey();
        }
    }

    class Human
    {
        public string name;
        public int age;
        
        // Constructor
        public Human(string name, int age) 
        {
            this.name = name;
            this.age = age;
        }
        public void Eat()
        {
            Console.WriteLine(name + " is eating.");
        }
        public void Sleep()
        {
            Console.WriteLine(name + " is sleeping.");
        }
    }
}
