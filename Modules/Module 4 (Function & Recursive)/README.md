# Module 4: Functions and Recursion in C#

This module covers **Methods (Functions)**, which break complex logic into reusable blocks, and **Recursion**, where methods invoke themselves to solve mathematical sequences.

---

## 🎯 Learning Objectives

By the end of this module, students and learners will be able to:
- Declare and invoke static methods with parameters and return values.
- Call methods defined in external utility classes (e.g. `Calc.Add(a, b)`).
- Understand call stack mechanics and execution flow during method invocations.
- Implement recursive methods with explicit base cases to prevent stack overflow.
- Compute mathematical sequences (such as Fibonacci) and aggregate their results.

---

## 📁 Subfolder Overview

* [`Function/`](./Function) — Encapsulating logic in classes and invoking static methods (`Function.cs`).
* [`Prototype Fungsi/`](./Prototype%20Fungsi) — Defining and calling modular methods (`Prototype_Fungsi.cs`).
* [`Recursive/`](./Recursive) — Recursive Fibonacci generator with base and recursive cases (`Recursive.cs`).

---

## 1. Class Methods (`Function/Function.cs`)

In C#, all functions exist inside classes and are referred to as **methods**. A `static` method belongs to the class itself and can be called without instantiating an object:

```csharp
using System;

namespace Function
{
    class Calc
    {
        // Reusable static method
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Input first number: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Input second number: ");
            int b = int.Parse(Console.ReadLine());

            // Call method directly using ClassName.MethodName
            int result = Calc.Add(a, b);
            Console.WriteLine("Sum: " + result);
        }
    }
}
```

**💡 Code Explanation:**

1. **`public static int Add(...)`**:
   * `public`: Accessible from other classes.
   * `static`: Called directly via `Calc.Add(...)` without `new Calc()`.
   * `int`: Declares the return type.
2. **Parameters (`int a, int b`)**: Data passed into the method.
3. **`return`**: Passes the computed sum back to the caller.

---

## 2. Basic Static Methods (`Prototype Fungsi/Prototype_Fungsi.cs`)

Methods declared in the same class can be called directly by identifier:

```csharp
using System;

class Program
{
    static void Cetak()
    {
        Console.WriteLine("Hello, World!");
    }

    static void Main()
    {
        Cetak(); // Invoking the method
    }
}
```

---

## 3. Recursion & Base Cases (`Recursive/Recursive.cs`)

Recursion is a programming pattern where a method calls itself to solve smaller subproblems:

```csharp
static int Fibonacci(int n)
{
    // BASE CASES: stops recursion
    if (n == 0) return 0;
    if (n == 1) return 1;

    // RECURSIVE CASE:
    return Fibonacci(n - 1) + Fibonacci(n - 2);
}
```

### 💡 Execution Tree for `Fibonacci(4)`:
```
               Fib(4)
              /      \
          Fib(3)    Fib(2)
          /    \    /    \
      Fib(2) Fib(1) Fib(1) Fib(0)
      /    \
    Fib(1) Fib(0)
```

In `Recursive.cs`, the program computes the sequence iteratively up to a target position and displays the cumulative sum:

```csharp
Console.Write("Fibonacci sequence: ");
for (int i = 0; i <= position; i++)
{
    int fib = Fibonacci(i);
    Console.Write($"{fib} ");
    sum += fib;
}
```

---

## ⚠️ Common Pitfalls & Tips

1. **Missing Base Case (StackOverflowException):**
   If a recursive method does not reach a base case, the runtime exhausts call stack memory and terminates with a `StackOverflowException`.
2. **Exponential Complexity of Pure Recursion:**
   Naive recursive `Fibonacci(n)` has $O(2^n)$ time complexity. For large $n$, use an iterative loop or memoization array to achieve $O(n)$ time.
3. **`static` vs Non-Static Context:**
   From inside `static void Main()`, you cannot directly call non-static methods without creating an instance: `new MyClass().MyMethod()`.

---

## 🧪 Hands-On Practice Challenges

- 🟢 **Challenge 1 (Recursive Factorial)**:
  Write a static recursive method `long Factorial(int n)` where $n! = n \times (n-1)!$ and $0! = 1$.
- 🟡 **Challenge 2 (Math Utility Class)**:
  Create a static class `MathUtil` with methods:
  * `IsPrime(int n)` (returns bool)
  * `Gcd(int a, int b)` (returns greatest common divisor)
- 🔴 **Challenge 3 (Sum of Digits via Recursion)**:
  Write a recursive method `int SumOfDigits(int n)` that sums all digits of a number (e.g. for `1234`, returns $1 + 2 + 3 + 4 = 10$).
