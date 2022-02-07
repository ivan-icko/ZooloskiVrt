using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooloskiVrt.Common.Domen;

namespace ZooloskiVrt.Server.SistemskeOperacije
{
    public class AzurirajZivotinjuSO : OpstaSistemskaOperacija
    {
        public Zivotinja Z { get; set; }
        public AzurirajZivotinjuSO(Zivotinja z)
        {
            Z = z;
        }
        protected override void Izvrsi()
        {
            repozitorijum.Azuriraj(Z);
        }
    }
}
