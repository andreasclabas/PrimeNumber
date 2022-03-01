//
// Author: Andrea Sclabas
// Date  : 01/03/2022 
//
// Task: Write a c# program to check prime number.

namespace PrimeNumber
{
    class PrimeNumber
    {
        /// <summary>
        /// Entry point of the program
        /// </summary>
        private static void Main()
        {
            bool firstCycle = true;
            string? input;
            int NumberToCheck;

            do
            {
                // Error message visible only from the second cycle
                if (!firstCycle)
                {
                    Console.WriteLine("Invalid number! Retry or digit EXIT to close.");
                }

                // Ask for the number to check
                Console.Write("Number to check: ");
                input = Console.ReadLine();

                // Exit condition
                if (input == "EXIT")
                    return;

                firstCycle = false;

                // Exit if a valid number has been provided
            } while (!int.TryParse(input, out NumberToCheck));

            string output = "prime number";

            // Check for divisors
            for (int i = 2; i<NumberToCheck; i++)
            {
                if ((NumberToCheck % i) == 0)
                {
                    output = $"not a prime number. First divisor found is {i}";
                    break;
                }
            }

            Console.WriteLine($"{NumberToCheck} is {output}");
        }
    }
}


