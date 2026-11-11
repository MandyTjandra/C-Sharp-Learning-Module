# Module 5: Structures and Memory Management in C#

This module covers custom data models using **Classes** and **Structs**, as well as safe memory referencing in C# using the **`ref`** keyword and memory size inspection.

---

## 🎯 Learning Objectives

By the end of this module, students and learners will be able to:
- Distinguish between **Value Types** (`struct`, stack-allocated) and **Reference Types** (`class`, heap-allocated).
- Declare modern C# models with C# 11+ `public required` properties.
- Instantiate objects cleanly using **Object Initializer** syntax.
- Allocate and manipulate arrays of custom structs (`Point[]`).
- Emulate pointers safely using managed references (`ref int ptr = ref a;`).
- Inspect type memory sizes using `sizeof(int)` and `IntPtr.Size`.

---

## 📁 Subfolder Overview

* [`Struct/`](./Struct) — Real-world Indonesian university student model (`Mahasiswa`) with required properties, GPA formatting, and status flags (`Struct.cs`).
* [`Array of Struct/`](./Array%20of%20Struct) — Lightweight coordinate points stored in arrays (`ArrayOfStruct.cs`).
* [`Pointer/`](./Pointer) — Managed pointer simulation using `ref`, memory mutation, and size measurements (`Pointer.cs`).

---

## 1. Classes vs Structs

### A. The `Mahasiswa` Model (`Struct/Struct.cs`)
In C#, complex entities with behavior are defined using `class`:

```csharp
using System;

class Mahasiswa
{
    // 'required' guarantees properties must be populated during initialization
    public required string Nama { get; set; } 
    public required string NRP { get; set; }
    public required int Umur { get; set; }
    public required double IPK { get; set; }
    public required int Semester { get; set; }
    public required bool Status { get; set; }

    public void TampilkanData()
    {
        Console.WriteLine($"Nama\t: {Nama}");
        Console.WriteLine($"NRP\t: {NRP}");
        Console.WriteLine($"Umur\t: {Umur}");
        Console.WriteLine($"IPK\t: {IPK:F2}");
        Console.WriteLine($"Sem\t: {Semester}");
        Console.WriteLine($"Status\t: {(Status ? "Aktif" : "Tidak Aktif")}");
    }
}
```

#### Object Initializer Syntax:
```csharp
Mahasiswa mhs1 = new Mahasiswa
{
    Nama = "Ahmad",
    NRP = "05111940000012",
    Umur = 18,
    IPK = 3.94,
    Semester = 3,
    Status = true
};

mhs1.TampilkanData();
```

---

### B. Array of Structs (`Array of Struct/ArrayOfStruct.cs`)
For lightweight data containers (like geometric coordinates) where heap allocation is unnecessary, `struct` is optimal:

```csharp
struct Point
{
    public int X { get; set; }
    public int Y { get; set; }
}

Point[] arr = new Point[3];
arr[0] = new Point { X = 2, Y = 3 };
arr[1] = new Point { X = 5, Y = 3 };
arr[2] = new Point { X = 2, Y = 8 };

Console.WriteLine($"Point 0: ({arr[0].X}, {arr[0].Y})");
```

---

## 2. Safe Pointer Simulation with `ref` (`Pointer/Pointer.cs`)

C# is a memory-managed language protected by the CLR Garbage Collector. Raw pointers (`*`) require an `unsafe` compilation flag. Instead, C# provides safe, managed pointers through the **`ref`** keyword:

```csharp
using System;

class Program
{
    static void Main()
    {
        int a = 10;
        ref int ptr = ref a; // 'ptr' directly references the storage location of 'a'

        Console.WriteLine($"Initial a: {a}"); // 10

        // Mutating 'ptr' changes 'a' directly in memory:
        ptr = 20;
        Console.WriteLine($"Updated a: {a}"); // 20

        // Memory size inspection:
        Console.WriteLine($"Size of int: {sizeof(int)} bytes");       // 4 bytes
        Console.WriteLine($"Size of pointer: {IntPtr.Size} bytes");    // 8 bytes on 64-bit systems
    }
}
```

---

## 📊 Summary: Stack vs Heap & Struct vs Class

| Feature | `struct` | `class` |
| :--- | :--- | :--- |
| **Category** | Value Type | Reference Type |
| **Memory Location** | Stack (or inlined in container) | Managed Heap |
| **Assignment Behavior** | Copies all fields by value | Copies the reference/pointer |
| **Garbage Collector Overhead** | None (instant deallocation) | Managed by GC |
| **Best Used For** | Small immutable records (Point, Color, Vector) | Complex entities with business logic |

---

## ⚠️ Common Pitfalls & Tips

1. **`struct` Mutation Trap:**
   Assigning `Point p2 = p1;` creates an independent copy. Mutating `p2.X` will **not** affect `p1.X`.
2. **`ref` vs `out` Parameter Passing:**
   * **`ref`**: Variable must be initialized before passing to the method.
   * **`out`**: Variable does not need to be initialized beforehand, but the method *must* assign a value before returning.
3. **C# 11 `required` Properties:**
   Attempting `new Mahasiswa { Nama = "Ahmad" }` without providing all required properties results in a compile-time error, preventing runtime `NullReferenceException` bugs.

---

## 🧪 Hands-On Practice Challenges

- 🟢 **Challenge 1 (In-Place Swap with `ref`)**:
  Write a method `static void Swap(ref int x, ref int y)` that swaps the values of two integers.
- 🟡 **Challenge 2 (Roster Honor Roll Filter)**:
  Create an array of 5 `Mahasiswa` objects. Write a method that loops through the array and prints only students whose `IPK >= 3.50` and `Status == true`.
- 🔴 **Challenge 3 (Geometric Distance with Struct)**:
  Add a method to `struct Point` called `public double DistanceTo(Point other)` that computes the Euclidean distance $\sqrt{(X_2 - X_1)^2 + (Y_2 - Y_1)^2}$ between two coordinate points.
