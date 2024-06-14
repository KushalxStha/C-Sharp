using System;

namespace _34_Generics
{
    internal class Program
    {
        // Generic = Not specific to particular Data Type.
        //           add <T> to classes, methods, fields etc
        //           allows for code reusability for different Data Types
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3 };
            double[] doubleArray = { 1.2, 2.6, 3.8 };
            string[] stringArray = { "One", "Two", "Three" };

            Display(intArray);
            Display(doubleArray);
            Display(stringArray);

            Console.ReadKey();
        }

        public static void Display<T> (T[] array)
        {
            foreach (T item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        } 
        // single alternative for below methods

        //public static void Display(int[] array) { }
        //public static void Display(double[] array) { }
        //public static void Display(string[] array) { }
    }
}
