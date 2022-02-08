using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooloskiVrt.Common.Domen;

namespace ZooloskiVrt.Server.SistemskeOperacije
{
    public class KreirajPaketSO : OpstaSistemskaOperacija
    {
        private Paket p;
        public KreirajPaketSO(Paket p)
        {
            this.p = p;
        }

        protected override void Izvrsi()
        {
            repozitorijum.Sacuvaj(p);
        }
    }
}
