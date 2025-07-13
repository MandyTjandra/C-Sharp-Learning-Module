using System;
using System.Linq;

namespace Sort_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            int[] myNumbers = { 5, 1, 8, 9 };

            // Sorting string array in alphabetical order
            Array.Sort(cars);

            // Displaying sorted string array
            for (int i = 0; i < cars.Length; i++)
            {
                if (i == cars.Length - 1) // Last element
                    Console.Write(cars[i]);
                else
                    Console.Write($"{cars[i]}, ");
            }

            Console.WriteLine(); // New line

            Array.Sort(cars);
            Array.Reverse(cars); // Reversing string array

            // Displaying sorted string array (reversed)
            for (int i = 0; i < cars.Length; i++)
            {
                if (i == cars.Length - 1) // Last element
                    Console.Write(cars[i]);
                else
                    Console.Write($"{cars[i]}, ");
            }

            Console.WriteLine();

            // Sorting number array in descending order
            Array.Sort(myNumbers);

            // Displaying sorted number array
            for (int i = 0; i < myNumbers.Length; i++)
            {
                if (i == myNumbers.Length - 1) // Last element
                    Console.WriteLine(myNumbers[i]);
                else
                    Console.Write($"{myNumbers[i]}, ");
            }

            // Sorting number array in descending order
            Array.Sort(myNumbers);
            Array.Reverse(myNumbers); // Reverse to get largest to smallest order

            // Displaying sorted number array
            for (int i = 0; i < myNumbers.Length; i++)
            {
                if (i == myNumbers.Length - 1) // Last element
                    Console.WriteLine(myNumbers[i]);
                else
                    Console.Write($"{myNumbers[i]}, ");
            }

            // Displaying additional info
            Console.WriteLine($"Max: {myNumbers.Max()}");  // returns the largest value
            Console.WriteLine($"Min: {myNumbers.Min()}");  // returns the smallest value
            Console.WriteLine($"Sum: {myNumbers.Sum()}");  // returns the sum of elements
        }
    }
}
