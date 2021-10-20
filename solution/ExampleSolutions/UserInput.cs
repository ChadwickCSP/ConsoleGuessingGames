namespace ExampleSolutions
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// This class contains an example of reading user input in the console.
    /// </summary>
    public class UserInput
    {
        /// <summary>
        /// Plays a Simple Guessing game where the player must guess a number between 0 and 100.
        /// </summary>
        public static void Run()
        {
            // Declare local variables
            string userName; // A string that represents the users name.
            int age; // An integer that represents the users age.

            // Prints a message to the screen
            Console.WriteLine("What is your name?");

            // Waits for the user to type something into the console,
            // then assigns the result to the variable userName
            userName = Console.ReadLine();

            Console.WriteLine("How many years old are you?");

            // Waits for the user to type something into the console
            // then trys to convert the entered value to an integer
            // then stores the result in the variable age
            age = int.Parse(Console.ReadLine());

            // Prints out a message to the user using the variables
            Console.WriteLine($"Hello, {userName}! You're {age} years old? Wow!");
        }
    }
}
