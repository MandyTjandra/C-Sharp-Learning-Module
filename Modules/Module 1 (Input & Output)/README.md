# Module 1: Input, Output, and Variables in C#

This module introduces the fundamental structure of a C# (.NET) program. It covers console streaming, input handling, variable definitions, constants, and type casting.

---

## 🎯 Learning Objectives

By the end of this module, students and learners will be able to:
- Structure a valid C# application using `using System;`, `namespace`, `class`, and `static void Main()`.
- Stream text to the console with and without newlines using `Console.WriteLine()` and `Console.Write()`.
- Declare and initialize fundamental C# types (`string`, `int`, `double`, `bool`).
- Prevent variable mutation using the `const` modifier.
- Read console input using `Console.ReadLine()`.
- Convert between types using explicit casting (`(int)doubleVal`) and understand truncation.

---

## 1. Basic Structure & Output (`Input_and_Output.cs`)

Every C# program executes within a class. The entry point of the program is the `Main` method.

```csharp
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Outputting text with a newline
            Console.WriteLine("Hello World!");
            
            // Outputting text without a newline
            Console.Write("This is without space");
            Console.WriteLine(" (I will print on the same line.)");
            
            // Performing inline arithmetic
            Console.WriteLine(3 + 3); 
        }
    }
}
```

**💡 Code Explanation:**

1. **`using System;`**: Imports standard framework types so we can call `Console.WriteLine` directly.
2. **`Console.WriteLine()`**: Prints the provided value and advances the cursor to the next line.
3. **`Console.Write()`**: Prints without advancing to the next line.
4. **Comments**: `//` for single-line comments; `/* ... */` for multiline blocks.

---

## 2. Variables and Data Types

C# is a strongly-typed language requiring explicit or inferred types:

```csharp
string firstname = "Mandy";
string lastname = " Tjandra";
int age = 19;
const double pi = 3.14; // Value is immutable at compile time
double test = 2.25;

Console.WriteLine(firstname + lastname); // String Concatenation
Console.WriteLine(age);
Console.WriteLine(pi);
Console.WriteLine(age + test); // Implicit widening to double (21.25)
```

**💡 Code Explanation:**

1. **`string`**: Text sequence enclosed in double quotes.
2. **`int`**: 32-bit signed integer.
3. **`double`**: 64-bit double-precision floating-point number.
4. **`const`**: Enforces compile-time immutability.

---

## 3. Handling User Input

Reading user input is achieved via `Console.ReadLine()`, which always returns a `string`:

```csharp
Console.WriteLine("Type your username: ");
string username = Console.ReadLine(); // Waits for user input

// String Concatenation:
Console.WriteLine("Your username is: " + username);

// String Interpolation (Modern & Recommended):
Console.WriteLine($"Your username is: {username}");
```

---

## 4. Type Casting (Conversion)

Converting between types can be done explicitly or using conversion helper classes:

```csharp
double mydouble = 5.55;

// Explicit manual casting (truncates decimal part)
int myint = (int)mydouble; 

Console.WriteLine(myint); // Output: 5
```

**💡 Key Takeaway:**
Casting `(int)5.55` truncates decimals without rounding. For rounded conversions, use `Convert.ToInt32(mydouble)`.

---

## ⚠️ Common Pitfalls & Tips

1. **Nullability with `Console.ReadLine()`:**
   In modern C# (.NET 6+), `Console.ReadLine()` returns a nullable string (`string?`). If the stream ends (e.g. redirected input), it returns `null`.
2. **Crash on Unsafe Parsing:**
   Avoid `int.Parse(Console.ReadLine())` directly without checking, because user typing non-numeric text triggers a `FormatException`. Prefer `int.TryParse()` (covered in Module 2).
3. **Integer Division Truncation:**
   `int result = 5 / 2;` evaluates to `2`. To get `2.5`, write `5.0 / 2` or cast `(double)5 / 2`.

---

## 🧪 Hands-On Practice Challenges

- 🟢 **Challenge 1 (Personal Profile Card)**:
  Prompt the user for their name, hobby, and age. Print a formatted profile card using string interpolation `$"{}"`.
- 🟡 **Challenge 2 (Temperature Converter)**:
  Prompt the user to enter a temperature in Celsius. Convert it to Fahrenheit ($F = C \times 1.8 + 32$) and display the result formatted to 2 decimal places.
- 🔴 **Challenge 3 (Cashier Bill Calculator)**:
  Prompt the user for an item name, quantity, and unit price (as double). Compute the subtotal, apply a 10% tax, and print an aligned receipt.
