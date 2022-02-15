using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooloskiVrt.Common.Domen;
using ZooloskiVrt.Server.SistemskeOperacije;

namespace ZooloskiVrt.Server.AplikacionaLogika
{
    public class Controller
    {
        private static Controller instance;
        private Controller(){}

        public static Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Controller();
                }
                return instance;
            }
        }

        


        public void DodajZivotinju(Zivotinja z)
        {
            OpstaSistemskaOperacija so = new KreirajZivotinjuSO(z);
            so.IzvrsiTemplejt();
        }

        public List<Zivotinja> VratiSveZivotinje()
        {
            OpstaSistemskaOperacija so = new VratiSveZivotinjeSO();
            so.IzvrsiTemplejt();
            return ((VratiSveZivotinjeSO)so).Zivotinje;
        }

        public void ObrisiZivotinju(Zivotinja z)
        {
            OpstaSistemskaOperacija so = new ObrisiZivotinjuSO(z);
            so.IzvrsiTemplejt();
        }

        public List<Zivotinja> PronadjiZivotinje(Zivotinja z)
        {
            OpstaSistemskaOperacija so = new PronadjiZivotinjeSO(z);
            so.IzvrsiTemplejt();
            return ((PronadjiZivotinjeSO)so).Zivotinje;
        }

        public Zaposleni PronadjiZaposlenog(Zaposleni z)
        {
            OpstaSistemskaOperacija so = new PronadjiZaposlenogSO(z);
            so.IzvrsiTemplejt();
            return ((PronadjiZaposlenogSO)so).Zaposleni;
        }

        public void AzurirajZivotinju(Zivotinja z)
        {
            OpstaSistemskaOperacija so = new AzurirajZivotinjuSO(z);
            so.IzvrsiTemplejt();
        }

        public void DodajPaket(Paket p)
        {
            OpstaSistemskaOperacija so = new KreirajPaketSO(p);
            so.IzvrsiTemplejt();
        }

        public List<Paket> VratiSvePakete()
        {
            OpstaSistemskaOperacija so = new VratiSvePaketeSO();
            so.IzvrsiTemplejt();
            return ((VratiSvePaketeSO)so).Paketi;
        }

        public List<Zivotinja> VratiZivotinjeZaPakete(Zivotinja zivotinja)
        {
            OpstaSistemskaOperacija so = new VratiZivotinjeZaPaketeSO(zivotinja);
            so.IzvrsiTemplejt();
            return ((VratiZivotinjeZaPaketeSO)so).Zivotinje;
        }

        public void AzurirajPaket(Paket paket)
        {
            OpstaSistemskaOperacija so = new AzurirajPaketSO(paket);
            so.IzvrsiTemplejt();
        }

        public List<Paket> PronadjiPakete(Paket paket)
        {
            OpstaSistemskaOperacija so = new PronadjiPaketeSO(paket);
            so.IzvrsiTemplejt();
            return ((PronadjiPaketeSO)so).Paketi;
        }

        public void DodajZivotinjuUPaket(PaketZivotinja paketZivotinja)
        {
            OpstaSistemskaOperacija so = new DodajZivotinjuUPaketSO(paketZivotinja);
            so.IzvrsiTemplejt();
        }

        public List<Posetilac> VratiSvePosetioce(Posetilac posetilac)
        {
            OpstaSistemskaOperacija so = new VratiSvePosetioceSO();
            so.IzvrsiTemplejt();
            return ((VratiSvePosetioceSO)so).Posetioci;
        }

        public void DodajPrijavu(Prijava prijava)
        {
            OpstaSistemskaOperacija so = new SacuvajPrijavuSO(prijava);
            so.IzvrsiTemplejt();
        }

        public List<PosetilacPrijava> VratiSvePrijave(PosetilacPrijava pp)
        {
            OpstaSistemskaOperacija so = new VratiSvePrijaveSO(pp);
            so.IzvrsiTemplejt();
            return ((VratiSvePrijaveSO)so).Prijave;
        }
    }
}
