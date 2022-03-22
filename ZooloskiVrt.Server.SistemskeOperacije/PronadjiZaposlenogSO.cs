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
            try
            {
                Zaposleni = (repozitorijum.Pretrazi(Zaposleni).OfType<Zaposleni>().ToList()).SingleOrDefault();
            }
            catch (Exception ex)
            {
                Zaposleni = null;
                throw;
            }
        }
    }
}
