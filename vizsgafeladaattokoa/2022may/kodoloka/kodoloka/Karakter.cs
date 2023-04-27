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

        public bool Felismer(Karakter felismerendo)
        {
            for (int row = 0; row < 7; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    if (Matrix[row, col] != felismerendo.Matrix[row, col])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
