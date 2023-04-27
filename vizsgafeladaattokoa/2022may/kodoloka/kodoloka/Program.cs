using System;
using System.Collections.Generic;
using System.Linq;

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
            Karakter character = SearchChar(UserInput());

            Console.WriteLine("7. feladat: ");

            if (character == null) 
                Console.WriteLine("Nincs ilyen karakter a bankban!");
            else
                character.Display();
        }

        private static Karakter SearchChar(string letter)
        {
            foreach (Karakter item in characters)
            {
                if (item.Character == letter)
                {
                    return item;
                }
            }

            return null;
        }

        private static string UserInput()
        {
            bool correctLetter = false;

            while (!correctLetter)
            {
                Console.Write("6. feladat: Kérek egy angol nagybetűt: ");

                string input = Console.ReadLine();

                if (input.Length == 1 && input.ToLower() != input)
                {
                    return input;
                }
            }

            return "";
        }

        private static void _5feladat()
        {
            Console.WriteLine($"5. feladat: Karakterek száma: {characters.Count}");
        }
    }
}
