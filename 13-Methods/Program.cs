using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calling Method
            singHappyBirthday("Alex", 20);
            singHappyBirthday("Jhon", 22);
            Console.ReadKey();
        }

        //Defining Method
        static void singHappyBirthday(string person, int age)
        {
            Console.WriteLine("Happy Birthday to you!");
            Console.WriteLine("Happy Birthday to you!");
            Console.WriteLine($"Happy Birthday Dear {person}!");
            Console.WriteLine($"You are {age} years old.");
            Console.WriteLine("Happy Birthday to you!");
            Console.WriteLine();
        }
    }
}
