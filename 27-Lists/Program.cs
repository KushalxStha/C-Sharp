using System;
using System.Collections.Generic;

namespace _27_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List = Data structure that represents list of Objects that can be accessed by index.
            //        Similar to array, but can dynamically increase/decrease in size.
            //        Uses System.Collections.Generic;

            List<string> Fruits = new List<string>();

            Fruits.Add("Apple");
            Fruits.Add("Banana");
            Fruits.Add("Mango");
            Fruits.Add("Watermelon");

            // List Methods
            Console.WriteLine(Fruits[3]);
            Console.WriteLine(Fruits.IndexOf("Apple"));
            Console.WriteLine(Fruits.Contains("Mango"));      // Returns Boolean
            Fruits.Remove("Watermelon");
            Fruits.Insert(0, "Pineapple");
            Fruits.Sort();                    // Sorts Alphabetically
            Fruits.Reverse();
            // Fruits.Clear();   // Clears List
            String[] FruitsArray = Fruits.ToArray();  // Converting List to Array


            foreach (string item in Fruits)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
