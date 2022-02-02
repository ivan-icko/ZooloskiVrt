using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooloskiVrt.Common.Domen;

namespace ZooloskiVrt.Server.SistemskeOperacije
{
    public class VratiListuZivotinjaSO : OpstaSistemskaOperacija
    {
        public List<Zivotinja> Zivotinje { get; set; }

        protected override void Izvrsi()
        {
            Zivotinje = repozitorijum.VratiSve(new Zivotinja()).OfType<Zivotinja>().ToList();
        }
    }
}
