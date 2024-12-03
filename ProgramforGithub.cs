using System;

namespace SampleProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Enhanced Calculator!");

            // Input first number
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            // Input second number
            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Calculate sum
            int sum = num1 + num2;
            Console.WriteLine($"The sum of {num1} and {num2} is {sum}.");

            // Calculate product (new feature)
            int product = num1 * num2;
            Console.WriteLine($"The product of {num1} and {num2} is {product}.");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
}
