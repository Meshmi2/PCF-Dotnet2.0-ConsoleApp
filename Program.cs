using System;

namespace DOTNETCORE2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize Console App
            Console.WriteLine("Started Console app");
            int i;
            i = 1;
            // Read User Input
            Console.WriteLine("how often do you want the loop time?");
            int loopvalue = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                // Define Loop Time
                System.Threading.Thread.Sleep(loopvalue);
                // Initialize Loop
                Console.WriteLine("Loop # {0}", i);
                i++;
            }

        }

    }
}
