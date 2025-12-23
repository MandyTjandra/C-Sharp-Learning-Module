# Module 1: Input, Output, and Variables in C#

This module introduces the fundamental structure of a C# program. It covers how to display text to the user, how to receive input, how to store data using variables, and how to convert between different data types.

---

## 1. Basic Structure & Output (`Input_and_Output.cs`)

Every C# program starts with a `namespace` and a `class`. The entry point of the program is the `Main` method.

```csharp
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Outputting text with a new line
            Console.WriteLine("Hello World!");
            
            // Outputting text without a new line
            Console.Write("This is without space");
            Console.WriteLine(" (I will print on the same line.)");
            
            // Performing arithmetic inside WriteLine
            Console.WriteLine(3 + 3); 
        }
    }
}

```

**💡 Code Explanation:**

1. **`using System;`**: Includes the basic C# library so we don't have to type `System.Console.WriteLine` every time.
2. **`Console.WriteLine()`**: Prints text to the console and moves the cursor to the next line.
3. **`Console.Write()`**: Prints text but keeps the cursor on the same line.
4. **Comments:** Lines starting with `//` are single-line comments, and blocks inside `/* ... */` are multi-line comments.

---

## 2. Variables and Data Types

C# is a strongly typed language, meaning you must declare the type of data a variable will hold.

```csharp
string firstname = "Mandy";
string lastname = " Tjandra";
int age = 19;
const double pi = 3.14; // Constant: value cannot be changed
double test = 2.25;

Console.WriteLine(firstname + lastname); // String Concatenation
Console.WriteLine(age);
Console.WriteLine(pi);

```

**💡 Code Explanation:**

1. **`string`**: Stores text (e.g., "Mandy").
2. **`int`**: Stores whole numbers (e.g., 19).
3. **`double`**: Stores decimal numbers (e.g., 2.25).
4. **`const`**: Declares a constant variable. If you try to change `pi` later in the code, the program will crash or fail to compile.

---

## 3. Handling User Input

Reading input in C# is done using `Console.ReadLine()`, which always returns a **string**.

```csharp
Console.WriteLine("Type your username: ");
string username = Console.ReadLine(); // Waits for user input

Console.WriteLine("Your username is: " + username);
// Console.WriteLine($"Your username is: {username}"); // String Interpolation

```

**💡 Code Explanation:**

1. **`Console.ReadLine()`**: Pauses the program and waits for the user to type something and press Enter.
2. **String Concatenation (`+`)**: Joins two strings together ("Your username is: " + username).
3. **String Interpolation (`$"{}"`)**: A modern, cleaner way to insert variables directly into strings (commented out in the code example).

---

## 4. Type Casting (Conversion)

Sometimes you need to convert one data type to another, for example, converting a decimal (`double`) to a whole number (`int`).

```csharp
double mydouble = 5.55;

// Explicit Casting (Manual)
int myint = (int)mydouble; 

Console.WriteLine(myint); // Output: 5
// Console.WriteLine(Convert.ToInt32(mydouble)); // Alternative using Convert class

```

**💡 Code Explanation:**

1. **`(int)mydouble`**: This manually converts the double `5.55` into an integer.
2. **Result**: Casting a double to an int **truncates** (cuts off) the decimal part. It does not round up. So `5.55` becomes `5`.
