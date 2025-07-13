using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            string firstname = "Mandy";
            string lastname = " Tjandra";
            int age = 19;
            const double pi = 3.14; // Using const so the value can't be changed
            double test = 2.25;
            double mydouble = 5.55;
            int myint = (int)mydouble; // Casting double to int

            Console.WriteLine("Type your username: ");
            string username = Console.ReadLine(); // Read user input
            Console.WriteLine("Your username is: " + username);
            // Console.WriteLine($"Your username is: {username}"); // Other way
            Console.WriteLine("Hello World!");
            Console.WriteLine(3 + 3);
            Console.Write/*Line*/("This is without space");
            Console.WriteLine(" (I will print on the same line.)");
            Console.WriteLine(firstname + lastname); // Display variable
            Console.WriteLine(age);
            Console.WriteLine(pi);
            Console.WriteLine(age + test);
            Console.WriteLine(myint);
            // Console.WriteLine(Convert.ToInt(mydouble)); // Other way to convert double to int

            // This is a single line comment.
            
            /* This is a multiple lines comment
               Test
               Test */
        }
    }
}
