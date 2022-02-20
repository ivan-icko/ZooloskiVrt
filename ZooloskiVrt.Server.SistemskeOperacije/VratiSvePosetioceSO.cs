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
        public List<Posetilac> Posetioci { get; set; } = new List<Posetilac>();
        protected override void Izvrsi()
        {
            try
            {
                Posetioci = repozitorijum.VratiSve(new Posetilac()).OfType<Posetilac>().ToList();
            }
            catch (Exception ex)
            {
               Posetioci = null;
                throw;
            }
        }
    }
}
