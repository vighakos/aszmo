using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progtet
{
    class Program
    {
        static List<int> elemek = new List<int>() { 23, 45, 67, 32, 21, 24, 576, 45, 986, 12, 1, 54, 765, 43, 59, 120, 516, 89, 1, 142, 32, 321, 654, 97, 156, 971, 1, 111, 222, 555, 666, 999, 0, 74, 61, 1, 1, };
        static void Main(string[] args)
        {
            MaxKivalaszt(); 
            MinKivalaszt();
            Osszeg();
            Atlag();
            //NovekRendez();
            //CsokkenRendez();
            AdottElem();

            Console.ReadKey();
        }

        private static void AdottElem()
        {
            Console.Write("Adj meg egy számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            List<int> helyek = new List<int>();
            bool van = true;
            int db = 0;

            for (int i = 0; i < elemek.Count; i++)
            {
                if (elemek[i] == szam)
                {
                    helyek.Add(i);
                    van = false;
                    db++;
                }
            }

            if (van) Console.WriteLine("Nincs");
            else
            {
                Console.Write($"Van, {db}x, a következő helyeken: ");
                foreach (int item in helyek)
                {
                    Console.Write($"{item + 1}, ");
                }
            }
                
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
