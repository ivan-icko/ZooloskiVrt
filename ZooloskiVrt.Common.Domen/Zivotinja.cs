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
        public Pol Pol { get; set; }
        public int Starost { get; set; }
        public string Staniste { get; set; }
        public TipIshrane TipIshrane { get; set; }

        public Zivotinja() { }

        [Browsable(false)]
        public string NazivTabele => "Zivotinja";
        [Browsable(false)]
        public string Vrednosti => $"'{Vrsta}','{Pol.ToString()}',{Starost},'{Staniste}','{TipIshrane}'";
        [Browsable(false)]
        public string Uslov {get;set;}
        [Browsable(false)]
        public string Kolone => "(Vrsta,Pol,Starost,Staniste,TipIshrane)";
      

        

        public Zivotinja(string vrsta,string pol, string starost, string staniste, string tipIshrane)
        {
            if (string.IsNullOrEmpty(vrsta)) { vrsta = "%"; }
            if (string.IsNullOrEmpty(starost)) { starost = "%"; }
            if (string.IsNullOrEmpty(staniste)) { staniste = "%"; }
            if (string.IsNullOrEmpty(tipIshrane)) { tipIshrane = "%"; }
            this.Uslov = $"Vrsta like '{vrsta}' and pol like '{pol}' and cast(Starost as nvarchar(10)) like '{starost}' and Staniste like '{staniste}' and TipIshrane like '{tipIshrane}'";
        }
        
        public IDomenskiObjekat ProcitajRed(SqlDataReader reader)
        {
            Zivotinja z = new Zivotinja()
            {
                IdZivotinje = (int)reader["IdZivotinje"],
                Vrsta = (string)reader["Vrsta"],
                Pol = (Pol)Enum.Parse(typeof(Pol),(string)reader["Pol"]),
                Starost = (int)reader["Starost"],
                Staniste = (string)reader["Staniste"],
                TipIshrane = (TipIshrane)Enum.Parse(typeof(TipIshrane), (string)reader["TipIshrane"])
            };
            return z;
        }
    }
}
