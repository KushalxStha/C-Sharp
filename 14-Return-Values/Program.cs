using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Return_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.Write("Enter 1st number: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter 2nd number: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"The sum of {a} and {b} is {Addition(a, b)}");
            Console.WriteLine($"The difference of {a} and {b} is {Subtraction(a, b)}");
            Console.WriteLine($"The multiplication of {a} and {b} is {Multiplication(a, b)}");
            Console.WriteLine($"The division of {a} and {b} is {Division(a, b)}");
            Console.ReadKey();
        }

        static double Addition(double x, double y)
        {
            return x + y;
        }

        static double Subtraction(double x, double y)
        {
            return x - y;
        }

        static double Multiplication(double x, double y)
        {
            return x * y;
        }

        static double Division(double x, double y)
        {
            return x / y;
        }
    }
}
