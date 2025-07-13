using System;

namespace For_Each
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an array of strings
            string[] fruits = { "Apple", "Banana", "Cherry", "Date", "Elderberry" };

            // Use a foreach loop to iterate through the array
            Console.WriteLine("List of Fruits:");
            foreach (string fruit in fruits) // foreach (type variableName in arrayName) 
            {
                Console.WriteLine(fruit);
            }
        }
    }
}
