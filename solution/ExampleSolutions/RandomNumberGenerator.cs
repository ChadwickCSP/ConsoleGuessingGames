namespace ExampleSolutions
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// This class contains an example of using a random number generator.
    /// </summary>
    public class RandomNumberGenerator
    {
        /// <summary>
        /// Generates the specified amount of random numbers within the minValue and maxValue range.
        /// </summary>
        /// <param name="minValue">The minimum number to generate.</param>
        /// <param name="maxValue">The maximum number to generate.</param>
        /// <param name="amount">The amount of random numbers to generate.</param>
        public static void Generate(int minValue, int maxValue, int amount)
        {
            // Declare local variables
            Random generator; // A random number generator
            List<int> numbers; // A list of randomly generated numbers

            // Initialize variables
            generator = new Random();
            numbers = new List<int>();

            Console.WriteLine($"Generating {amount} random numbers between {minValue} and {maxValue}");

            // Loop until the list contains the specified amount of random numbers
            while (numbers.Count < amount)
            {
                int newNumber; // Stores the randomly generated number

                // Generate a number between the minValue and maxValue.
                // The Next method won't include the highest value specified. To include it,
                // we add 1 to the value.
                newNumber = generator.Next(minValue, maxValue + 1);

                // Add the newNumber to the list
                numbers.Add(newNumber);
            }

            // Print a message but do not put a new line.
            Console.Write("Generated numbers:");

            // Iterate through each value in the numbers list assigning the
            // value to the variable number.
            foreach (int number in numbers)
            {
                Console.Write($" {number}");
            }
        }
    }
}
