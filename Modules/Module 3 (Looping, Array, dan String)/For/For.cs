using System;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukkan ukuran array: ");
            int x = int.Parse(Console.ReadLine()); // Read and parse array size

            string[] number = new string[x]; // Declare an array of strings with size x

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine($"Masukkan isi array ke-{i + 1}: ");
                number[i] = Console.ReadLine(); // Assign input to array element
            }

            Console.WriteLine("\nIsi array:");
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine($"Isi array ke-{i + 1} adalah {number[i]}");
            }
        }
    }
}
