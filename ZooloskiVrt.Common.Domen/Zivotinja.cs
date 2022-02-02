using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooloskiVrt.Common.Domen
{
    [Serializable]
    public class Zivotinja : IDomenskiObjekat
    {
        public int IdZivotinje { get; set; }
        public string Vrsta { get; set; }
        public int Pol { get; set; }
        public int Starost { get; set; }
        public string Staniste { get; set; }
        public int TipIshrane { get; set; }

        [Browsable(false)]
        public string NazivTabele => "Zivotinja";
        [Browsable(false)]
        public string Vrednosti => $"'{Vrsta}',{Pol},{Starost},'{Staniste}',{TipIshrane}";
        [Browsable(false)]
        public string Uslov => $"IdZivotinje like={IdZivotinje}";
        [Browsable(false)]
        public string Kolone => "(Vrsta,Pol,Starost,Staniste,TipIshrane)";
        [Browsable(false)]
        public string IdKolona => "IdZivotinje";
        [Browsable(false)]
        public int Id => IdZivotinje;

        public IDomenskiObjekat ProcitajRed(SqlDataReader reader)
        {
            Zivotinja z = new Zivotinja()
            {
                IdZivotinje = (int)reader["IdZivotinje"],
                Vrsta = (string)reader["Vrsta"],
                Pol = (int)reader["Pol"],
                Starost = (int)reader["Starost"],
                Staniste = (string)reader["Staniste"],
                TipIshrane = (int)reader["TipIshrane"]
            };
            return z;
        }
    }
}
