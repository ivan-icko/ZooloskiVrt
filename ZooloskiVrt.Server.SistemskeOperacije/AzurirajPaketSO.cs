using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooloskiVrt.Common.Domen;

namespace ZooloskiVrt.Server.SistemskeOperacije
{
    public class AzurirajPaketSO : OpstaSistemskaOperacija
    {
        private Paket paket;

        public AzurirajPaketSO(Paket paket)
        {
            this.paket = paket;
        }

        protected override void Izvrsi()
        {
            repozitorijum.Azuriraj(paket);
        }
    }
}
