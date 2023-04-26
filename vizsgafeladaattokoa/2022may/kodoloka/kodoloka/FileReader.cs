using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace kodoloka
{
    class FileReader
    {
        static StreamReader read = new StreamReader("bank.txt");
        public static List<Karakter> ReadFile()
        {
            List<Karakter> datas = new List<Karakter>();

            try
            {

                while (!read.EndOfStream)
                {
                    datas.Add(newChar());
                }
            }
            catch (IOException)
            {

            }

            return datas;
        }

        private static Karakter newChar()
        {
            string kar = read.ReadLine();
            int[,] tempMatrix = new int[7, 4];
            for (int sor = 0; sor < 7; sor++)
            {
                string row = read.ReadLine();
                for (int oszlop = 0; oszlop < 4; oszlop++)
                {
                    tempMatrix[sor, oszlop] = row[oszlop];
                }
            }

            return new Karakter(kar, tempMatrix);
        }
    }
}
