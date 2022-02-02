using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooloskiVrt.Common.Komunikacija
{
    [Serializable]
    public class Zahtev
    {
        public Operacija Operacija { get; set; }
        public object Objekat { get; set; }
    }
}
