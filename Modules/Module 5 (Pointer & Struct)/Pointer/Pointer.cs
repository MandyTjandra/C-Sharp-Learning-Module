using System;

class Program
{
    static void Main()
    {
        int a = 10; // Declare an integer variable
        ref int ptr = ref a; // Use a reference to simulate pointer behavior

        // Display the value of variable a
        Console.WriteLine($"Nilai dari a: {a}");

        // Display an approximation of the address (use GetHashCode as a reference substitute)
        Console.WriteLine($"Simulated 'address' of a: {a.GetHashCode()}");

        // Display the size of the value and reference
        Console.WriteLine($"Ukuran dari nilai a adalah {sizeof(int)} byte");
        Console.WriteLine($"Ukuran dari reference adalah {IntPtr.Size} byte");

        // Access the value of a using the reference
        Console.WriteLine($"Nilai yang ditunjuk oleh ptr: {ptr}");

        // Modify the value of a through the reference
        ptr = 20;
        Console.WriteLine($"Nilai a setelah diubah melalui reference: {a}");
    }
}
