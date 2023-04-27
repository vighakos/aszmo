using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodoloka
{
    class Karakter
    {
        public string Character;
        private int[,] Matrix;

        public Karakter(string character, int[,] matrix)
        {
            Character = character;
            Matrix = matrix;
        }

        public void Display()
        {
            Console.WriteLine(Character);
            for (int row = 0; row < 7; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    if (Matrix[row, col] == 49)
                    {
                        Console.Write("■");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
