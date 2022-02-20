using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooloskiVrt.Common.Domen;

namespace ZooloskiVrt.Server.SistemskeOperacije
{
    public class VratiZivotinjeZaPaketeSO : OpstaSistemskaOperacija
    {
        private Zivotinja zivotinja;

        public VratiZivotinjeZaPaketeSO(Zivotinja zivotinja)
        {
            this.zivotinja = zivotinja;
        }

        public List<Zivotinja> Zivotinje { get; set; } = new List<Zivotinja>();

        protected override void Izvrsi()
        {
            try
            {
                Zivotinje = repozitorijum.VratiSve(zivotinja).OfType<Zivotinja>().ToList();
            }
            catch (Exception ex)
            {
                Zivotinje = null;
                throw;
            }
        }
    }
}
