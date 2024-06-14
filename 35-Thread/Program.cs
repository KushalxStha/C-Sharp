using System;
using System.Threading;

namespace _35_Thread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Thread = An execution path of a program.
            //          We can use multiple thread to perform,
            //          different tasks of our program at the same time.
            //          Current thread running is "main" thread.

            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";

            Thread thread1 = new Thread(CountDown);
            Thread thread2 = new Thread(()=> CountUp("Thread 2"));  // If Parameter in Method

            thread1.Start();
            thread2.Start();

            //CountDown();
            //CountUp();

            Console.WriteLine(mainThread.Name + " is complete.");

            Console.ReadKey();
        }

        public static void CountDown()
        {
            for (int i=10; i>=0; i--)
            {
                Console.WriteLine("Timer 1#: "+i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer 1 is complete.");
        }

        public static void CountUp(string nothing)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Timer 2#: " + i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer 2 is complete.");
        }
    }
}
