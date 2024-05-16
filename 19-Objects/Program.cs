using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Object = An instance of a Class
            //          Objects can have fields & methods (characteristics & actions)

            Human human1 = new Human();
            Human human2 = new Human();

            human1.name = "Ram";
            human1.age = 30;

            human2.name = "Sita";
            human2.age = 28;

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
