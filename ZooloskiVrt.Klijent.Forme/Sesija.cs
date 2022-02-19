using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooloskiVrt.Common.Domen;

namespace ZooloskiVrt.Klijent.Forme
{
    public class Sesija
    {
        private static Sesija instanca;
        private Sesija()
        {

        }
        public static Sesija Instance
        {
            get
            {
                if (instanca == null) instanca = new Sesija(); return instanca;
            }
        }

        //public List<Prijava> Prijave { get; set; }
       
        public List<Zivotinja> ListaZivotinjaUPaketu { get;  set; }
    }
}
