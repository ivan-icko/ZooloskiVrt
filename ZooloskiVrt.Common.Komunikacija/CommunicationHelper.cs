using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ZooloskiVrt.Common.Komunikacija
{
    public class CommunicationHelper
    {
        private Socket socket;
        private BinaryFormatter formatter;
        private NetworkStream stream;

        public CommunicationHelper(Socket socket)
        {
            this.socket = socket;
            stream = new NetworkStream(socket);
            formatter = new BinaryFormatter();
        }

        public T Primi<T>()
        {
            return (T)formatter.Deserialize(stream);
        }

        public void Posalji<T>(T objekat)where T:class
        {
            formatter.Serialize(stream, objekat);
        }
    }
}
