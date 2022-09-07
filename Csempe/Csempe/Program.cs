using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csempe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Mekkrore teüe: {Terul(Beker())}");


            Console.ReadKey();
        }

        private static int Terul(int n)
        {
            if (n == 0 || n == 1) return 1;
            return Terul(n - 1) + Terul(n - 2);
        }

        private static int Beker()
        {
            Console.Write("dfg: ");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
