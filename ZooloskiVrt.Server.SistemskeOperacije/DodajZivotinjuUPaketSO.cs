﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooloskiVrt.Common.Domen;

namespace ZooloskiVrt.Server.SistemskeOperacije
{
    public class DodajZivotinjuUPaketSO : OpstaSistemskaOperacija
    {
        private PaketZivotinja paketZivotinja;

        public DodajZivotinjuUPaketSO(PaketZivotinja paketZivotinja)
        {
            this.paketZivotinja = paketZivotinja;
        }

        protected override void Izvrsi()
        {
            repozitorijum.Sacuvaj(paketZivotinja);
        }
    }
}