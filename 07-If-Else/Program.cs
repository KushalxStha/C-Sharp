using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_If_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5, y = 15;

            //if condition
            if (x < y)
            {
                Console.WriteLine($"{x} is smaller than {y}.");
            }

            //if else condition
            if (x > y)
            {
                Console.WriteLine($"{x} is greater.");
            }
            else
            {
                Console.WriteLine($"{y} is greater.");
            }

            //if else if condition
            if (x < y)
            {
                // 1st condition
            }
            else if (x > y)
            {
                // 2nd condition
            }
            else
            {
                // 3rd condition
            }

            Console.ReadLine();
        }
    }
}
