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
    public class Prijava : IDomenskiObjekat
    {
        [Browsable(false)]
        public int IdPaketa { get; set; }
        [Browsable(false)]
        public int IdPosetioca { get; set; }
        public DateTime DatumPrijave { get; set; }
        public int BrojOsoba { get; set; }




        public string NazivTabele => "Prijava";

        public string Vrednosti => $"{IdPaketa},{IdPosetioca},'{DatumPrijave}',{BrojOsoba}";

        public string Kolone => "(IdPaketa,IdPosetioca,DatumPrijave,BrojOsoba)";

        public string Uslov { get; set; }

        public string Azuriranje { get; set; }

        public string JoinUslov { get; set; }
        public string IdKolona { get; }

        public override bool Equals(object obj)
        {
            return obj is Prijava prijava &&
                   IdPaketa == prijava.IdPaketa &&
                   IdPosetioca == prijava.IdPosetioca;
        }

        public IDomenskiObjekat ProcitajRed(SqlDataReader reader)
        {
            Prijava p = new Prijava()
            {
                IdPaketa = (int)reader["IdPaketa"],
                IdPosetioca = (int)reader["IdPosetioca"],
                DatumPrijave = (DateTime)reader["DatumPrijave"],
                BrojOsoba = (int)reader["BrojOsoba"]
            };
            return p;
        }

        
    }
}
