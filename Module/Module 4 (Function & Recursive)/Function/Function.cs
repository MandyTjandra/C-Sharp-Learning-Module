using System;

namespace Function
{
    class Calc
    {
        // Method to add two numbers
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }

    class Program
    {
        static void Main()
        {
            // Input first number
            Console.WriteLine("Input first number: ");
            string inputA = Console.ReadLine();
            int a = int.Parse(inputA); // Convert string to int

            // Input second number
            Console.WriteLine("Input second number: ");
            string inputB = Console.ReadLine();
            int b = int.Parse(inputB); // Convert string to int

            // Call the Add method using the Calc class
            int result = Calc.Add(a, b);
            Console.WriteLine("Sum: " + result);
        }
    }
}
