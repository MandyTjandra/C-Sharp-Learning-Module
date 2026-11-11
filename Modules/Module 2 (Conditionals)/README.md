# Module 2: Conditional Logic in C#

This module covers how to direct program execution flow based on runtime conditions. You will learn to use `if-else` blocks for complex condition checks and `switch` statements for selecting between distinct discrete values.

---

## 🎯 Learning Objectives

By the end of this module, students and learners will be able to:
- Direct program flow using `if`, `else if`, and `else` statements.
- Safely parse user input without throwing runtime exceptions using `int.TryParse(input, out value)`.
- Tokenize and split multi-word user input strings with `string.Split(' ')`.
- Convert characters to numerical ASCII values via `(int)charVal`.
- Implement clean jump-table dispatching using `switch`, `case`, `break`, and `default`.

---

## 📁 Subfolder Overview

* [`If/`](./If) — Complex condition handling, token splitting, string-to-ASCII conversion, and age validation (`If.cs`).
* [`Switch/`](./Switch) — Categorical menu selection and safe numeric parsing (`Switch.cs`).

---

## 1. If-Else Statements (`If/If.cs`)

This program demonstrates complex data parsing and validation. It accepts a composite string (`"John Doe 25"`), parses individual components, and compares the **ASCII value** of a character against an integer age.

```csharp
using System;

namespace If
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukan nama dan umur (contoh: John Doe 25): ");
            string input = Console.ReadLine();
            
            // 1. Split the string into an array based on spaces
            string[] parts = input.Split(' ');
            if (parts.Length < 3)
            {
                Console.WriteLine("Input tidak valid. Masukkan dalam format: Nama Depan Nama Belakang Umur.");
                return;
            }

            string secondWord = parts[1];
            int umur;
            
            // 2. Safe Parsing with TryParse (prevents crashes)
            bool isValidAge = int.TryParse(parts[2], out umur);
            if (!isValidAge)
            {
                Console.WriteLine("Umur harus berupa angka!");
                return;
            }

            // 3. Extract first character of second word and obtain its ASCII code
            char firstLetterOfSecondWord = secondWord[0];
            int asciiValue = (int)firstLetterOfSecondWord;

            // 4. Comparison
            if (asciiValue > umur)
            {
                Console.WriteLine($"Huruf pertama '{firstLetterOfSecondWord}' ({asciiValue}) > umur ({umur}), Anda eligible!");
            }
            else if (asciiValue < umur)
            {
                Console.WriteLine($"Huruf pertama '{firstLetterOfSecondWord}' ({asciiValue}) < umur ({umur}), Anda tidak eligible.");
            }
            else
            {
                Console.WriteLine("Huruf pertama sama dengan angka umur.");
            }
        }
    }
}
```

**💡 Code Explanation:**

1. **`input.Split(' ')`**: Breaks the string into separate words stored in a `string[]` array.
2. **`int.TryParse(string, out int)`**: Attempts to convert text into an integer. If parsing succeeds, it returns `true` and populates `umur`. If parsing fails, it safely returns `false` without throwing an unhandled exception.
3. **`(int)char`**: Casting a character to an `int` exposes its underlying Unicode/ASCII numeric code (e.g. `'D'` is 68).

---

## 2. Switch Statements (`Switch/Switch.cs`)

When testing a single variable against multiple fixed options, a `switch` statement provides readable, efficient code:

```csharp
using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukkan sebuah angka (1-5): ");
            string input = Console.ReadLine();

            int number;
            bool isValid = int.TryParse(input, out number);

            if (!isValid)
            {
                Console.WriteLine("Input harus berupa angka!");
                return;
            }

            switch (number)
            {
                case 1:
                    Console.WriteLine("Anda memilih kategori: Satu");
                    break;
                case 2:
                    Console.WriteLine("Anda memilih kategori: Dua");
                    break;
                case 3:
                    Console.WriteLine("Anda memilih kategori: Tiga");
                    break;
                case 4:
                    Console.WriteLine("Anda memilih kategori: Empat");
                    break;
                case 5:
                    Console.WriteLine("Anda memilih kategori: Lima");
                    break;
                default:
                    Console.WriteLine("Angka tidak valid. Harap masukkan angka 1-5.");
                    break;
            }
        }
    }
}
```

**💡 Code Explanation:**

1. **`switch(number)`**: The expression being evaluated.
2. **`case X:`**: Code block executed when `number == X`.
3. **`break;`**: Mandatory in C#. C# prevents implicit fall-through between non-empty cases for safety.
4. **`default:`**: Catch-all branch executed when no case matches.

---

## ⚠️ Common Pitfalls & Tips

1. **C# Disallows Implicit Fall-Through:**
   Unlike C and C++, C# compiler throws an error (`CS0163: Control cannot fall through from one case label to another`) if you forget a `break;` or `return;` inside a non-empty `case`.
2. **`int.TryParse` Inline Out Variables:**
   In modern C#, you can declare the variable inline inside the method call:
   ```csharp
   if (int.TryParse(input, out int age)) {
       // 'age' is now available in this scope!
   }
   ```
3. **String Splitting with Empty Entries:**
   Using `input.Split(' ', StringSplitOptions.RemoveEmptyEntries)` prevents extra whitespace from creating unwanted blank tokens.

---

## 🧪 Hands-On Practice Challenges

- 🟢 **Challenge 1 (Safe Even or Odd Checker)**:
  Prompt the user for a number. Use `int.TryParse` to validate it. If valid, check whether it is even or odd; if invalid, show an informative error message.
- 🟡 **Challenge 2 (Traffic Light State Machine)**:
  Prompt the user to enter a color ("Red", "Yellow", "Green"). Using a `switch` statement (handle case-insensitivity with `.ToUpper()`), display the corresponding driving action ("Stop", "Prepare to Stop", "Go").
- 🔴 **Challenge 3 (Grade Point Average Calculator)**:
  Prompt the user for their letter grade ("A", "B", "C", "D", "F"). Use a `switch` expression or statement to assign GPA points (4.0, 3.0, 2.0, 1.0, 0.0) and display academic status.
