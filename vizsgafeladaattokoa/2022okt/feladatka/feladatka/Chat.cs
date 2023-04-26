using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladatka
{
    class Chat
    {
        public string Start, End, Sender, Receiver;

        public Chat(string line)
        {
            Start = line.Split(';')[0];
            End = line.Split(';')[1];
            Sender = line.Split(';')[2];
            Receiver = line.Split(';')[3];
        }
    }
}
