using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string txt = "Hello! I am Kushal.";

            // String Length
            Console.WriteLine("The length of the text is :" + txt.Length);

            // String Methods
            Console.WriteLine(txt.ToLower());
            Console.WriteLine(txt.ToUpper());

            // String Interpolation
            string fname = "Kushal";
            string lname = "Shrestha";
            string name = $"My full name is {fname} {lname}";
            Console.WriteLine(name);

            // Access Strings
            Console.WriteLine(txt[0]);            // Character at [0]
            Console.WriteLine(txt.IndexOf("K"));  // Location of K

            int charsAfter = txt.IndexOf("a");
            Console.WriteLine(txt.Substring(charsAfter));  // String after specific location

            // Escape Sequence
            // Backslash (\) escape character turns special chars into string chars
            Console.WriteLine("We are the \"Gurkhas\" from Nepal.");
            Console.WriteLine("In new \n line");
            Console.WriteLine("Tab \t in-between");
            Console.WriteLine("Back\b space");
            Console.ReadLine();
        }
    }
}
