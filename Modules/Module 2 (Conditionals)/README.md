# Module 2: Conditional Logic in C#

This module covers how to control the flow of your program based on conditions. You will learn to use `if-else` blocks for complex logic and `switch` statements for selecting between multiple distinct options.

---

## 1. If-Else Statements (`If.cs`)

This program demonstrates a complex condition check. It takes a full name and age, processes the data, and compares the **ASCII value** of a character against a number.

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

            // 2. Extract specific data
            string secondWord = parts[1]; // Gets "Doe"
            int umur;
            
            // 3. Securely convert string to int
            bool isValidAge = int.TryParse(parts[2], out umur);

            // 4. Get ASCII value of the first letter of the Last Name
            char firstLetterOfSecondWord = secondWord[0]; // 'D'
            int asciiValue = (int)firstLetterOfSecondWord; // 68

            // 5. The Condition
            if (asciiValue > umur)
            {
                Console.WriteLine("Eligible!");
            }
            else if (asciiValue < umur)
            {
                Console.WriteLine("Not eligible.");
            }
            else
            {
                Console.WriteLine("Error.");
            }
        }
    }
}

```

### 💡 Code Explanation

1. **`input.Split(' ')`**: This breaks the single input string "John Doe 25" into three separate strings: `["John", "Doe", "25"]`.
2. **`int.TryParse`**: A safe way to convert text to numbers. If the user types "twenty", the program won't crash; `isValidAge` will just be `false`.
3. **`(int)char`**: This casts a character to its ASCII integer value. For example, 'A' is 65, 'B' is 66, etc.
4. **Logic Flow**:
* **If**: The ASCII value is *greater* than the age.
* **Else If**: The ASCII value is *less* than the age.
* **Else**: They are exactly equal.



---

## 2. Switch Case Statements (`Switch.cs`)

When you have a single variable that can be one of many specific values (like a menu selection), `switch` is cleaner than writing many `else if` statements.

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
            
            // Validate input
            if (!int.TryParse(input, out number)) return;

            switch (number)
            {
                case 1:
                    Console.WriteLine("Anda memilih kategori: Satu");
                    break; // Exit the switch
                case 2:
                    Console.WriteLine("Anda memilih kategori: Dua");
                    break;
                case 3:
                    Console.WriteLine("Anda memilih kategori: Tiga");
                    break;
                /* ... cases 4 and 5 ... */
                default:
                    // Runs if the number is NOT 1, 2, 3, 4, or 5
                    Console.WriteLine("Angka yang dimasukkan tidak valid.");
                    break;
            }
        }
    }
}

```

### 💡 Code Explanation

1. **`switch (number)`**: The variable inside the parentheses is the one being tested.
2. **`case 1:`**: If `number == 1`, the code immediately following this line executes.
3. **`break;`**: Crucial keyword. It tells the program to stop executing the switch block. Without it, C# will give a compile error (unlike C/C++ which "falls through").
4. **`default:`**: This acts like the final `else`. It catches any value that didn't match the specific cases above (e.g., if the user enters 99).
