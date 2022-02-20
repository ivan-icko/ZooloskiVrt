using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooloskiVrt.Common.Domen;
using ZooloskiVrt.Server.BrokerBazePodataka;

namespace ZooloskiVrt.Server.Repozitorujum
{
    public class GenerickiRepozitorujum : IRepozitorijum<IDomenskiObjekat>
    {
        private Broker broker = new Broker();
        public void Commit()
        {
            broker.Commit();
        }
        public void Rollback()
        {
            broker.Rollback();
        }
        public void ZapocniTransakciju()
        {
            broker.ZapocniTransakciju();
        }
        public void ZatvoriKonekciju()
        {
            broker.ZatvoriKonekciju();
        }
        public void OtvoriKonekciju()
        {
            broker.OtvoriKonekciju();
        }


        public void Sacuvaj(IDomenskiObjekat obj)
        {
            SqlCommand command = broker.KreirajKomandu();
            command.CommandText = $"insert into {obj.NazivTabele} {obj.Kolone} values ({obj.Vrednosti})";
            command.ExecuteNonQuery();
        }

        public void Azuriraj(IDomenskiObjekat obj)
        {
            SqlCommand command = broker.KreirajKomandu();
            command.CommandText = $"update {obj.NazivTabele} set {obj.Azuriranje} where {obj.Uslov}";
            if (command.ExecuteNonQuery() == 0)
            {
                throw new Exception();
            }
        }

        public List<IDomenskiObjekat> VratiSve(IDomenskiObjekat t)
        {
            List<IDomenskiObjekat> rez = new List<IDomenskiObjekat>();
            SqlCommand command = broker.KreirajKomandu();
            command.CommandText = $"SELECT * FROM {t.NazivTabele} {t.JoinUslov} {t.Uslov}";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    IDomenskiObjekat red = t.ProcitajRed(reader);
                    rez.Add(red);
                }
            }
            return rez;
        }

        public List<IDomenskiObjekat> Pretrazi(IDomenskiObjekat o)
        {
            SqlCommand command = broker.KreirajKomandu();
            command.CommandText = $"select * from {o.NazivTabele} where {o.Uslov}";
            List<IDomenskiObjekat> obj1 = new List<IDomenskiObjekat>() ;
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    obj1.Add(o.ProcitajRed(reader));
                }
            }
            return obj1.Count!=0?obj1:null;
        }

        public void Obrisi(IDomenskiObjekat t)
        {
            SqlCommand command = broker.KreirajKomandu();
            command.CommandText = $"delete from {t.NazivTabele} where {t.Uslov}";
            if (command.ExecuteNonQuery()==0) 
            {
                throw new Exception();
            }
        }










   

        public IDomenskiObjekat IzaberiRed(IDomenskiObjekat obj)
        {
            SqlCommand command = broker.KreirajKomandu();
            command.CommandText = $"select * from {obj.NazivTabele} where {obj.Uslov}";
            IDomenskiObjekat obj1 = null;
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                   obj1=obj.ProcitajRed(reader);
                }
            }
            return obj1;
        }

        public int VratiNajveciId(IDomenskiObjekat t)
        {
            SqlCommand command = broker.KreirajKomandu();
            command.CommandText = $"select max({t.IdKolona}) from {t.NazivTabele}";
            return (int)command.ExecuteScalar();
        }
    }
}
