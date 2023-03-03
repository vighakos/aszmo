using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rekurzion_fakt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"A megadott szám fakrotiálisa: {Faktori(Bekeres())}");
            Console.WriteLine($"A megadott szám fakrotiálisa: {Faktori_cik(Bekeres())}");

            Console.ReadKey();
        }

        private static long Faktori_cik(long n)
        {
            long fakt = 1;
            for (int i = 0; i <= n; i++) fakt *= i;
            return fakt;
        }

        private static long Faktori(long n)
        {
            if (n == 1) return 1;
            return n * Faktori(n - 1);
        }

        private static long Bekeres()
        {
            Console.Write("SAÁzm: ");
            return Convert.ToInt64(Console.ReadLine());
        }
    }
}
