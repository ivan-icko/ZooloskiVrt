using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using ZooloskiVrt.Common.Komunikacija;


namespace ZooloskiVrt.Klijent.Forme
{
   public class Komunikacija
    {
        private Socket socket;
        private CommunicationHelper helper;
        private static Komunikacija instance;
        private Komunikacija()
        {
        }
        public static Komunikacija Instance
        {
            get
            {
                if (instance == null) instance = new Komunikacija();
                return instance;
            }
        }
        public void PoveziSe()
        {
            if (socket == null || !socket.Connected)
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect("127.0.0.1", 9999);
                helper = new CommunicationHelper(socket);
            }
        }

      

        public Izlaz ZahtevajIVratiRezultat<Izlaz>(Operacija op, object o=null) where Izlaz : class
        {
            Zahtevaj(op, o);
            return VratiRezultat<Izlaz>();
        }
        public void ZahtevajBezVracanja(Operacija operacija,object o)
        {
            Zahtevaj(operacija, o);
            VratiRezultat();
        } 

        private T VratiRezultat<T>() where T : class
        {
            Odgovor odgovor = helper.Primi<Odgovor>();
            if (odgovor.Ok)
            {
                return (T)odgovor.Rezultat;
            }
            else if (!odgovor.Ok)
            {
                return null;
            }
            else
            {
                throw new Exception(odgovor.Poruka);
            }
        }

        private void Zahtevaj(Operacija operacija, object objekat)
        {
            try
            {
                Zahtev r = new Zahtev
                {
                    Operacija = operacija,
                    Objekat = objekat
                };
                helper.Posalji(r);
            }
            catch (IOException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void VratiRezultat()
        {
            Odgovor odgovor = helper.Primi<Odgovor>();
            if (!odgovor.Ok)
            {
                System.Windows.Forms.MessageBox.Show(odgovor.Poruka);
            }
        }

        public void Zatvori()
        {
            if (socket == null) return;
            Zahtev zahtev = new Zahtev
            {
                Operacija = Operacija.Kraj,
            };
            helper.Posalji(zahtev);
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
            socket = null;
        }
    }
}
