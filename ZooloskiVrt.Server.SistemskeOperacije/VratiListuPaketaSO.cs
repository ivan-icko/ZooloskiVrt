using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooloskiVrt.Common.Domen;

namespace ZooloskiVrt.Server.SistemskeOperacije
{
    public class VratiListuPaketaSO : OpstaSistemskaOperacija   
    {
        public object Paketi { get; set; }

        protected override void Izvrsi()
        {
            Paketi = repozitorijum.VratiSve(new Paket()).OfType<Paket>().ToList();
        }
    }
}
