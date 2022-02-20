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
    public class PosetilacPrijava : IDomenskiObjekat
    {
        public string ImeIPrezime { get; set; }
        public string NazivPaketa { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public int BrojOsoba { get; set; }
        public DateTime Datum { get; set; }

        [Browsable(false)]
        public string NazivTabele =>"Posetilac";
        [Browsable(false)]
        public string Vrednosti => $"'{ImeIPrezime}','{NazivPaketa}','{Telefon}','{Email}',{BrojOsoba},'{Datum}";
        [Browsable(false)]
        public string Kolone =>"ImeIPrezime,NazivPaketa,Telefon,Email,BrojOsoba,Datum";
        [Browsable(false)]
        public string Uslov { get; set; }
        [Browsable(false)]
        public string Azuriranje { get; set; }
        [Browsable(false)]
        public string JoinUslov { get; set; }
        [Browsable(false)]
        public string IdKolona { get; }

        public IDomenskiObjekat ProcitajRed(SqlDataReader reader)
        {
            PosetilacPrijava pp = new PosetilacPrijava()
            {
                ImeIPrezime = (string)reader["ImeIPrezime"],
                NazivPaketa=(string)reader["NazivPaketa"],
                Telefon = (string)reader["Telefon"],
                Email = (string)reader["Email"],
                BrojOsoba = (int)reader["BrojOsoba"],
                Datum = (DateTime)reader["DatumPrijave"]
            };
            return pp;
        }
    }
}
