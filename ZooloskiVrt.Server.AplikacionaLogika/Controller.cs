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

       


        public bool DodajZivotinju(Zivotinja z)
        {
            OpstaSistemskaOperacija so = new SacuvajZivotinjuSO(z);
            so.IzvrsiTemplejt();
            return ((SacuvajZivotinjuSO)so).Signal;
        }

        public List<Zivotinja> VratiSveZivotinje()
        {
            OpstaSistemskaOperacija so = new VratiSveZivotinjeSO();
            so.IzvrsiTemplejt();
            return ((VratiSveZivotinjeSO)so).Zivotinje;
        }

        public bool ObrisiZivotinju(Zivotinja z)
        {
            OpstaSistemskaOperacija so = new ObrisiZivotinjuSO(z);
            so.IzvrsiTemplejt();
            return ((ObrisiZivotinjuSO)so).Signal;
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

        public bool AzurirajZivotinju(Zivotinja z)
        {
            OpstaSistemskaOperacija so = new AzurirajZivotinjuSO(z);
            so.IzvrsiTemplejt();
            return ((AzurirajZivotinjuSO)so).Signal;
        }

        public bool DodajPaket(Paket p)
        {
            OpstaSistemskaOperacija so = new SacuvajPaketSO(p);
            so.IzvrsiTemplejt();
            return ((SacuvajPaketSO)so).Signal;
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

        public bool AzurirajPaket(Paket paket)
        {
            OpstaSistemskaOperacija so = new AzurirajPaketSO(paket);
            so.IzvrsiTemplejt();
            return ((AzurirajPaketSO)so).Signal;
        }

        public List<Paket> PronadjiPakete(Paket paket)
        {
            OpstaSistemskaOperacija so = new PronadjiPaketeSO(paket);
            so.IzvrsiTemplejt();
            return ((PronadjiPaketeSO)so).Paketi;
        }

    

        public List<Posetilac> VratiSvePosetioce(Posetilac posetilac)
        {
            OpstaSistemskaOperacija so = new VratiSvePosetioceSO();
            so.IzvrsiTemplejt();
            return ((VratiSvePosetioceSO)so).Posetioci;
        }

        public bool DodajPrijavu(Prijava prijava)
        {
            OpstaSistemskaOperacija so = new SacuvajPrijavuSO(prijava);
            so.IzvrsiTemplejt();
            return ((SacuvajPrijavuSO)so).Signal;
        }

        public List<PosetilacPrijava> VratiSvePrijaveZaPosetioce(PosetilacPrijava pp)
        {
            OpstaSistemskaOperacija so = new VratiSvePrijaveZaPosetioceSO(pp);
            so.IzvrsiTemplejt();
            return ((VratiSvePrijaveZaPosetioceSO)so).Prijave;
        }
        public List<Prijava> VratiSvePrijave(Prijava pp)
        {
            OpstaSistemskaOperacija so = new VratiSvePrijaveSO(pp);
            so.IzvrsiTemplejt();
            return ((VratiSvePrijaveSO)so).Prijave;
        }

      
    }
}
