using System;
using System.Collections.Generic;

namespace kodoloka
{
    class Program
    {
        static List<Karakter> characters = FileReader.ReadFile();
        static void Main(string[] args)
        {
            _5feladat();
            _6feladat();


            Console.ReadKey();
        }

        private static void _6feladat()
        {
            
        }

        private static void _5feladat()
        {
            Console.WriteLine($"5. feladat: Karakterek száma: {characters.Count}");
        }
    }
}
