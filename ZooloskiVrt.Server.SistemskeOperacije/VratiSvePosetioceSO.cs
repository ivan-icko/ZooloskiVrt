using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooloskiVrt.Common.Domen;

namespace ZooloskiVrt.Server.SistemskeOperacije
{
    public class VratiSvePosetioceSO : OpstaSistemskaOperacija
    {
        public List<Posetilac> Posetioci { get; set; }
        protected override void Izvrsi()
        {
            Posetioci = repozitorijum.VratiSve(new Posetilac()).OfType<Posetilac>().ToList();
        }
    }
}
