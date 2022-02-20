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
        public List<Paket> Paketi { get; set; } = new List<Paket>();
        public Paket P { get; set; }
        public PronadjiPaketeSO(Paket p)
        {
            this.P = p;
        }
        protected override void Izvrsi()
        {

            try
            {
                Paketi = repozitorijum.Pretrazi(P).OfType<Paket>().ToList();
            }
            catch (Exception ex)
            {
                Paketi = null;
                throw;
            }

        }
    }
}
