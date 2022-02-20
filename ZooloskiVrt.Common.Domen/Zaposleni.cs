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
    public class Zaposleni : IDomenskiObjekat
    {
        public int IdZaposlenog { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Sifra { get; set; }

        public Zaposleni() { }
        [Browsable(false)]
        public string NazivTabele => "Zaposleni";
        [Browsable(false)]
        public string Vrednosti => $"{Ime},{Prezime},{KorisnickoIme},{Sifra}";
        [Browsable(false)]
        public string Uslov { get; set; }
        [Browsable(false)]
        public string Kolone => "(Ime,Prezime,KorisnickoIme,Sifra)";

        public string Azuriranje { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string JoinUslov { get; set; }
        [Browsable(false)]
        public string IdKolona { get; } 

        public Zaposleni(string ime, string prezime, string korisnickoIme, string sifra)
        {
            KorisnickoIme = korisnickoIme;
            Sifra = sifra;
            if (string.IsNullOrEmpty(ime)) { ime = "%"; }
            if (string.IsNullOrEmpty(prezime)) { prezime = "%"; }
            if (string.IsNullOrEmpty(korisnickoIme)) { korisnickoIme = "%"; }
            if (string.IsNullOrEmpty(sifra)) { sifra = "%"; }
            this.Uslov = $"Ime like '{ime}' and Prezime like '{prezime}' and KorisnickoIme like '{korisnickoIme}' and Sifra like '{sifra}'";
        }

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

        public override bool Equals(object obj)
        {
            return obj is Zaposleni zaposleni &&
                   IdZaposlenog == zaposleni.IdZaposlenog;
        }
    }
}
