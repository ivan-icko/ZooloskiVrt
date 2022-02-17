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
        public bool Signal { get; set; } = true;
        public AzurirajZivotinjuSO(Zivotinja z)
        {
            Z = z;
        }
        protected override void Izvrsi()
        {
            try
            {
                repozitorijum.Azuriraj(Z);
            }
            catch (Exception ex)
            {
                Signal = false;
                throw;
            }
        }
    }
}
