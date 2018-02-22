using System;

namespace TestDotNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var dateTimeNow = DateTime.Now;

            Console.WriteLine("\nToday is {0:d} at {0:T}.", dateTimeNow);
            Console.Write("\nPress any key to continue... ");
            Console.ReadLine();
        }
    }
}
