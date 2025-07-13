using System;

namespace StringSyntaxDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. String Initialization
            string greeting = "Hello";
            string name = "Mandy";

            // 2. String Concatenation
            string messageConcatenation = greeting + ", " + name + "!";
            Console.WriteLine("1. String Concatenation: " + messageConcatenation);

            // 3. String Interpolation
            string messageInterpolation = $"{greeting}, {name}!";
            Console.WriteLine("2. String Interpolation: " + messageInterpolation);

            // 4. Verbatim String (for multi-line strings)
            string filePath = @"C:\Users\Mandy\Documents\myfile.txt";
            Console.WriteLine("3. Verbatim String (File Path): " + filePath);

            // 5. String Methods
            string sentence = "Welcome to C# programming!";
            string upperCaseSentence = sentence.ToUpper();
            string subString = sentence.Substring(11, 2); // "C#"

            Console.WriteLine("4. String Methods:");
            Console.WriteLine("   Uppercase: " + upperCaseSentence);
            Console.WriteLine("   Substring: " + subString);

            // 6. String Escape Characters
            string escapedString = "He said, \"C# is awesome!\"";
            Console.WriteLine("5. Escaped String: " + escapedString);

            // 7. String Length
            int length = greeting.Length;
            Console.WriteLine("6. String Length of greeting: " + length); // Outputs 5

            // 8. Convert to Lowercase
            string lowerCaseSentence = sentence.ToLower();
            Console.WriteLine("7. Lowercase: " + lowerCaseSentence); // "welcome to c# programming!"

            // 9. Accessing Individual Characters
            char firstChar = greeting[0];  // Accessing the first character 'H'
            char lastChar = greeting[greeting.Length - 1]; // Accessing the last character 'o'
            Console.WriteLine($"8. First character: {firstChar}, Last character: {lastChar}");

            // 10. Find Index of a Character
            int indexOfChar = sentence.IndexOf('C'); // Finding index of 'C'
            Console.WriteLine("9. Index of 'C' in sentence: " + indexOfChar); // Outputs 11
        }
    }
}