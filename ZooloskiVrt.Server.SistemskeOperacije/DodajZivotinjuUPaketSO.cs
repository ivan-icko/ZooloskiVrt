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
        public bool Signal { get; set; } = true;

        public DodajZivotinjuUPaketSO(PaketZivotinja paketZivotinja)
        {
            this.paketZivotinja = paketZivotinja;
        }

        protected override void Izvrsi()
        {
            try
            {
                repozitorijum.Sacuvaj(paketZivotinja);
            }
            catch (Exception ex)
            {
                Signal = false;
                throw;
            }
        }
    }
}
