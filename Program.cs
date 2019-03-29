using System;

namespace Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set App vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuther = "Carlos Lantigua";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;
            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuther);
            // reset color back
            Console.ResetColor();
            // Ask users name
            Console.WriteLine("What is your name?");
            // Get user input
            string input = Console.ReadLine();

        }
    }
}
