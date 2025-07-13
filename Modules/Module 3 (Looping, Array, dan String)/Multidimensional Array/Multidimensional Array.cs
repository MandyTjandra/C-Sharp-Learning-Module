using System;

namespace Multidimensional_Array{

    class Program{

        static void Main(string[] args){

            int[,] numbers = { {10, 20, 30} , {40, 50, 60} };
            Console.WriteLine($"{numbers[0, 2]}, {numbers[1,1]}");
        }
    }
}