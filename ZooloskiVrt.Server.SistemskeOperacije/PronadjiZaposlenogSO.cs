using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooloskiVrt.Common.Domen;

namespace ZooloskiVrt.Server.SistemskeOperacije
{
    public class PronadjiZaposlenogSO : OpstaSistemskaOperacija
    {
        
        
        public Zaposleni Zaposleni { get; set; }
        public PronadjiZaposlenogSO(Zaposleni z)
        {
            Zaposleni = z;
        }
        protected override void Izvrsi()
        {
            Zaposleni = (repozitorijum.Pretrazi(Zaposleni)==null?null: (repozitorijum.Pretrazi(Zaposleni).OfType<Zaposleni>().ToList()).SingleOrDefault());
        }
    }
}
