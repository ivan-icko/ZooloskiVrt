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
        public EventHandler OdjavljenKlijent;

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
                        odgovor.Rezultat = Controller.Instance.PronadjiZaposlenog(zahtev.Objekat as Zaposleni);
                        if (odgovor.Rezultat == null)
                        {
                            odgovor.Ok = false;
                            odgovor.Poruka = "Ne postoji takav korisnik!";
                        }
                        break;
                    case Operacija.DodajZivotinju:
                        odgovor.Ok = Controller.Instance.DodajZivotinju((Zivotinja)zahtev.Objekat);
                        break;
                    case Operacija.VratiSveZivotinje:
                        odgovor.Rezultat = Controller.Instance.VratiSveZivotinje();
                        break;
                    case Operacija.ObrisiZivotinju:
                        odgovor.Ok=Controller.Instance.ObrisiZivotinju(zahtev.Objekat as Zivotinja);
                        break;
                    case Operacija.PronadjiZivotinje:
                        odgovor.Rezultat = Controller.Instance.PronadjiZivotinje(zahtev.Objekat as Zivotinja);
                        break;
                    case Operacija.AzurirajZivotinju:
                        odgovor.Ok = Controller.Instance.AzurirajZivotinju(zahtev.Objekat as Zivotinja);
                        break;
                    case Operacija.DodajPaket:
                        odgovor.Ok = Controller.Instance.DodajPaket(zahtev.Objekat as Paket);
                        break;
                    case Operacija.VratiSvePakete:
                        odgovor.Rezultat = Controller.Instance.VratiSvePakete();
                        break;
                    case Operacija.VratiZIvotinjeZaPakete:
                        odgovor.Rezultat = Controller.Instance.VratiZivotinjeZaPakete(zahtev.Objekat as Zivotinja);
                        break;
                    case Operacija.AzurirajPaket:
                        Controller.Instance.AzurirajPaket(zahtev.Objekat as Paket);
                        break;
                    case Operacija.PronadjiPakete:
                        odgovor.Rezultat = Controller.Instance.PronadjiPakete(zahtev.Objekat as Paket);
                        break;
                    case Operacija.DodajZivotinjuUPaket:
                        Controller.Instance.DodajZivotinjuUPaket(zahtev.Objekat as PaketZivotinja);
                        break;
                    case Operacija.VratiSvePosetioce:
                        odgovor.Rezultat = Controller.Instance.VratiSvePosetioce(zahtev.Objekat as Posetilac);
                        break;
                    case Operacija.DodajPrijavu:
                        Controller.Instance.DodajPrijavu(zahtev.Objekat as Prijava);
                        break;
                    case Operacija.VratiSvePrijaveZaPosetioce:
                        odgovor.Rezultat = Controller.Instance.VratiSvePrijaveZaPosetioce(zahtev.Objekat as PosetilacPrijava);
                        break;
                    case Operacija.IzbrisiZivotinjuIzPaketa:
                        odgovor.Ok=Controller.Instance.ObrisiZivotinjuIzPaketa(zahtev.Objekat as PaketZivotinja);
                        break;
                    case Operacija.VratiSvePrijave:
                        odgovor.Rezultat = Controller.Instance.VratiSvePrijave(zahtev.Objekat as Prijava);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
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
                OdjavljenKlijent?.Invoke(this, EventArgs.Empty);
            }
        }





       
    }
}
