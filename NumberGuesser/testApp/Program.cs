using System;

// name space is similar to package in java.
namespace testApp
{
    // this is our main class.
    class Program
    {
        // this is our main method(entry point).
        static void Main(string[] args)
        {
            // set app variables
            string appName = "testApp";
            string appVersion = "1.0.0";
            string appAuthor = "Arata Yano";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();

            Console.WriteLine("Please enter your username");
            string username = Console.ReadLine();
            Console.WriteLine("Welcome {0}", username);
        }
    }
}
