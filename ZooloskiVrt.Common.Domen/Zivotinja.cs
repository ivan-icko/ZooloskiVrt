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
        [Browsable(false)]
        public int IdZivotinje { get; set; }
        public string Vrsta { get; set; }
        public int OznakaZivotinje { get; set; }
        public Pol Pol { get; set; }
        public int Starost { get; set; }
        public string Staniste { get; set; }
        public TipIshrane TipIshrane { get; set; }

        public Zivotinja() { }

        [Browsable(false)]
        public string NazivTabele => "Zivotinja";
        [Browsable(false)]
        public string Vrednosti => $"{OznakaZivotinje},'{Vrsta}','{Pol}',{Starost},'{Staniste}','{TipIshrane}'";
        [Browsable(false)]
        public string Uslov {get;set;}
        [Browsable(false)]
        public string Kolone => "(OznakaZivotinje,Vrsta,Pol,Starost,Staniste,TipIshrane)";
        [Browsable(false)]
        public string Azuriranje => $"OznakaZivotinje={OznakaZivotinje},Vrsta='{Vrsta}',Pol='{Pol}',Starost={Starost},Staniste='{Staniste}',TipIshrane='{TipIshrane}'";

        public string JoinUslov { get; set; }
        public string IdKolona { get; } = "IdZivotinje";

        public Zivotinja(string id,string oznakaZivotinje,string vrsta,string pol, string starost, string staniste, string tipIshrane)
        {
            if (string.IsNullOrEmpty(id)) { id = "%"; }
            if (string.IsNullOrEmpty(oznakaZivotinje)) { oznakaZivotinje = "%"; }
            if (string.IsNullOrEmpty(vrsta)) { vrsta = "%"; }
            if (string.IsNullOrEmpty(pol)) { pol = "%"; }
            if (string.IsNullOrEmpty(starost)) { starost = "%"; }
            if (string.IsNullOrEmpty(staniste)) { staniste = "%"; }
            if (string.IsNullOrEmpty(tipIshrane)) { tipIshrane = "%"; }
            this.Uslov = $"cast(IdZivotinje as nvarchar(10)) like '{id}' and cast(OznakaZivotinje as nvarchar(10)) like '{oznakaZivotinje}' and Vrsta like '{vrsta}' and pol like '{pol}' and cast(Starost as nvarchar(10)) like '{starost}' and Staniste like '{staniste}' and TipIshrane like '{tipIshrane}'";
        }
        
        public IDomenskiObjekat ProcitajRed(SqlDataReader reader)
        {
            Zivotinja z = new Zivotinja()
            {
                IdZivotinje = (int)reader["IdZivotinje"],
                OznakaZivotinje = (int)reader["OznakaZivotinje"],
                Vrsta = (string)reader["Vrsta"],
                Pol = (Pol)Enum.Parse(typeof(Pol),(string)reader["Pol"]),
                Starost = (int)reader["Starost"],
                Staniste = (string)reader["Staniste"],
                TipIshrane = (TipIshrane)Enum.Parse(typeof(TipIshrane), (string)reader["TipIshrane"])
            };
            return z;
        }

        public override bool Equals(object obj)
        {
            return obj is Zivotinja zivotinja &&
                   IdZivotinje == zivotinja.IdZivotinje;
        }
    }
}
