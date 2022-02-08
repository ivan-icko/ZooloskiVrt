﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooloskiVrt.Common.Domen
{
    [Serializable]
    public class Paket : IDomenskiObjekat
    {
        [Browsable(false)]
        public int IdPaketa { get; set; }
        public string NazivPaketa { get; set; }
        public double Cena { get; set; }
        public DateTime DatumDo { get; set; }

        public Paket()
        {

        }

        [Browsable(false)]
        public string NazivTabele => "Paket";
        [Browsable(false)]
        public string Vrednosti => $"'{NazivPaketa}',{Cena},'{DatumDo}'";
        [Browsable(false)]
        public string Kolone => "(NazivPaketa,Cena,DatumDo)";
        [Browsable(false)]
        public string Uslov { get; set; }
        [Browsable(false)]
        public string Azuriranje => throw new NotImplementedException();
        [Browsable(false)]
        public string JoinUslov { get; set; }

        public IDomenskiObjekat ProcitajRed(SqlDataReader reader)
        {
            Paket p = new Paket()
            {
                IdPaketa = (int)reader["IdPaketa"],
                NazivPaketa=(string)reader["NazivPaketa"],
                Cena = (double)reader["Cena"],
                DatumDo = (DateTime)reader["DatumDo"]
            };
            return p;
        }

        public Paket(string id, string nazivPaketa, string cena,string datumDo)
        {
            if (string.IsNullOrEmpty(id)) { id = "%"; }
            if (string.IsNullOrEmpty(nazivPaketa)) { nazivPaketa = "%"; }
            if (string.IsNullOrEmpty(cena)) { cena = "%"; }
            if (string.IsNullOrEmpty(datumDo)) {datumDo = "%"; }
          
            this.Uslov = $"cast(IdPaketa as nvarchar(10)) like '{id}' and NazivPaketa like '{nazivPaketa}' cast(Cena as float) like '{cena}' and DatumDo like '{datumDo}'";
        }
    }
}