# Module 5: Structures and Memory Management in C#

This module covers **Data Structures** and **Memory References**. Unlike C, C# hides most pointer logic for safety, but understanding "References" is crucial.

---

## 1. Structures (Structs vs Classes)

### A. Defining a Struct (`Struct.cs`)
In C#, a `struct` is a **Value Type** (stored in Stack memory), whereas a `class` is a **Reference Type** (stored in Heap memory). Structs are best for small objects like coordinates.

```csharp
class Mahasiswa
{
    // 'required' ensures these properties must be set when creating the object
    public required string Nama { get; set; } 
    public required string NRP { get; set; }
    public required double IPK { get; set; }
    public required bool Status { get; set; }

    public void TampilkanData()
    {
        Console.WriteLine($"Nama: {Nama}, IPK: {IPK:F2}");
        Console.WriteLine($"Status: {(Status ? "Aktif" : "Tidak Aktif")}");
    }
}

```

**💡 Code Explanation:**

* **Properties (`{ get; set; }`)**: The modern C# way to create variables (fields) accessible from outside.
* **`required`**: A newer C# feature (C# 11+) preventing objects from being created with null values.
* **String Formatting**: `{IPK:F2}` automatically rounds the decimal number to 2 digits.

### B. Array of Objects (`ArrayOfStruct.cs`)

Just like in C, we can create an array that holds multiple instances of a struct or class.

```csharp
struct Point
{
    public int X { get; set; }
    public int Y { get; set; }
}

// Creating an array of 3 Points
Point[] arr = new Point[3];

// Initializing specific indices
arr[0] = new Point { X = 2, Y = 3 };
arr[1] = new Point { X = 5, Y = 3 };

Console.WriteLine($"{arr[0].X} {arr[0].Y}");

```

**💡 Code Explanation:**

* **`new Point { X=2, Y=3 }`**: Object Initializer syntax. It creates and sets values in one line.

---

## 2. Pointers & References (`Pointer.cs`)

C# is a "Managed Language," meaning the Garbage Collector handles memory. Using actual pointers (`*`) requires the `unsafe` keyword. Instead, we typically use **References**.

### A. Simulating Pointers with `ref`

The `ref` keyword allows you to point to a variable's storage location, similar to a pointer in C.

```csharp
int a = 10;

// 'ref' acts like a safe pointer to 'a'
ref int ptr = ref a; 

Console.WriteLine($"Nilai a: {a}");     // 10
Console.WriteLine($"Nilai ptr: {ptr}"); // 10

// Modifying 'ptr' actually modifies 'a'
ptr = 20; 
Console.WriteLine($"Nilai a baru: {a}"); // 20

```

### B. Memory Inspection

Since we cannot easily print memory addresses like `%p` in C, we look at other details:

* **`sizeof(int)`**: 4 bytes.
* **`IntPtr.Size`**: The size of a memory address (4 bytes on 32-bit, 8 bytes on 64-bit systems).

**💡 Key Takeaway:**
In C#, you rarely use `*ptr`.

* Use **`ref`** if you want to modify a variable passed into a function.
* Use **`out`** if you want a function to return multiple values.
