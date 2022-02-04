using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using ZooloskiVrt.Common.Domen;
using ZooloskiVrt.Common.Komunikacija;
using ZooloskiVrt.Server.AplikacionaLogika;

namespace ZooloskiVrt.Server.Main
{
    public class ClientHandler
    {
        private Socket klijentskiSocket;
        private CommunicationHelper helper;

        public ClientHandler(Socket klijentskiSocket)
        {
            this.klijentskiSocket = klijentskiSocket;
            helper = new CommunicationHelper(klijentskiSocket);
        }

        private bool kraj = false;
        public void HandleRequests()
        {
            try
            {
                while (!kraj)
                {
                    Zahtev zahtev = helper.Primi<Zahtev>();
                    Odgovor response = KreirajOdgovor(zahtev);
                    helper.Posalji(response);
                }
            }
            catch (IOException ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
            }
            finally
            {
                ZatvoriSoket();
            }
        }



        private Odgovor KreirajOdgovor(Zahtev zahtev)
        {
            Odgovor odgovor = new Odgovor();
            try
            {
                switch (zahtev.Operacija)
                {
                    case Operacija.Prijava:
                        odgovor.Rezultat = Controller.Instance.PronadjiZaposlenog(zahtev.Objekat as string);
                        if (odgovor.Rezultat == null)
                        {
                            odgovor.Ok = false;
                            odgovor.Poruka = "Ne postoji takav korisnik!";
                        }
                        break;
                    case Operacija.DodajZivotinju:
                        Controller.Instance.DodajZivotinju((Zivotinja)zahtev.Objekat);
                        break;
                    case Operacija.VratiSveZivotinje:
                        odgovor.Rezultat = Controller.Instance.VratiSveZivotinje();
                        break;
                    case Operacija.ObrisiZivotinju:
                        Controller.Instance.ObrisiZivotinju(zahtev.Objekat as Zivotinja);
                        break;
                    case Operacija.PronadjiZivotinje:
                        odgovor.Rezultat=Controller.Instance.PronadjiZivotinje(zahtev.Objekat as string);
                        break;
                    default:
                        break;
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
                odgovor.Ok = false;
                odgovor.Poruka = ex.Message;
            }
            return odgovor;
        }

        public void ZatvoriSoket()
        {
            if (klijentskiSocket != null)
            {
                kraj = true;
                klijentskiSocket.Shutdown(SocketShutdown.Both);
                klijentskiSocket.Close();
                klijentskiSocket = null;
            }
        }
    }
}
