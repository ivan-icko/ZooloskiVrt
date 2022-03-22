using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooloskiVrt.Common.Domen;

namespace ZooloskiVrt.Server.SistemskeOperacije
{
    public class SacuvajPaketSO : OpstaSistemskaOperacija
    {
        private Paket p;
        public bool Signal { get; set; } = true;
        public SacuvajPaketSO(Paket p)
        {
            this.p = p;
        }

        protected override void Izvrsi()
        {
            try
            {
                
                repozitorijum.Sacuvaj(p);
                int maxId = repozitorijum.VratiNajveciId(p);
                if (p.ListaIdjevaZivotinja != null && p.ListaIdjevaZivotinja.Count > 0)
                {
                    foreach (int id in p.ListaIdjevaZivotinja)
                    {
                        repozitorijum.Sacuvaj(new PaketZivotinja { IdPaketa = maxId, IdZivotinje = id });
                    }
                }
            }
            catch (Exception ex)
            {
                Signal = false;
                throw;
            }
        }
    }
}
