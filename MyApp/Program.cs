// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Calculator class
            Calculator calculator = new Calculator();

            // Perform addition using the Add method
            int result = calculator.Add(5, 7);

            // Display the result
            Console.WriteLine($"The result of adding 5 and 7 is: {result}"); // Output: The result of adding 5 and 7 is: 12
        }
    }
}

