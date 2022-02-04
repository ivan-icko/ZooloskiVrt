using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooloskiVrt.Common.Domen;

namespace ZooloskiVrt.Server.SistemskeOperacije
{
    public class PronadjiZivotinjuSO : OpstaSistemskaOperacija
    {
        public List<Zivotinja> Zivotinje { get; set; } = null;
        public string Kriterujum { get; set; }
        public PronadjiZivotinjuSO(string kriterujum)
        {
            Kriterujum = kriterujum;
        }

        protected override void Izvrsi()
        {
            Zivotinje = repozitorijum.Pretrazi(new Zivotinja(),Kriterujum).OfType<Zivotinja>().ToList();
        }
    }
}
