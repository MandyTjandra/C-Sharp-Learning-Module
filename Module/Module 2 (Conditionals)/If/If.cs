using System;

namespace If
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukan nama dan umur (contoh: John Doe 25): ");
            string input = Console.ReadLine();
            
            // Split the input into parts
            string[] parts = input.Split(' ');
            if (parts.Length < 3)
            {
                Console.WriteLine("Input tidak valid. Masukkan dalam format: Nama Depan Nama Belakang Umur.");
                return;
            }

            string secondWord = parts[1];
            int umur;
            bool isValidAge = int.TryParse(parts[2], out umur);

            if (!isValidAge)
            {
                Console.WriteLine("Umur harus berupa angka!");
                return;
            }

            char firstLetterOfSecondWord = secondWord[0];
            int asciiValue = (int)firstLetterOfSecondWord;

            if (asciiValue > umur)
            {
                Console.WriteLine($"Huruf pertama dari kata kedua ('{firstLetterOfSecondWord}') lebih besar dari angka umur ({umur}), Anda eligible!");
            }
            else if (asciiValue < umur)
            {
                Console.WriteLine($"Huruf pertama dari kata kedua ('{firstLetterOfSecondWord}') lebih kecil dari angka umur ({umur}), Anda tidak eligible.");
            }
            else
            {
                Console.WriteLine("Huruf pertama dari kata kedua sama dengan angka umur, Error.");
            }
        }
    }
}
