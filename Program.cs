using System;
//NAMESPACE
namespace dotnet
{
// Main Class
    class Program
    {
    //entry point method
        static void Main(string[] args)
        //set app variables
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Dwayne Burrows";

            //color changer
            Console.ForegroundColor = ConsoleColor.Green;
            // write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //RE - Set color scheme
            Console.ResetColor();

            //ask user name
            Console.WriteLine("What is your name?");

            //Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets play a game...", inputName);

            //set correct number of
            int correctNumber = 7;

            //guess variable
            int guess = 0;

            //ask user to guess Number
            Console.WriteLine("Guess a Number between 1 and 10");

            //while guess is not correct
            while(guess != correctNumber) {
                //getuser input
                string input = Console.ReadLine();

                //cast to int and put in guess
                guess = Int32.Parse(input);

                //match guess to correct number and
                if(guess != correctNumber) {
                //change color
                Console.ForegroundColor = ConsoleColor.Red;

                //write out app info to
                Console.WriteLine("WRONG, again.");

                Console.ResetColor();
                }

            }

            //success message when numbers guess correct
            Console.ForegroundColor = ConsoleColor.Yellow;

            //tell user answer was guessed correctly
            Console.WriteLine("That is CORRECT!");

            Console.ResetColor();

        }
    }
}
