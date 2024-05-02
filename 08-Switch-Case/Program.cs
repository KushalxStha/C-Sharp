using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number (1-7) to represent day of a week: ");
            string day = Console.ReadLine();

            switch (day)
            {
                case "1":
                    Console.WriteLine("Its Sunday");
                    break;

                case "2":
                    Console.WriteLine("Its Monday");
                    break;

                case "3":
                    Console.WriteLine("Its Tuesday");
                    break;

                case "4":
                    Console.WriteLine("Its Wednesday");
                    break;

                case "5":
                    Console.WriteLine("Its Thursday");
                    break;

                case "6":
                    Console.WriteLine("Its Friday");
                    break;

                case "7":
                    Console.WriteLine("Its Saturday");
                    break;

                default:
                    Console.WriteLine("Not valid day of week.");
                    break;
            }

            Console.ReadLine();
        }
    }
}
