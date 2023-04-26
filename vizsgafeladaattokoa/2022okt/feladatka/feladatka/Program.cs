using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladatka
{
    class Program
    {
        static List<Chat> chats = FileReadinator.ReadChats();

        static void Main(string[] args)
        {
            Console.WriteLine(chats.Count);

            Console.ReadKey();
        }
    }
}
