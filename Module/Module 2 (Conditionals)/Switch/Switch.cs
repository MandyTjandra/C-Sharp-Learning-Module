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
                    Console.WriteLine("Angka yang dimasukkan tidak valid. Harap masukkan angka antara 1-5.");
                    break;
            }
        }
    }
}
