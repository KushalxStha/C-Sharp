using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exception = errors that occur during execution
            
            // try     = try some code that is considered "dangerous"
            // catch   = catches and handles exceptions when they occur
            // finally = always executes regardless if exception is caught or not
            try
            {
                Console.Write("Enter 1st number: ");
                double x = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter 2nd number: ");
                double y = Convert.ToDouble(Console.ReadLine());

                double z = x / y;
                Console.WriteLine($"{x} divided by {y} is {z}");
            }
            catch(FormatException e)
            {
                Console.WriteLine("Only numbers PLEASE!");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("You CANNOT divide by ZERO!");
            }
            catch(Exception e)
            {
                Console.WriteLine("Somoething went wrong!");
            }
            finally
            {
                Console.WriteLine("This program executed successfully.");
            }

            Console.ReadKey();
        }
    }
}
