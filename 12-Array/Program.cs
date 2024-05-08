using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] cars = new string[4];
            //string[] cars = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };
            //string[] cars = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

            string[] cars = { "Hyundai", "Ford", "Tesla", "Suzuki", "BMW" };
            int[] nums = { 5, 6, 3, 7, 8, 9 };

            cars[0] = "Volvo";  // Changing Array Element
            
            Array.Sort(cars);  // Sorting: Array Method

            // ForEach Loop
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }

            // Array Methods that uses System.Linq
            Console.WriteLine("Maximum element: "+nums.Max());
            Console.WriteLine("Minimum element: "+nums.Min());
            Console.WriteLine("Sum of elements: "+nums.Sum());
            
            Console.ReadLine();
        }
    }
}
