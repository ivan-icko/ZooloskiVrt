using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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




        public Izlaz ZahtevajIVratiRezultat<Izlaz>(Operacija op, object o = null) where Izlaz : class
        {
            Zahtevaj(op, o);
            return VratiRezultat<Izlaz>();
        }

        public void ZahtevajBezVracanja(Operacija operacija, object o = null)
        {
            Zahtevaj(operacija, o);
            VratiRezultat<object>();
            // return VratiUspesnostZahteva();
        }

        public bool VratiUspesnostZahteva()
        {
            Odgovor odgovor = helper.Primi<Odgovor>();
            if (odgovor.Ok)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private T VratiRezultat<T>() where T : class
        {
            Odgovor odgovor = helper.Primi<Odgovor>();

            if (odgovor.Ok)
            {
                if (odgovor.PrikaziPoruku)
                {
                    System.Windows.Forms.MessageBox.Show(odgovor.Poruka, "Uspesno", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                }
                return (T)odgovor.Rezultat;
            }
            else if (!odgovor.Ok)
            {
                if (odgovor.PrikaziPoruku)
                {
                    System.Windows.Forms.MessageBox.Show(odgovor.Poruka, "Greska", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                }
                return null;
            }
            else
            {
                throw new Exception();
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
                System.Windows.Forms.MessageBox.Show("Greka pri komunikaciji sa serverom", "Greska", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }
        /*
                public void VratiRezultat()
                {
                    Odgovor odgovor = helper.Primi<Odgovor>();
                    if (!odgovor.Ok)
                    {
                        System.Windows.Forms.MessageBox.Show(odgovor.Poruka);
                    }
                }*/

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
