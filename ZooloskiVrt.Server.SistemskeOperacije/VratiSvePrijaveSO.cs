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
        private Prijava pp;
        public List<Prijava> Prijave { get; set; } = new List<Prijava>();

        public VratiSvePrijaveSO(Prijava pp)
        {
            this.pp = pp;
        }

        protected override void Izvrsi()
        {
            try
            {
                Prijave = repozitorijum.VratiSve(pp).OfType<Prijava>().ToList();
            }
            catch (Exception ex)
            {
                Prijave = null;
                throw;
            }
        }
    }
}
