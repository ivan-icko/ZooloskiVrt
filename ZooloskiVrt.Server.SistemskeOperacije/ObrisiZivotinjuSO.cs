using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooloskiVrt.Common.Domen;

namespace ZooloskiVrt.Server.SistemskeOperacije
{
    public class ObrisiZivotinjuSO : OpstaSistemskaOperacija
    {
        public Zivotinja Zivotinja { get; set; }
        public bool Signal { get; set; } = true;
        public ObrisiZivotinjuSO(Zivotinja z)
        {
            Zivotinja = z;
        }

        protected override void Izvrsi()
        {
            try
            {
                repozitorijum.Obrisi(Zivotinja);
            }
            catch (Exception ex)
            {
                Signal = false;
                throw;
            }
        }
    }
}
