using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kombinacio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"kléfhoéf: {Alatt(Beker(), Beker())}");

            Console.ReadKey();
        }

        private static int Alatt(int n, int k)
        {
            if (n == k || n == 0 || k == 0) return 1;
            return Alatt(n - 1, k - 1) + Alatt(n - 1, k);
        }

        private static int Beker()
        {
            Console.Write("Sázmn kam: ");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
