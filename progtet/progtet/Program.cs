using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progtet
{
    class Program
    {
        static List<int> elemek = new List<int>() { 23, 45, 67, 32, 21, 24, 576, 45, 986, 12, 1, 54, 765, 43, 59, 120, 516, 89, 142, 32, 321, 654, 97, 156, 971, 111, 222, 555, 666, 999, 0, 74, 61 };
        static void Main(string[] args)
        {
            MaxKivalaszt(); 
            MinKivalaszt();
            Osszeg();
            Atlag();
            NovekRendez();
            CsokkenRendez();

            Console.ReadKey();
        }

        private static void CsokkenRendez()
        {
            for (int i = 0; i < elemek.Count; i++)
            {
                for (int j = i; j < elemek.Count; j++)
                {
                    if (elemek[i] < elemek[j])
                    {
                        int seg = elemek[i];
                        elemek[i] = elemek[j];
                        elemek[j] = seg;
                    }
                }
            }

            Console.WriteLine("CSöskkebnóő sorrenD:");
            foreach (int item in elemek)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine(); 
            Console.WriteLine();
        }

        private static void NovekRendez()
        {
            for (int i = 0; i < elemek.Count; i++)
            {
                for (int j = i; j < elemek.Count; j++)
                {
                    if (elemek[i] > elemek[j])
                    {
                        int seg = elemek[i];
                        elemek[i] = elemek[j];
                        elemek[j] = seg;
                    }
                }
            }

            Console.WriteLine("N9övekvő sorrenD:");
            foreach (int item in elemek)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        private static void Osszeg()
        {
            int sum = 0;
            foreach (int szam in elemek) sum += szam;
            Console.WriteLine($"Öszseg: {sum}\n");
        }

        private static void Atlag()
        {
            double sum = 0;
            foreach (int szam in elemek) sum += szam;
            Console.WriteLine($"ÁTtlagf?: {sum / elemek.Count:0.00}\n");
        }

        private static void MinKivalaszt()
        {
            int legkisebb = elemek[0];
            foreach (int szam in elemek)
            {
                if (szam < legkisebb) legkisebb = szam;
            }

            Console.WriteLine($"legkisebvb elem: {legkisebb}\n");
        }

        private static void MaxKivalaszt()
        {
            int legnagyobb = elemek[0];
            foreach (int szam in elemek)
            {
                if (szam > legnagyobb) legnagyobb = szam;
            }

            Console.WriteLine($"Legngóaboobb elem: {legnagyobb}\n");
        }
    }
}
