using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooloskiVrt.Common.Domen
{
    [Serializable]
    public class PaketZivotinja : IDomenskiObjekat
    {
        public int IdZivotinje { get; set; }
        public int IdPaketa { get; set; }

        public string NazivTabele => "PaketZivotinja";

        public string Vrednosti => $"{IdPaketa},{IdZivotinje}";

        public string Kolone => "(IdPaketa,IdZivotinje)";

        public string Uslov
        {
            get;set;
        }

        public string Azuriranje => throw new NotImplementedException();

        public string JoinUslov { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string IdKolona { get; }

        public IDomenskiObjekat ProcitajRed(SqlDataReader rezultat)
        {
            throw new NotImplementedException();
        }
    }
}
