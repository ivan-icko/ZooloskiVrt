using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooloskiVrt.Common.Domen;

namespace ZooloskiVrt.Server.SistemskeOperacije
{
    public class KreirajZivotinjuSO : OpstaSistemskaOperacija
    {
        private Zivotinja zivotinja;
        public KreirajZivotinjuSO(Zivotinja z)
        {
            zivotinja = z;
        }

        protected override void Izvrsi()
        {
            repozitorijum.Sacuvaj(zivotinja);
        }
    }
}
