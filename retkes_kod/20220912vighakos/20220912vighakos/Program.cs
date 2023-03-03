using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220912vighakos
{
    class Program
    {
        static List<int> lista = new List<int> { 1, 45, 8, 36, 74, 61, 99, 0, 44, 88, 32, 65, 68, 10, 12, 4 };
        static int lepesek = 1;
        static void Main(string[] args)
        {
            ElsoFeladat();
            MasodikFeladat();

            Console.ReadKey();
        }

        private static void MasodikFeladat()
        {
            Console.Write("\nKorongok száma: ");
            int korongok = Convert.ToInt32(Console.ReadLine());

            Console.Write("Melyik oszlopról: ");
            int rol = Convert.ToInt32(Console.ReadLine());

            Console.Write("Melyik oszlopra: ");
            int ra = Convert.ToInt32(Console.ReadLine());

            Hanoi(korongok, rol, ra);
        }

        private static void Hanoi(int korongok, int rol, int ra)
        {
            if (korongok == 0 || rol == ra) return;

            Console.WriteLine($"{lepesek}. lépés: 1 korongot {rol}. oszlopról {6-rol-ra}. oszlopra");

            lepesek++;
            korongok--;
            Hanoi(korongok, rol, 6-rol-ra);
        }

        private static void ElsoFeladat()
        {
            for (int i = 0; i < lista.Count; i++)
            {
                for (int j = i; j < lista.Count; j++)
                {
                    if (lista[j] < lista[i])
                    {
                        int seged = lista[i];
                        lista[i] = lista[j];
                        lista[j] = seged;
                    }
                }
            }

            foreach (int szam in lista)
                Console.Write($"{szam}, ");
        }
    }
}
