using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"fibó szám: {Fibo(Beker())}");
            Console.WriteLine($"fibó szám: {Fibo_cik(Beker())}");

            Console.ReadKey();
        }

        private static object Fibo_cik(int n)
        {
            int fib1 = 0;
            int fib2 = 1;

            if (n == 1) return fib1;
            if (n == 2) return fib2;

            int keres = 0;
            for (int i = 3; i <= n; i++)
            {
                keres = fib1 + fib2;
                fib1 = fib2;
                fib2 = keres;
            }
            return keres;
        }

        private static int Fibo(int n)
        {
            if (n == 1) return 0;
            if (n == 2) return 1;
            return Fibo(n - 1) + Fibo(n - 2);
            
        }

        private static int Beker()
        {
            Console.Write("Adjkd memgm lésázM: ");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
