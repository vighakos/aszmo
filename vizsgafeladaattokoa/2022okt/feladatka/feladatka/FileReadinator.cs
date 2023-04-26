using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace feladatka
{
    class FileReadinator
    {
        private static List<string> ReadFile(string filename)
        {
            List<string> datas = new List<string>();

            try
            {
                StreamReader r = new StreamReader(filename);

                r.ReadLine();

                while (!r.EndOfStream)
                {
                    datas.Add(r.ReadLine());
                }

                r.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return datas;
        }

        public static List<Chat> GetChats()
        {
            List<Chat> datas = new List<Chat>();



            return datas;
        }
        
        public static List<Member> GetMembers()
        {
            List<Member> datas = new List<Member>();



            return datas;
        }
    }
}
