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
    public class Posetilac : IDomenskiObjekat
    {
        [Browsable(false)]
        public int IdPosetioca { get; set; }
        public string ImeIPrezime { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }

        [Browsable(false)]
        public string NazivTabele => "Posetilac";
        [Browsable(false)]
        public string Vrednosti => $"{IdPosetioca},'{ImeIPrezime}','{Telefon}','{Email}'";
        [Browsable(false)]
        public string Kolone => "(IdPosetioca,ImeIPrezime,Telefon,Email)";
        [Browsable(false)]
        public string Uslov { get; set; }
        [Browsable(false)]
        public string Azuriranje  {get;set;}
        [Browsable(false)]
        public string JoinUslov { get; set; }
        [Browsable(false)]
        public string IdKolona { get; }

        public IDomenskiObjekat ProcitajRed(SqlDataReader reader)
        {
            Posetilac p = new Posetilac()
            {
                IdPosetioca = (int)reader["IdPosetioca"],
                ImeIPrezime = (string)reader["ImeIPrezime"],
                Telefon = (string)reader["Telefon"],
                Email = (string)reader["Email"]
            };
            return p;
        }
    }
}
