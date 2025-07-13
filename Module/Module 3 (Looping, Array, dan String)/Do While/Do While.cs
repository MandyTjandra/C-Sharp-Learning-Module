using System;

namespace Do_While{

    class Program{

        static void Main(string[] args){

            int i = 0;

            do{
                Console.WriteLine($"Iterasi k-{i}");
                i++;

            } 
            while(i <= 3);
        }
    }
}