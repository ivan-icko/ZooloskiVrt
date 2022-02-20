using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooloskiVrt.Common.Domen;

namespace ZooloskiVrt.Server.SistemskeOperacije
{
    public class VratiSvePaketeSO : OpstaSistemskaOperacija   
    {
        public List<Paket> Paketi { get; set; } = new List<Paket>();

        protected override void Izvrsi()
        {
            try
            {
                Paketi = repozitorijum.VratiSve(new Paket()).OfType<Paket>().ToList();
            }
            catch (Exception ex) 
            {
                Paketi = null;
                throw;
            }
        }
    }
}
