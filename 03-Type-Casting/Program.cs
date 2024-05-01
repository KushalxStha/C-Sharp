using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Type_Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Implicit Casting (automat.): converting a smaller type to a larger type size
            //char -> int -> long -> float -> double

            int myInt = 8;
            double myDouble = myInt;

            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);


            //Explicit Casting (manually): converting a larger type to a smaller size type
            //double -> float -> long -> int -> char

            double myDouble2 = 8.63;
            int myInt2 = (int)myDouble2;   // Truncates Decimal part

            Console.WriteLine(myDouble2);
            Console.WriteLine("Truncated: " + myInt2);

            Console.WriteLine("Rounded: " + Convert.ToInt32(myDouble2));  // Performs Rounding

            Console.ReadLine();
        }
    }
}
