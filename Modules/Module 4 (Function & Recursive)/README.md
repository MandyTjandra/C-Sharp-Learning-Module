# Module 4: Functions and Recursion in C#

This module introduces **Modular Programming**. Instead of writing all logic in `Main()`, we break code into smaller, reusable blocks called **Methods**.

---

## 1. Basic Methods (`Prototype_Fungsi.cs`)

A method is a block of code that runs only when it is called.

```csharp
using System;

class Program
{
    // 1. Definition: A 'void' method returns nothing
    static void Cetak()
    {
        Console.WriteLine("Hello, World!");
    }

    static void Main()
    {
        // 2. Call: Executing the method
        Cetak(); 
    }
}

```

**💡 Code Explanation:**

1. **`static void Cetak()`**:
* `static`: Means this method belongs to the class, not a specific object.
* `void`: Means this method does **not** return a value.


2. **`Cetak();`**: This line jumps the program execution to the `Cetak` block, runs the code inside, and then returns to `Main`.

---

## 2. Parameters & Return Values (`Function.cs`)

Methods become powerful when you pass data into them (**Parameters**) and get results back (**Return Values**).

```csharp
using System;

namespace Function
{
    class Calc
    {
        // A method that accepts two integers and returns an integer
        public static int Add(int a, int b)
        {
            return a + b; // Sends the result back to the caller
        }
    }

    class Program
    {
        static void Main()
        {
            // ... Input logic omitted ...
            
            // Calling a method from another class (Calc)
            int result = Calc.Add(a, b);
            
            Console.WriteLine("Sum: " + result);
        }
    }
}

```

**💡 Code Explanation:**

1. **`int Add(...)`**: The `int` at the start signifies that this method **must** give back an integer number.
2. **`(int a, int b)`**: These are parameters. When you call `Add(5, 10)`, `a` becomes 5 and `b` becomes 10.
3. **`Calc.Add(a, b)`**: Since the method is inside the `Calc` class, we access it using `ClassName.MethodName`.

---

## 3. Recursion (`Recursive.cs`)

Recursion is a technique where a method calls **itself** to solve a problem. This is commonly used for mathematical sequences like Fibonacci.

```csharp
static int Fibonacci(int n)
{
    // 1. BASE CASE: Stop the recursion
    if (n == 0) return 0;
    if (n == 1) return 1;

    // 2. RECURSIVE CASE: Call itself with a smaller input
    return Fibonacci(n - 1) + Fibonacci(n - 2);
}

```

### 💡 Logic Breakdown

If we call `Fibonacci(4)`, the program breaks it down like this:

1. `Fib(4)` needs `Fib(3) + Fib(2)`
2. `Fib(3)` needs `Fib(2) + Fib(1)`
3. Eventually, it hits `Fib(1)` (which returns 1) or `Fib(0)` (which returns 0).
4. The results bubble back up to calculate the final sum.

### Practical Usage in `Main`

The uploaded code also demonstrates using a loop to print the entire sequence:

```csharp
Console.Write("Fibonacci sequence: ");
for (int i = 0; i <= position; i++)
{
    int fib = Fibonacci(i); // Calculate for each number
    Console.Write($"{fib} ");
    sum += fib;
}
