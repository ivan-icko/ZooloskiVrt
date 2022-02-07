﻿using System;
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
            OpstaSistemskaOperacija so = new VratiListuZivotinjaSO();
            so.IzvrsiTemplejt();
            return ((VratiListuZivotinjaSO)so).Zivotinje;
        }

        public void ObrisiZivotinju(Zivotinja z)
        {
            OpstaSistemskaOperacija so = new ObrisiZivotinjuSO(z);
            so.IzvrsiTemplejt();
        }

        public List<Zivotinja> PronadjiZivotinje(Zivotinja z)
        {
            OpstaSistemskaOperacija so = new PronadjiZivotinjuSO(z);
            so.IzvrsiTemplejt();
            return ((PronadjiZivotinjuSO)so).Zivotinje;
        }

        public Zaposleni PronadjiZaposlenog(Zaposleni z)
        {
            OpstaSistemskaOperacija so = new PretragaZaposlenogSO(z);
            so.IzvrsiTemplejt();
            return ((PretragaZaposlenogSO)so).Zaposleni;
        }

        public void AzurirajZivotinju(Zivotinja z)
        {
            OpstaSistemskaOperacija so = new AzurirajZivotinjuSO(z);
            so.IzvrsiTemplejt();
        }
    }
}
