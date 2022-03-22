using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooloskiVrt.Common.Domen;

namespace ZooloskiVrt.Server.SistemskeOperacije
{
    public class SacuvajZivotinjuSO : OpstaSistemskaOperacija
    {
        private Zivotinja zivotinja;
        public bool Signal { get; set; } = true;
        public SacuvajZivotinjuSO(Zivotinja z)
        {
            zivotinja = z;
        }

        protected override void Izvrsi()
        {
            try
            {
                repozitorijum.Sacuvaj(zivotinja);
            }
            catch (Exception ex)
            {
                Signal = false;
                throw;
            }
        }
    }
}
