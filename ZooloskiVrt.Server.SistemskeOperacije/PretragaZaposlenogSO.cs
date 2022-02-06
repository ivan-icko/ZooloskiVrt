using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooloskiVrt.Common.Domen;

namespace ZooloskiVrt.Server.SistemskeOperacije
{
    public class PretragaZaposlenogSO : OpstaSistemskaOperacija
    {
        
        public string Uslov { get; set; }
        public Zaposleni Zaposleni { get; set; }
        public PretragaZaposlenogSO(string uslov)
        {
            Uslov = uslov;
        }

        protected override void Izvrsi()
        {
            Zaposleni = (repozitorijum.Pretrazi(new Zaposleni(), Uslov)==null?null: (repozitorijum.Pretrazi(new Zaposleni(), Uslov).OfType<Zaposleni>().ToList()).FirstOrDefault());
        }
    }
}
