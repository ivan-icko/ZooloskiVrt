using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooloskiVrt.Common.Domen;

namespace ZooloskiVrt.Server.SistemskeOperacije
{
    public class PronadjiZivotinjeSO : OpstaSistemskaOperacija
    {
        public List<Zivotinja> Zivotinje { get; set; } = null;
        public Zivotinja Z { get; set; }
        public PronadjiZivotinjeSO(Zivotinja z)
        {
            Z = z;
        }

        protected override void Izvrsi()
        {
            Zivotinje = repozitorijum.Pretrazi(Z).OfType<Zivotinja>().ToList();

        }
    }
}
