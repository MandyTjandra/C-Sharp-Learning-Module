# 🧠 C# Language Learning Module

> A structured, hands-on C# (.NET) curriculum spanning foundational syntax, control flow, array and string processing, modular functions, recursion, and memory management with structs and references. Designed for **self-paced learners** and **educators**.

[![Language: C#](https://img.shields.io/badge/Language-C%23%2011%2B%20%2F%20.NET-512BD4.svg?logo=csharp)](https://learn.microsoft.com/en-us/dotnet/csharp/)
[![Platform](https://img.shields.io/badge/Platform-Cross--Platform%20(Windows%20%7C%20macOS%20%7C%20Linux)-blue.svg)](https://dotnet.microsoft.com/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)
[![Curriculum Level](https://img.shields.io/badge/Level-Beginner%20to%20Intermediate-green.svg)](#-curriculum-roadmap)

---

## 📖 About This Project

This repository serves as a modular study guide for learning the **C# programming language**. It progresses systematically from entry-level console I/O to multidimensional arrays, LINQ aggregates, modular static methods, recursive Fibonacci sequences, and memory references.

- 🎓 **For Learners**: Standalone `.cs` programs illustrating clean C# conventions (such as `int.TryParse`, object initializers, `required` properties, string interpolation `$"{var}"`, and `ref` returns).
- 👨‍🏫 **For Educators & Mentors**: A 5-chapter modular syllabus suitable for computer science curricula, lab practica, and coding bootcamps.
- 🌐 **Bilingual Context**: Clear English documentation alongside Indonesian (`🇮🇩`) comments, real-world examples (e.g. `Mahasiswa` academic records, student validation), and practical exercises.

---

## 🛠️ Quickstart & Execution Guide

### Prerequisites
Make sure you have the **.NET SDK (version 7.0 or higher)** installed:

```bash
# Verify .NET SDK installation
dotnet --version
```

### Clone the Repository
```bash
git clone https://github.com/MandyTjandra/C-Sharp-Learning-Module.git
cd C-Sharp-Learning-Module
```

### Running C# Programs
You can run any `.cs` script using the `dotnet-script` tool, the C# compiler (`csc`), or inside a small .NET console project:

```bash
# Option A: Using the Roslyn C# Compiler (Windows):
csc "Modules/Module 1 (Input & Output)/Input_and_Output.cs"
.\Input_and_Output.exe

# Option B: Using a standard .NET project:
# 1. Create a console app:
dotnet new console -o StudyApp
# 2. Copy the desired .cs code into StudyApp/Program.cs
# 3. Run:
cd StudyApp && dotnet run
```

---

## 🗺️ Curriculum Roadmap

| Module | Core Topics | Key Learning Competencies | Level | Link |
| :---: | :--- | :--- | :---: | :---: |
| **01** | **Input & Output** | `Console.WriteLine`, `ReadLine`, casting, `const`, comments | Master basic console I/O, type declarations, explicit casting, and string concatenation. | Beginner | [Module 1](./Modules/Module%201%20(Input%20%26%20Output)) |
| **02** | **Conditionals** | `if-else if-else`, ASCII comparisons, `switch-case`, `int.TryParse` | Manage branching decisions, safe numeric parsing, and discrete case dispatching. | Beginner | [Module 2](./Modules/Module%202%20(Conditionals)) |
| **03** | **Loops, Arrays & Strings** | `for`, `while`, `do-while`, `foreach`, 1D/2D arrays, `Array.Sort`, LINQ, strings | Automate repetitive tasks, traverse multidimensional grids, sort sequences, and process text. | Beginner-Intermediate | [Module 3](./Modules/Module%203%20(Looping%2C%20Array%2C%20dan%20String)) |
| **04** | **Functions & Recursion** | Static methods, cross-class calls, prototypes, recursive Fibonacci | Modularize business logic, pass parameters, return values, and implement recursive base cases. | Intermediate | [Module 4](./Modules/Module%204%20(Function%20%26%20Recursive)) |
| **05** | **Pointers & Structs** | Value types vs reference types, `struct`, array of structs, `ref` pointers | Direct memory references using `ref`, examine object byte sizes, and model composite data records. | Intermediate | [Module 5](./Modules/Module%205%20(Pointer%20%26%20Struct)) |

---

## 📂 Detailed File-by-File Course Catalog

### 📘 [Module 1: Input & Output](./Modules/Module%201%20(Input%20%26%20Output))
*Focus: Console streaming, basic types, type casting, and string interpolation.*

| File | Core Concepts & Specific Implementation |
| :--- | :--- |
| **[`Input_and_Output.cs`](./Modules/Module%201%20(Input%20%26%20Output)/Input_and_Output.cs)** | Complete introductory program: `Console.WriteLine()` vs `Console.Write()`, reading input with `Console.ReadLine()`, string concatenation (`firstname + lastname`), `const double pi = 3.14`, explicit type casting `(int)mydouble` (truncating decimals), and single/multiline comments. |

---

### 📙 [Module 2: Conditionals & Decision Making](./Modules/Module%202%20(Conditionals))
*Focus: Branching logic, safe parsing with `int.TryParse`, and discrete switch matching.*

| File | Core Concepts & Specific Implementation |
| :--- | :--- |
| **[`If/If.cs`](./Modules/Module%202%20(Conditionals)/If/If.cs)** | Parses multi-word input (`"John Doe 25"`) using `input.Split(' ')`. Safely validates age with `int.TryParse(parts[2], out umur)`. Extracts the first letter of the second word, casts it to its numerical ASCII value (`(int)firstLetterOfSecondWord`), and compares the ASCII code against the age. |
| **[`Switch/Switch.cs`](./Modules/Module%202%20(Conditionals)/Switch/Switch.cs)** | Reads an input string, validates it via `int.TryParse(input, out number)`, and dispatches discrete numbers (1 to 5) to descriptive category labels (`"Satu"` through `"Lima"`), with an error fallback `default:` message. |

---

### 📗 [Module 3: Looping, Arrays, and Strings](./Modules/Module%203%20(Looping%2C%20Array%2C%20dan%20String))
*Focus: Iteration control, collections, multidimensional arrays, LINQ aggregates, and string methods.*

| File | Core Concepts & Specific Implementation |
| :--- | :--- |
| **[`Array/Array.cs`](./Modules/Module%203%20(Looping%2C%20Array%2C%20dan%20String)/Array/Array.cs)** | Initializing an integer array `int[] x = {12, 14, 16, 18, 20}`, indexing elements (`x[2]`, `x[4]`), and computing index sums (`x[0] + x[4]`). |
| **[`Do While/Do While.cs`](./Modules/Module%203%20(Looping%2C%20Array%2C%20dan%20String)/Do%20While/Do%20While.cs)** | Post-test loop: executes `Console.WriteLine($"Iterasi k-{i}")` and increments `i++` while `i <= 3` (guaranteed at least one execution). |
| **[`For/For.cs`](./Modules/Module%203%20(Looping%2C%20Array%2C%20dan%20String)/For/For.cs)** | Dynamically prompts the user for array length `int.Parse(Console.ReadLine())`, allocates string array `new string[x]`, populates elements in a loop, and displays each element. |
| **[`For Each/For Each.cs`](./Modules/Module%203%20(Looping%2C%20Array%2C%20dan%20String)/For%20Each/For%20Each.cs)** | Sequential traversal of a string array `fruits` (`"Apple"`, `"Banana"`, `"Cherry"`, etc.) using `foreach (string fruit in fruits)`. |
| **[`Multidimensional Array/Multidimensional Array.cs`](./Modules/Module%203%20(Looping%2C%20Array%2C%20dan%20String)/Multidimensional%20Array/Multidimensional%20Array.cs)** | Declaring a 2D rectangular integer matrix `int[,] numbers = { {10, 20, 30}, {40, 50, 60} }` and accessing coordinate elements (`numbers[0, 2]`, `numbers[1, 1]`). |
| **[`Nested For/Nested For.cs`](./Modules/Module%203%20(Looping%2C%20Array%2C%20dan%20String)/Nested%20For/Nested%20For.cs)** | Demonstrates nested iteration with an outer loop ($i = 1 \dots 2$) and inner loop ($j = 1 \dots 3$), executing $2 \times 3 = 6$ total cycles. |
| **[`Sort Array/Sort Array.cs`](./Modules/Module%203%20(Looping%2C%20Array%2C%20dan%20String)/Sort%20Array/Sort%20Array.cs)** | Alphabetical sorting with `Array.Sort(cars)`, reverse ordering with `Array.Reverse(cars)`, and numeric array aggregation using System.Linq (`myNumbers.Max()`, `.Min()`, `.Sum()`). |
| **[`String/String.cs`](./Modules/Module%203%20(Looping%2C%20Array%2C%20dan%20String)/String/String.cs)** | 10 distinct string demonstrations: concatenation, interpolation (`$"{}"`), verbatim string literals for Windows paths (`@"C:\Users\..."`), `.ToUpper()`, `.Substring()`, quote escaping (`\"`), `.Length`, `.ToLower()`, character indexing (`greeting[0]`), and `.IndexOf('C')`. |
| **[`While/While.cs`](./Modules/Module%203%20(Looping%2C%20Array%2C%20dan%20String)/While/While.cs)** | Pre-test iteration: `while (i < 3)` evaluating conditions before each cycle and incrementing counter `i++`. |

---

### 📕 [Module 4: Functions & Recursion](./Modules/Module%204%20(Function%20%26%20Recursive))
*Focus: Static methods, inter-class invocation, and recursive sequence generation.*

| File | Core Concepts & Specific Implementation |
| :--- | :--- |
| **[`Function/Function.cs`](./Modules/Module%204%20(Function%20%26%20Recursive)/Function/Function.cs)** | Encapsulating reusable arithmetic in a dedicated class `Calc.Add(a, b)`, prompting user inputs, parsing integers via `int.Parse()`, and returning results. |
| **[`Prototype Fungsi/Prototype_Fungsi.cs`](./Modules/Module%204%20(Function%20%26%20Recursive)/Prototype%20Fungsi/Prototype_Fungsi.cs)** | Demonstrates static method placement and direct invocation from the `Main` entry point. |
| **[`Recursive/Recursive.cs`](./Modules/Module%204%20(Function%20%26%20Recursive)/Recursive/Recursive.cs)** | Mathematical recursion: computing the Fibonacci sequence with dual base cases (`if (n == 0) return 0; if (n == 1) return 1;`) and recursive case (`Fibonacci(n-1) + Fibonacci(n-2)`), displaying the running sequence, total sum, and target term. |

---

### 🟪 [Module 5: Pointers, Structs, and Memory References](./Modules/Module%205%20(Pointer%20%26%20Struct))
*Focus: Value types vs reference types, C# 11 required properties, and managed pointer simulation.*

| File | Core Concepts & Specific Implementation |
| :--- | :--- |
| **[`Struct/Struct.cs`](./Modules/Module%205%20(Pointer%20%26%20Struct)/Struct/Struct.cs)** | Object-oriented model `Mahasiswa`: uses C# 11+ `public required` properties (`Nama`, `NRP`, `Umur`, `IPK`, `Semester`, `Status`), object initializers (`new Mahasiswa { ... }`), decimal formatting (`{IPK:F2}`), and ternary status display. |
| **[`Array of Struct/ArrayOfStruct.cs`](./Modules/Module%205%20(Pointer%20%26%20Struct)/Array%20of%20Struct/ArrayOfStruct.cs)** | Allocating and initializing an array of lightweight value-type structs `Point[] arr = new Point[3]` with `{ X, Y }` properties. |
| **[`Pointer/Pointer.cs`](./Modules/Module%205%20(Pointer%20%26%20Struct)/Pointer/Pointer.cs)** | Simulating low-level pointers in safe managed C#: using `ref int ptr = ref a;`, mutating variable `a` through the reference `ptr = 20`, inspecting hash codes, and measuring memory sizes using `sizeof(int)` (4 bytes) and `IntPtr.Size` (8 bytes on 64-bit architecture). |

---

## 👨‍🏫 Pedagogical Study Method: The 4-Step Cycle

```
 ┌──────────────┐     ┌──────────────┐     ┌──────────────┐     ┌──────────────┐
 │  1. EXAMINE  │ ──> │    2. RUN    │ ──> │3. EXPERIMENT │ ──> │   4. APPLY   │
 │ Read concept │     │ Execute file │     │ Tweak types  │     │ Complete the │
 │  & comments  │     │ in terminal  │     │ & test edge  │     │  challenges  │
 └──────────────┘     └──────────────┘     └──────────────┘     └──────────────┘
```

1. **Examine**: Review the module's `README.md` to grasp C# syntax rules and framework mechanisms.
2. **Run**: Execute the code file to observe console output and input prompts.
3. **Experiment**: Alter inputs, test invalid numbers with `int.TryParse`, or modify array boundaries to observe framework exceptions.
4. **Apply**: Implement the practice exercises found at the bottom of each module guide.

---

## 🤝 Contributing

Contributions are welcomed! Feel free to:
- Add extra challenge problems or code solutions.
- Add additional modules (e.g. LINQ queries, Async/Await, File I/O, Generics).
- Improve code comments and explanations.

Open a Pull Request or create an Issue to contribute.

---

## 📜 License

This project is licensed under the [MIT License](LICENSE) © 2026 Mandy Tjandra. Free for personal and educational use. Happy coding! 💻✨
