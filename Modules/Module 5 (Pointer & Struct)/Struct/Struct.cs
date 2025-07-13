using System;

class Mahasiswa
{
    public required string Nama { get; set; } // Using required so it must be filled in
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

class Program
{
    static void Main()
    {
        // Create instances of Mahasiswa with required properties
        Mahasiswa mhs1 = new Mahasiswa
        {
            Nama = "Ahmad",
            NRP = "05111940000012",
            Umur = 18,
            IPK = 3.94,
            Semester = 3,
            Status = true
        };

        Mahasiswa mhs2 = new Mahasiswa
        {
            Nama = "Budi",
            NRP = "05111940000013",
            Umur = 20,
            IPK = 3.50,
            Semester = 5,
            Status = true
        };

        Mahasiswa mhs3 = new Mahasiswa
        {
            Nama = "Siti",
            NRP = "05111940000014",
            Umur = 22,
            IPK = 2.85,
            Semester = 7,
            Status = false
        };

        // Display the students' data
        mhs1.TampilkanData();
        Console.WriteLine();
        mhs2.TampilkanData();
        Console.WriteLine();
        mhs3.TampilkanData();
    }
}
