using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooloskiVrt.Common.Domen;

namespace ZooloskiVrt.Server.SistemskeOperacije
{
    public class VratiSveZivotinjeSO : OpstaSistemskaOperacija
    {
        public List<Zivotinja> Zivotinje { get; set; } = new List<Zivotinja>();

        protected override void Izvrsi()
        {

            try
            {
                Zivotinje = repozitorijum.VratiSve(new Zivotinja()).OfType<Zivotinja>().ToList();
            }
            catch (Exception ex)
            {
                Zivotinje = null;
                throw;
            }
        }
    }
}
