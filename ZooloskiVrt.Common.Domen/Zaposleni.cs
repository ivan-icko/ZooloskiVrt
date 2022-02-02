using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooloskiVrt.Common.Domen
{
    [Serializable]
    public class Zaposleni:IDomenskiObjekat
    {
        public int IdZaposlenog { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Sifra { get; set; }

        public string NazivTabele => "Zaposleni";
        public string Vrednosti => $"{Ime},{Prezime},{KorisnickoIme},{Sifra}";

        public string Uslov => $"KorisnickoIme like '{KorisnickoIme}' and Sifra like '{Sifra}'";

        public string Kolone => throw new NotImplementedException();

        public string IdKolona => throw new NotImplementedException();

        public int Id => throw new NotImplementedException();

        public IDomenskiObjekat ProcitajRed(SqlDataReader reader)
        {
            Zaposleni z = new Zaposleni()
            {
                IdZaposlenog = (int)reader["IdZaposlenog"],
                Ime = (string)reader["Ime"],
                Prezime = (string)reader["Prezime"],
                KorisnickoIme = (string)reader["KorisnickoIme"],
                Sifra = (string)reader["Sifra"]
            };
            return z;
        }
    }
}
