using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_While_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. While Loop
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine("i="+i);
                i++;
            }

            // 2. Do While
            int j = 0;
            do
            {
                Console.WriteLine("j="+j);
                j++;
            } while (j < 5);

            Console.ReadLine();
        }
    }
}
