using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Params
{
    internal class Program
    {
        // Params keyword: A method parameter that takes a variable number of arguments.
        //                 The parameter type must be single dimensional array.
        static void Main(string[] args)
        {
            double Total = Checkout(15.6, 12.8, 13.9);

            Console.WriteLine($"The total cost of products is {Total}");
            Console.ReadKey();
        }
        
        static double Checkout(params double[] prices)
        {
            double total = 0;
            foreach (double pr in prices)
            {
                total += pr;
            }
            return total;
        }
    }
}
