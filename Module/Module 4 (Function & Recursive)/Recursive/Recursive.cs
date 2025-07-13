using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the position in the Fibonacci sequence: ");
        int position = int.Parse(Console.ReadLine());

        Console.WriteLine(new string('-', 30)); // Line separator

        int sum = 0;

        // Print Fibonacci sequence
        Console.Write("Fibonacci sequence: ");
        for (int i = 0; i <= position; i++)
        {
            int fib = Fibonacci(i);
            Console.Write($"{fib} ");
            sum += fib; // Add each Fibonacci number to the sum
        }
        Console.WriteLine(); // Newline after sequence

        // Display the total sum
        Console.WriteLine($"Sum of all numbers in the sequence: {sum}");

        // Display the number at the given position
        int result = Fibonacci(position);
        Console.WriteLine($"The number at position {position} is {result}");
    }

    static int Fibonacci(int n)
    {
        // Base cases
        if (n == 0) return 0;
        if (n == 1) return 1;

        // Recursive case
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}
