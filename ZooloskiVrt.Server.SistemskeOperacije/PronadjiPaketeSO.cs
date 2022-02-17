using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooloskiVrt.Common.Domen;

namespace ZooloskiVrt.Server.SistemskeOperacije
{
    public class PronadjiPaketeSO : OpstaSistemskaOperacija
    {
        public List<Paket> Paketi { get; set; }
        public Paket P { get; set; }
        public PronadjiPaketeSO(Paket p)
        {
            this.P = p;
        }
        protected override void Izvrsi()
        {

            Paketi = repozitorijum.Pretrazi(P).OfType<Paket>().ToList();

        }
    }
}
