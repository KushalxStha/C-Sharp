using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Methods_Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = Multiply(5, 10);
            double y = Multiply(5.5, 10.86);
            
            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.ReadLine();
            // Method Overloading: Methods share same name but different parameters.
            // Signature = Name + Parameter
            // Methods must have unique Signature.
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static int Multiply(int a, int b) 
        {  
            return a * b;
        }
    }
}
