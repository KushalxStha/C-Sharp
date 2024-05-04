using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_For_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. For Loop
            for (int i = 0; i<5; i++)
            {
                Console.WriteLine(i);
            }

            // 2. For Each
            string[] cars = { "BMW", "Toyota", "Mustang", "Tesla", "Ford" };
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
