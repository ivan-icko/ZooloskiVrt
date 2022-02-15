using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooloskiVrt.Common.Domen;

namespace ZooloskiVrt.Server.SistemskeOperacije
{
    public class VratiSvePrijaveSO : OpstaSistemskaOperacija
    {
        private PosetilacPrijava pp;

        public VratiSvePrijaveSO(PosetilacPrijava pp)
        {
            this.pp = pp;
        }

        public List<PosetilacPrijava> Prijave { get; set; }

        protected override void Izvrsi()
        {
            Prijave=repozitorijum.VratiSve(pp).OfType<PosetilacPrijava>().ToList();
        }
    }
}
