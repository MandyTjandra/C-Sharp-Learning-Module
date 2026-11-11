# 📚 C# Course Modules & File Syllabus Index

Welcome to the **Modules Directory** for the C# (.NET) curriculum. This repository features **5 core learning chapters** containing **18 standalone C# files**, structured to take students from initial syntax to advanced memory referencing.

---

## 🧭 Curriculum Progression Track

```text
  ┌───────────────────────────┐       ┌───────────────────────────┐
  │ Module 1: Input & Output  │ ────> │ Module 2: Conditionals    │
  │ Console, Types & Casting  │       │ If-Else & Switch Dispatch │
  └───────────────────────────┘       └───────────────────────────┘
                                                    │
  ┌───────────────────────────┐                     ▼
  │ Module 5: Struct & Memory │ <──── ┌───────────────────────────┐
  │ Mahasiswa, Points & ref   │       │ Module 3: Loops & Arrays  │
  └───────────────────────────┘       │ 1D/2D, LINQ & String Ops  │
               ▲                      └───────────────────────────┘
               │                                    │
               └────── ┌───────────────────────────┐┘
                       │ Module 4: Functions & Rec │
                       │ Calc.Add & Fibonacci Tree │
                       └───────────────────────────┘
```

---

## 📋 Comprehensive Chapter Guide

### [Module 1: Input & Output](./Module%201%20(Input%20%26%20Output))
* **Level**: Beginner | **Est. Time**: 1 Hour
* **Key File**: [`Input_and_Output.cs`](./Module%201%20(Input%20%26%20Output)/Input_and_Output.cs)
* **Core Competency**: Master `Console.WriteLine()` and `Console.Write()`, capture user input with `Console.ReadLine()`, declare constants (`const`), and perform explicit type casting (`(int)mydouble`).

---

### [Module 2: Conditionals & Decision Making](./Module%202%20(Conditionals))
* **Level**: Beginner | **Est. Time**: 1 - 1.5 Hours
* **Key Subfolders**:
  * [`If/`](./Module%202%20(Conditionals)/If) — [`If.cs`](./Module%202%20(Conditionals)/If/If.cs) demonstrates multi-token string splitting (`input.Split(' ')`), safe age conversion via `int.TryParse(parts[2], out umur)`, and comparing character ASCII codes against age numbers.
  * [`Switch/`](./Module%202%20(Conditionals)/Switch) — [`Switch.cs`](./Module%202%20(Conditionals)/Switch/Switch.cs) demonstrates discrete numeric dispatching with `switch`, `case`, `break`, and `default`.
* **Core Competency**: Write defensive input checks, parse multi-part string arguments, and execute branch statements.

---

### [Module 3: Looping, Arrays, and Strings](./Module%203%20(Looping%2C%20Array%2C%20dan%20String))
* **Level**: Beginner - Intermediate | **Est. Time**: 2 - 3 Hours
* **Key Subfolders**:
  * **Looping**:
    * [`For/For.cs`](./Module%203%20(Looping%2C%20Array%2C%20dan%20String)/For/For.cs) — Dynamic user-sized array allocation and iteration.
    * [`While/While.cs`](./Module%203%20(Looping%2C%20Array%2C%20dan%20String)/While/While.cs) — Condition-controlled pre-test looping.
    * [`Do While/Do While.cs`](./Module%203%20(Looping%2C%20Array%2C%20dan%20String)/Do%20While/Do%20While.cs) — Post-test iteration loop.
    * [`For Each/For Each.cs`](./Module%203%20(Looping%2C%20Array%2C%20dan%20String)/For%20Each/For%20Each.cs) — Clean collection traversal over strings.
    * [`Nested For/Nested For.cs`](./Module%203%20(Looping%2C%20Array%2C%20dan%20String)/Nested%20For/Nested%20For.cs) — Multi-tier coordinate iterations.
  * **Arrays**:
    * [`Array/Array.cs`](./Module%203%20(Looping%2C%20Array%2C%20dan%20String)/Array/Array.cs) — Basic 1D array indexing and element summation.
    * [`Multidimensional Array/Multidimensional Array.cs`](./Module%203%20(Looping%2C%20Array%2C%20dan%20String)/Multidimensional%20Array/Multidimensional%20Array.cs) — Rectangular 2D matrices (`int[,] numbers`).
    * [`Sort Array/Sort Array.cs`](./Module%203%20(Looping%2C%20Array%2C%20dan%20String)/Sort%20Array/Sort%20Array.cs) — `Array.Sort()`, `Array.Reverse()`, and LINQ helpers (`.Max()`, `.Min()`, `.Sum()`).
  * **Strings**:
    * [`String/String.cs`](./Module%203%20(Looping%2C%20Array%2C%20dan%20String)/String/String.cs) — 10 practical string operations: verbatim strings (`@""`), `.ToUpper()`, `.Substring()`, `.IndexOf()`, and escaping.
* **Core Competency**: Iterate over multi-tier collections, manipulate multidimensional grids, sort data, and sanitize text.

---

### [Module 4: Functions & Recursion](./Module%204%20(Function%20%26%20Recursive))
* **Level**: Intermediate | **Est. Time**: 1.5 - 2 Hours
* **Key Subfolders**:
  * [`Function/Function.cs`](./Module%204%20(Function%20%26%20Recursive)/Function/Function.cs) — Static method declaration inside a helper class (`Calc.Add(a, b)`).
  * [`Prototype Fungsi/Prototype_Fungsi.cs`](./Module%204%20(Function%20%26%20Recursive)/Prototype%20Fungsi/Prototype_Fungsi.cs) — Modular static method definition.
  * [`Recursive/Recursive.cs`](./Module%204%20(Function%20%26%20Recursive)/Recursive/Recursive.cs) — Recursive Fibonacci implementation with base cases (`n == 0`, `n == 1`), printing running totals.
* **Core Competency**: Modularize applications into static utility classes, parse inputs, and implement safe recursive algorithms.

---

### [Module 5: Pointers, Structs, and Memory References](./Module%205%20(Pointer%20%26%20Struct))
* **Level**: Intermediate | **Est. Time**: 2 Hours
* **Key Subfolders**:
  * [`Struct/Struct.cs`](./Module%205%20(Pointer%20%26%20Struct)/Struct/Struct.cs) — Modeling real-world student records (`Mahasiswa`) using C# 11 `required` properties and object initializers.
  * [`Array of Struct/ArrayOfStruct.cs`](./Module%205%20(Pointer%20%26%20Struct)/Array%20of%20Struct/ArrayOfStruct.cs) — Storing arrays of lightweight coordinate structs (`Point[] arr`).
  * [`Pointer/Pointer.cs`](./Module%205%20(Pointer%20%26%20Struct)/Pointer/Pointer.cs) — Safe pointer emulation using `ref int ptr = ref a;`, mutating target variables through references, and inspecting memory size (`sizeof(int)`, `IntPtr.Size`).
* **Core Competency**: Differentiate between Stack-allocated value types and Heap-allocated reference types, and manage memory references safely.

---

## 👩‍🏫 5-Week Lesson Plan Blueprint (For Teachers)

| Week | Topic Focus | Demonstration Scripts | Hands-on Lab Assignment |
| :---: | :--- | :--- | :--- |
| **Week 1** | C# Syntax & Console I/O | `Input_and_Output.cs` | Build an interactive user registration prompt with age casting. |
| **Week 2** | Defensive Logic & Decisions | `If.cs`, `Switch.cs` | Parse a full student command line input and categorize grades. |
| **Week 3** | Loops, Matrices & Strings | `For Each.cs`, `Multidimensional Array.cs`, `Sort Array.cs`, `String.cs` | Implement a matrix rotation utility and text analysis tool. |
| **Week 4** | Modular Methods & Recursion | `Function.cs`, `Recursive.cs` | Build an integer power and factorial calculator with class methods. |
| **Week 5** | OOP Models & Memory References | `Struct.cs`, `ArrayOfStruct.cs`, `Pointer.cs` | Model a university student roster with GPA calculations. |
