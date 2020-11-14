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
            string input = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets play a game...", input);

            

        }
    }
}
