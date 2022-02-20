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

        private List<Zaposleni> administratori;
        private Zaposleni ulogovan;

        public ClientHandler(Socket klijentskiSocket, List<Zaposleni> administratori)
        {
            this.klijentskiSocket = klijentskiSocket;
            helper = new CommunicationHelper(klijentskiSocket);
            this.administratori = administratori;
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

        private void PrijavaHandler(Zahtev zahtev, ref Odgovor odgovor)
        {
            odgovor.Rezultat = Controller.Instance.PronadjiZaposlenog((Zaposleni)zahtev.Objekat);
            if (odgovor.Rezultat == null)
            {
                odgovor.Ok = false;
                odgovor.Poruka = "Sistem ne moze da pronadje zaposlenog na osnovu ucitanih vrednosti!";
            }
            else
            {

                string imejl = ((Zaposleni)odgovor.Rezultat).KorisnickoIme;
                string sifra = ((Zaposleni)odgovor.Rezultat).KorisnickoIme;
                if (administratori.Any(s => (s.KorisnickoIme == imejl && s.Sifra == sifra)))
                {
                    odgovor.Ok = false;
                    odgovor.Poruka = "Ovaj zaposleni je već prijavljen na sistem";
                }
                else
                {
                    odgovor.Ok = true;
                    odgovor.Poruka = "Sistem je nasao zaposlenog po zadatim podacima!";
                    ulogovan = (Zaposleni)odgovor.Rezultat;
                    administratori.Add(ulogovan);
                }
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
                        PrijavaHandler(zahtev, ref odgovor);
                        break;
                    case Operacija.DodajZivotinju:
                        odgovor.Ok = Controller.Instance.DodajZivotinju((Zivotinja)zahtev.Objekat);
                        if (odgovor.Ok)
                        {
                            odgovor.Poruka = "Sistem je zapamtio zivotinju";
                        }
                        else
                        {
                            odgovor.Poruka = "Sistem ne moze da zapamti zivotinju";
                        }
                        break;
                    case Operacija.VratiSveZivotinje:
                        odgovor.Rezultat = Controller.Instance.VratiSveZivotinje();
                        if (odgovor.Rezultat == null)
                        {
                            odgovor.PrikaziPoruku = false;
                            odgovor.Ok = false;
                            odgovor.Poruka = "Sistem ne moze da ucita podatke o zivotinjama";
                        }
                        else
                        {
                            odgovor.PrikaziPoruku = false;
                            odgovor.Ok = true;
                            odgovor.Poruka = "Sistem je uspesno ucitao podatke o zivotinjama";
                        }
                        break;
                    case Operacija.ObrisiZivotinju:
                        odgovor.Ok = Controller.Instance.ObrisiZivotinju(zahtev.Objekat as Zivotinja);
                        if (odgovor.Ok == false)
                        {
                            odgovor.Poruka = "Sistem ne moze da obrise zivotinju";
                        }
                        else { odgovor.Poruka = "Sistem je obrisao zivotinju"; }
                        break;
                    case Operacija.PronadjiZivotinje:
                        odgovor.Rezultat = Controller.Instance.PronadjiZivotinje(zahtev.Objekat as Zivotinja);
                        if (odgovor.Rezultat == null)
                        {
                            odgovor.Poruka = "Sistem ne moze da pronadje zivotinje po zadatoj vrednosti";
                            odgovor.Ok = false;
                        }
                        else
                        {
                            odgovor.Ok = true;
                            odgovor.Poruka = "Sistem je pronasao zivotinje po zadatoj vrednosti";
                        }
                        break;
                    case Operacija.PronadjiZivotinjeZaPaket:
                        odgovor.Rezultat = Controller.Instance.PronadjiZivotinje(zahtev.Objekat as Zivotinja);
                        if (odgovor.Rezultat == null)
                        {
                            odgovor.Poruka = "Sistem ne moze da pronadje zivotinje po zadatoj vrednosti";
                            odgovor.Ok = false;
                        }
                        else
                        {
                            odgovor.PrikaziPoruku = false;
                            odgovor.Ok = true;
                            odgovor.Poruka = "Sistem je pronasao zivotinje po zadatoj vrednosti";
                        }
                        break;
                    case Operacija.AzurirajZivotinju:
                        odgovor.Ok = Controller.Instance.AzurirajZivotinju(zahtev.Objekat as Zivotinja);
                        if (odgovor.Ok == false)
                        {
                            odgovor.Poruka = "Sistem ne moze da azurira podatke o zivotinji";
                        }
                        else { odgovor.Poruka = "Sistem je uspesno azurirao podatke o zivotinji"; }
                        break;
                    case Operacija.DodajPaket:
                        odgovor.Ok = Controller.Instance.DodajPaket(zahtev.Objekat as Paket);
                        if (odgovor.Ok)
                        {
                            odgovor.Poruka = "Sistem je uspesno zapamtio paket";
                        }
                        else
                        {
                            odgovor.Poruka = "Sistem ne moze da zapamti paket";
                        }
                        break;
                    case Operacija.VratiSvePakete:
                        odgovor.Rezultat = Controller.Instance.VratiSvePakete();
                        if (odgovor.Rezultat == null)
                        {
                            odgovor.PrikaziPoruku = false;
                            odgovor.Ok = false;
                            odgovor.Poruka = "Sistem ne moze da ucita podatke o paketu";
                        }
                        else
                        {
                            odgovor.PrikaziPoruku = false;
                            odgovor.Ok = true;
                            odgovor.Poruka = "Sistem je ucitao podatke o paketu";
                        }
                        break;
                    case Operacija.VratiZIvotinjeZaPakete:
                        odgovor.Rezultat = Controller.Instance.VratiZivotinjeZaPakete(zahtev.Objekat as Zivotinja);
                        if (odgovor.Rezultat != null)
                        {
                            odgovor.PrikaziPoruku = false;
                            odgovor.Ok = true;
                            odgovor.Poruka = "Sistem je uspesno ucitao zivotinje za izabrani paket";
                        }
                        else
                        {
                            odgovor.PrikaziPoruku = false;
                            odgovor.Ok = false;
                            odgovor.Poruka = "Sistem ne moze da ucita podatke o zivotinjama";
                        }
                        break;
                    case Operacija.AzurirajPaket:
                        odgovor.Ok = Controller.Instance.AzurirajPaket(zahtev.Objekat as Paket);
                        if (odgovor.Ok == false)
                        {
                            odgovor.Poruka = "Sistem ne moze da azurira podatke o paket";
                        }
                        else { odgovor.Poruka = "Sistem je uspesno azurirao podatke o paketu"; }
                        break;
                    case Operacija.PronadjiPakete:
                        odgovor.Rezultat = Controller.Instance.PronadjiPakete(zahtev.Objekat as Paket);
                        if (odgovor.Rezultat == null)
                        {
                            odgovor.Ok = false;
                            odgovor.Poruka = "Sistem ne moze da pronadje pakete po zadatoj vrednosti";
                        }
                        else
                        {
                            odgovor.Ok = true;
                            odgovor.Poruka = "Sistem je pronasao pakete po zadatoj vrednosti";
                        }
                        break;
                    
                    case Operacija.VratiSvePosetioce:
                        odgovor.Rezultat = Controller.Instance.VratiSvePosetioce(zahtev.Objekat as Posetilac);
                        if (odgovor.Rezultat == null)
                        {
                            odgovor.Ok = false;
                            odgovor.Poruka = "Sistem ne moze da ucita posetioce";
                        }
                        else
                        {
                            odgovor.Ok = true;
                            odgovor.Poruka = "Sistem je uspesno ucitao posetioce";
                            odgovor.PrikaziPoruku = false;
                        }
                        break;
                    case Operacija.DodajPrijavu:
                        odgovor.Ok = Controller.Instance.DodajPrijavu(zahtev.Objekat as Prijava);
                        if (odgovor.Ok)
                        {
                            odgovor.Poruka = "Sistem je uspesno sacuvao prijavu na paket";
                        }
                        else
                        {
                            odgovor.Poruka = "Sistem ne moze da sacuva prijavu na paket";
                        }
                        break;
                    case Operacija.VratiSvePrijaveZaPosetioce:
                        odgovor.Rezultat = Controller.Instance.VratiSvePrijaveZaPosetioce(zahtev.Objekat as PosetilacPrijava);
                        if (odgovor.Rezultat == null)
                        {
                            odgovor.Poruka = "Sistem ne moze da vrati prijave za posetioce";
                            odgovor.Ok = false;
                        }
                        else
                        {
                            odgovor.Poruka = "Sistem je uspesno ucitao prijave za posetioce";
                            odgovor.Ok = true;
                            odgovor.PrikaziPoruku = false;
                        }
                        break;
                  
                    case Operacija.VratiSvePrijave:
                        odgovor.Rezultat = Controller.Instance.VratiSvePrijave(zahtev.Objekat as Prijava);
                        if (odgovor == null)
                        {
                            odgovor.Ok = false;
                            odgovor.Poruka = "Sistem ne moze da prikaze prijave";
                        }
                        else
                        {
                            odgovor.Ok = true;
                            odgovor.Poruka = "Sistem je uspesno ucitao prijave";
                            odgovor.PrikaziPoruku = false;
                        }
                        break;
                    case Operacija.Kraj:
                        administratori.Remove(ulogovan);
                        odgovor.Poruka = "Dovodjenja";
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
                administratori.Remove(ulogovan);
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
