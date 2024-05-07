using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Break_Continue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i =0;i<10; i++)
            {
                if (i == 5)
                {
                    break; // Stops if i is 5
                }
                Console.WriteLine(i);
            }

            for(int j = 0; j < 10; j++)
            {
                if (j == 5)
                {
                    continue; // Skips 5
                }
                Console.WriteLine(j);
            }

            Console.ReadLine();
        }
    }
}
