using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ZooloskiVrt.Common.Domen;

namespace ZooloskiVrt.Server.Main
{
    public class Server
    {
        private Socket socket;
        private List<ClientHandler> klijenti = new List<ClientHandler>();
        private List<Zaposleni> administratori = new List<Zaposleni>();


        public bool Start()
        {
            try
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999));
                socket.Listen(5);
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
                return false;
            }
        }

        public void Osluskuj()
        {
            try
            {
                while (true)
                {
                    Socket klijentskiSocket = socket.Accept();
                    ClientHandler client = new ClientHandler(klijentskiSocket,administratori);
                    klijenti.Add(client);
                    client.OdjavljenKlijent += Handler_OdjavljenKlijent;
                    Thread nitKlijenta = new Thread(client.HandleRequests);
                    nitKlijenta.IsBackground = true;
                    nitKlijenta.Start();
                }
            }
            catch (SocketException ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
            }

        }

        public void Handler_OdjavljenKlijent(object sender, EventArgs args)
        {
            klijenti.Remove((ClientHandler)sender);
        }

        public void Stop()
        {
            socket?.Close();
            foreach (ClientHandler handler in klijenti.ToList())
            {
                handler.ZatvoriSoket();
            }
        }
    }
}
