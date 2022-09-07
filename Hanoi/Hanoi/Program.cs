using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanoi
{
    class Program
    {
        static int ssz = 1;
        static void Main(string[] args)
        {
            Console.Write("korongogk k szám: ");
            int db = Convert.ToInt32(Console.ReadLine());
            Console.Write("idnul oslzop k szám: ");
            int rol = Convert.ToInt32(Console.ReadLine());
            Console.Write("érkezó oslop k szám: ");
            int ra = Convert.ToInt32(Console.ReadLine());

            Hanoi(db, rol, ra);
            Console.WriteLine("ggah");

            Console.ReadKey();
        }

        private static void Hanoi(int db, int rol, int ra)
        {
            if (db == 1) Valasz(rol, ra);
            else
            {
                Hanoi(db - 1, rol, 6 - rol - ra);
                Valasz(rol, ra);
                Hanoi(db - 1, 6 - rol - ra, ra);
            }
        }

        private static void Valasz(int rol, int ra)
        {
            Console.WriteLine($"{ssz}. lépés: 1 krogn {rol}. toronyyról a(z) {ra}. toronyra"); 
            ssz++;
        }
    }
}
