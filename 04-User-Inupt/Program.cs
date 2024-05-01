using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_User_Inupt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string user = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            // The Console.ReadLine() method returns a string

            Console.WriteLine("User: " + user);
            Console.WriteLine("Age: " + age);

            Console.ReadLine();
        }
    }
}
