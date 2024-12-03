using System;

namespace SampleProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Sum Calculator!");

            // Input first number
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            // Input second number
            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Calculate sum
            int sum = num1 + num2;

            // Display result
            Console.WriteLine($"The sum of {num1} and {num2} is {sum}.");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
