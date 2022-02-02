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
        public ObrisiZivotinjuSO(Zivotinja z)
        {
            Zivotinja = z;
        }

        protected override void Izvrsi()
        {
            repozitorijum.Obrisi(Zivotinja);
        }
    }
}
