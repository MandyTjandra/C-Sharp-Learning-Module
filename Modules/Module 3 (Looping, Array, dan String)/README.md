# Module 3: Loops, Arrays, and Strings in C#

This module covers iteration control structures, data collections (1D arrays, rectangular 2D matrices, and sorting), and string operations in C#.

---

## 🎯 Learning Objectives

By the end of this module, students and learners will be able to:
- Construct counted `for`, condition-driven `while`, and post-test `do-while` loops.
- Iterate over collections cleanly using the `foreach` statement.
- Generate coordinate and grid patterns with nested loops.
- Declare, allocate, index, and mutate 1D arrays and 2D rectangular matrices (`int[,]`).
- Sort, reverse, and aggregate arrays using `Array.Sort()`, `Array.Reverse()`, and LINQ (`.Max()`, `.Min()`, `.Sum()`).
- Manipulate text with string interpolation (`$""`), verbatim string literals (`@""`), `.ToUpper()`, `.ToLower()`, `.Substring()`, and `.IndexOf()`.

---

## 📁 Subfolder Overview

* [`For/`](./For) — Dynamic user-sized array allocation and iteration (`For.cs`).
* [`While/`](./While) — Pre-test condition loops (`While.cs`).
* [`Do While/`](./Do%20While) — Post-test iteration loops (`Do While.cs`).
* [`For Each/`](./For%20Each) — Reading elements cleanly with `foreach` (`For Each.cs`).
* [`Nested For/`](./Nested%20For) — Multi-tier outer and inner iterations (`Nested For.cs`).
* [`Array/`](./Array) — 1D integer arrays, indexing, and arithmetic (`Array.cs`).
* [`Multidimensional Array/`](./Multidimensional%20Array) — 2D rectangular arrays `int[,]` (`Multidimensional Array.cs`).
* [`Sort Array/`](./Sort%20Array) — Alphabetical and descending sorts, LINQ aggregates (`Sort Array.cs`).
* [`String/`](./String) — 10 comprehensive string methods and syntax demos (`String.cs`).

---

## 1. Iteration & Loops

C# provides four primary looping constructs:

### A. For Loop (`For/For.cs`)
Ideal when the number of cycles is determined beforehand:

```csharp
Console.WriteLine("Masukkan ukuran array: ");
int x = int.Parse(Console.ReadLine());

string[] number = new string[x]; // Dynamic size allocation

for (int i = 0; i < x; i++)
{
    Console.WriteLine($"Masukkan isi array ke-{i + 1}: ");
    number[i] = Console.ReadLine();
}
```

### B. While and Do-While (`While/While.cs` & `Do While/Do While.cs`)
* **`while`**: Evaluates the condition *before* executing the body.
* **`do-while`**: Evaluates the condition *after* executing the body (guarantees at least 1 iteration).

```csharp
int i = 0;
do {
    Console.WriteLine($"Iterasi ke-{i}");
    i++;
} while (i <= 3);
```

### C. Foreach Loop (`For Each/For Each.cs`)
The cleanest, most readable way to iterate through read-only items in a collection:

```csharp
string[] fruits = { "Apple", "Banana", "Cherry", "Date" };

foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}
```

### D. Nested Loops (`Nested For/Nested For.cs`)
Inner loop runs to completion for every single outer loop iteration:

```csharp
for (int i = 1; i <= 2; ++i)
{
    for (int j = 1; j <= 3; j++)
    {
        Console.WriteLine($"Outer: {i}, Inner: {j}");
    }
}
```

---

## 2. Arrays & Matrices

### A. 1D Arrays (`Array/Array.cs`)
Arrays are zero-indexed and store contiguous elements of fixed length:

```csharp
int[] x = { 12, 14, 16, 18, 20 };
Console.WriteLine($"Third: {x[2]}, Fifth: {x[4]}, Sum: {x[0] + x[4]}");
```

### B. Multidimensional Rectangular Arrays (`Multidimensional Array/Multidimensional Array.cs`)
C# uses comma syntax `[,]` for true 2D rectangular matrices:

```csharp
// [Row, Column]
int[,] numbers = { { 10, 20, 30 }, { 40, 50, 60 } };

Console.WriteLine($"Row 0, Col 2: {numbers[0, 2]}"); // 30
Console.WriteLine($"Row 1, Col 1: {numbers[1, 1]}"); // 50
```

### C. Array Sorting & LINQ Aggregates (`Sort Array/Sort Array.cs`)

```csharp
using System.Linq;

string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
int[] myNumbers = { 5, 1, 8, 9 };

Array.Sort(cars);                   // Alphabetical ascending
Array.Reverse(cars);                // Descending order

Console.WriteLine($"Max: {myNumbers.Max()}");
Console.WriteLine($"Min: {myNumbers.Min()}");
Console.WriteLine($"Sum: {myNumbers.Sum()}");
```

---

## 3. String Manipulation (`String/String.cs`)

C# `System.String` provides powerful built-in text manipulation capabilities:

```csharp
// 1. Interpolation vs Concatenation
string name = "Mandy";
string greeting = $"Hello, {name}!";

// 2. Verbatim String (avoids escaping backslashes in paths)
string filePath = @"C:\Users\Mandy\Documents\myfile.txt";

// 3. Transformations & Slicing
string sentence = "Welcome to C# programming!";
string upper = sentence.ToUpper();
string sub = sentence.Substring(11, 2); // "C#"
int index = sentence.IndexOf('C');     // 11
```

---

## ⚠️ Common Pitfalls & Tips

1. **`IndexOutOfRangeException`:**
   Accessing an index $\ge$ `array.Length` throws an exception. Remember valid indices run from `0` to `Length - 1`.
2. **`foreach` Loop Iteration Variable is Read-Only:**
   You cannot modify an array element inside a `foreach` loop:
   ```csharp
   // ❌ Compiler Error:
   foreach (int n in myNumbers) { n = n * 2; }

   // ✅ Fix: use a standard for loop:
   for (int i = 0; i < myNumbers.Length; i++) { myNumbers[i] *= 2; }
   ```
3. **Rectangular `int[,]` vs Jagged `int[][]`:**
   * `int[,]` is a fixed rectangular grid: `arr[row, col]`.
   * `int[][]` is an array of arrays (where rows can have varying lengths): `arr[row][col]`.

---

## 🧪 Hands-On Practice Challenges

- 🟢 **Challenge 1 (Even Number Collector)**:
  Given an array of integers, use a `for` loop to filter out and display only the even numbers, then compute their sum.
- 🟡 **Challenge 2 (2D Matrix Transpose)**:
  Given a $2 \times 3$ matrix, create and display its $3 \times 2$ transpose matrix (where rows become columns).
- 🔴 **Challenge 3 (Word Counter & Reverse)**:
  Prompt the user for a sentence. Split the words, count how many words it contains, and print the sentence with the word order reversed.
