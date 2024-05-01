using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables_and_DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var anything = "Can store any data";

            int num = 5;                // 4 bytes
            //long numLong = 50000;        8 bytes
            //float floatNum = 2.2f;       4 bytes
            double doubleNum = 100.43d; // 8 bytes
            bool boolValue = true;      // 1 byte
            char letter = 'K';          // 2 bytes
            string text = "Kushal";     // 2 bytes per char

            //A const field requires a value to be provided. It cannot be changed.
            const double pi = 3.14;

            // Declaring Multiple Variables of Same type seperated by coma (,).
            int a = 5, b = 10, c = 15;

            // String Concatenation
            Console.WriteLine("var: " + anything);
            Console.WriteLine("int: " + num);
            Console.WriteLine("double: " + doubleNum);
            Console.WriteLine("bool: " + boolValue);
            Console.WriteLine("char: " + letter);
            Console.WriteLine("string: " + text);
            Console.WriteLine("const double: " + pi);
            Console.WriteLine("Sum of a,b & c: " + (a + b + c));

            Console.ReadLine();
        }
    }
}
