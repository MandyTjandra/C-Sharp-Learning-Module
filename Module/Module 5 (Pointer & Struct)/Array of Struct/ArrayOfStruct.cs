using System;

struct Point
{
    public int X { get; set; }
    public int Y { get; set; }
}

class Program
{
    static void Main()
    {
        // Declare an array of Point structs
        Point[] arr = new Point[3];

        // Initialize the array elements
        arr[0] = new Point { X = 2, Y = 3 };
        arr[1] = new Point { X = 5, Y = 3 };
        arr[2] = new Point { X = 2, Y = 8 };

        // Print the values
        Console.WriteLine($"{arr[0].X} {arr[0].Y}");
        Console.WriteLine($"{arr[1].X} {arr[1].Y}");
        Console.WriteLine($"{arr[2].X} {arr[2].Y}");
    }
}
