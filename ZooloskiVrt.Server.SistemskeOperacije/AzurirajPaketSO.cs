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
        public bool Signal { get; set; } = true;
        public AzurirajPaketSO(Paket paket)
        {
            this.paket = paket;
        }



        protected override void Izvrsi()
        {

            try
            {
                repozitorijum.Azuriraj(paket);
                try
                {
                    repozitorijum.Obrisi(new PaketZivotinja() { Uslov = $"IdPaketa={paket.IdPaketa}" });
                }
                catch (Exception ex)
                {
                }
                if (paket.ListaIdjevaZivotinja != null && paket.ListaIdjevaZivotinja.Count > 0)
                {
                    foreach (int id in paket.ListaIdjevaZivotinja)
                    {
                        repozitorijum.Sacuvaj(new PaketZivotinja { IdPaketa = paket.IdPaketa, IdZivotinje = id });
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
