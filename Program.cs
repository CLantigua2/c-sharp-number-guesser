﻿using System;

namespace Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            // run get app info
            GetAppInfo();

            while (true)
            {


                // Ask users name
                Console.WriteLine("What is your name?");
                // Get user input
                string username = Console.ReadLine();
                // user users name
                Console.WriteLine("Hello {0}, let's play a game...", username);
                // Init correct number
                // int correctNumber = 7;

                // Create new random object
                Random random = new Random();
                int correctNumber = random.Next(1, 11);

                // Init guess var
                int guess = 0;
                // Ask the user to guess a number
                Console.WriteLine("Guess a number between 1 and 10");
                // while guess is not correct
                while (guess != correctNumber)
                {
                    // Get users input
                    string userInput = Console.ReadLine();
                    // make sure input is a number
                    if (!int.TryParse(userInput, out guess))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("{0}, that's not even a number...", username);
                        Console.ResetColor();

                        // keep it going
                        continue;
                    }
                    // Cast to int and put into guess var
                    guess = Int32.Parse(userInput);
                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // change the color, output the message then change it back
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong number {0}, please try again...", username);
                        Console.ResetColor();
                    }

                }
                // Output success message
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Great job {0}!! The correct number was {1}!!...", username, correctNumber);
                Console.ResetColor();

                // Ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                // Get the answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
            }
        }
        // get the app info
        static void GetAppInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuther = "Carlos Lantigua";
            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;
            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuther);
            // reset color back
            Console.ResetColor();
        }
    }
}
