using System;

namespace TestDotNetCore
{
    class Program
    {
        private const string formatResponse = "\nYou typed [ {0} ] characters";

        static void Main(string[] args)
        {
            var dateTimeNow = DateTime.Now;

            Console.Clear();
            Console.WriteLine("\nToday is {0:d} at {0:T}.", dateTimeNow);
            Console.WriteLine("\nPress any key to continue... ");
            Console.ReadLine();
            Console.Clear();
            Talk();
        }

        static void Talk()
        {
            while (true) //TASK Loop indefinitely
            {
                Console.Clear();
                Console.WriteLine("Type exit to stop");
                Console.WriteLine("\nAsk me something:");
                var line = Console.ReadLine();
                if (null == line)
                    continue;
                if (line.ToLower() == "exit")
                    break;

                Console.WriteLine(formatResponse, line.Length);
                Console.WriteLine("\nPress any key to continue... ");
                Console.ReadLine();
             }
        }
    }
}
