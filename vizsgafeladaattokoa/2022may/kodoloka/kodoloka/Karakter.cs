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
        public int[,] Matrix;

        public Karakter(string character, int[,] matrix)
        {
            Character = character;
            Matrix = matrix;
        }
    }
}
