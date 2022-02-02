using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooloskiVrt.Server.BrokerBazePodataka
{
    public class Broker
    {
        private SqlConnection connection;
        private SqlTransaction transaction;

        public Broker()
        {
            connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ZooloskiVrt;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        
        public void OtvoriKonekciju()
        {
            connection.Open();
        }
        public void ZatvoriKonekciju()
        {
            connection.Close();
        }
        public void ZapocniTransakciju()
        {
            transaction = connection.BeginTransaction();
        }
        public void Commit()
        {
            transaction.Commit();
        }
        public void Rollback()
        {
            transaction.Rollback();
        }
        public SqlCommand KreirajKomandu()
        {
            return new SqlCommand("", connection, transaction);
        }
    }
}
