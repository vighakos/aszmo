using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progtet2
{
    class Program
    {
        static List<int> a = new List<int>() { 34, 34, 56, 4, 87, 15, 99, 52, 36, 48, 21, 4, 98, 11, 11, 10, 0, 78, 65, 59, 58, 68, 41, 32, 74};
        static List<int> b = new List<int>() { 34, 34, 55, 6, 4, 97, 15, 99, 5, 36, 48, 0, 88, 31, 4, 98, 11, 63, 1, 10, 0, 78, 65, 58, 41, 32, 74, 57, 66};
        static void Main(string[] args)
        {
            Unio();
            Metszet();
            Kulonbseg();

            Console.ReadKey();
        }

        private static void Kulonbseg()
        {
            List<int> kulonbseg = new List<int>();

            foreach (int item in a)
            {
                if (Tartalmaz(a, item) && !Tartalmaz(b, item))
                {
                    kulonbseg.Add(item);
                }
            }

            Console.WriteLine("\n\naa küoldönség:");
            foreach (int item in kulonbseg)
            {
                Console.Write($"{item}, ");
            }
        }

        private static void Metszet()
        {
            List<int> ab = new List<int>();

            foreach (int item in a)
            {
                foreach (int item2 in b)
                {
                    if (item == item2 && !Tartalmaz(ab, item))
                    {
                        ab.Add(item);
                    }
                }
            }

            Console.WriteLine("\n\naZ másik izében az ememeklemek:");
            foreach (int item in ab)
            {
                Console.Write($"{item}, ");
            }
        }

        private static void Unio()
        {
            List<int> ab = new List<int>();

            foreach (int item in a)
            {
                foreach (int item2 in b)
                {
                    if (!Tartalmaz(ab, item))
                    {
                        ab.Add(item);
                    }
                }
            }

            Console.WriteLine("aZ izében az ememeklemek:");
            foreach (int item in ab)
            {
                Console.Write($"{item}, ");
            }
        }

        private static bool Tartalmaz(List<int> list, int item)
        {
            foreach (int item2 in list)
            {
                if (item == item2) return true;
            }
            return false;
        }
    }
}
