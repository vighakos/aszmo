using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace szokitalaloka
{
    class FileIO
    {
        public static List<string> ReadFile(string filename)
        {
            List<string> lines = new List<string>();

            try
            {
                StreamReader read = new StreamReader(filename, Encoding.Default);

                while (!read.EndOfStream)
                {
                    lines.Add(read.ReadLine());
                }

                read.Close();

            }
            catch (IOException)
            {
                System.Windows.Forms.MessageBox.Show("There was an error while reading the file :(");
            }

            return lines;
        }
    }
}
