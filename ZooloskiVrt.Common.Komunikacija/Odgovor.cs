using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooloskiVrt.Common.Komunikacija
{

    [Serializable]
   public class Odgovor
    {
        public string Poruka { get; set; }
        public bool Ok { get; set; } = true;
        public object  Rezultat { get; set; }
        public bool KrajRada { get; set; } = false;
        public bool PrikaziPoruku { get; set; } = true;
    }
}
