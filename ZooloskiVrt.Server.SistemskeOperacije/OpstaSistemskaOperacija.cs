using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooloskiVrt.Common.Domen;
using ZooloskiVrt.Server.Repozitorujum;

namespace ZooloskiVrt.Server.SistemskeOperacije
{
    public abstract class OpstaSistemskaOperacija
    {
        protected IRepozitorijum<IDomenskiObjekat> repozitorijum = new GenerickiRepozitorujum();
        public void IzvrsiTemplejt()
        {
            try
            {
                repozitorijum.OtvoriKonekciju();
                repozitorijum.ZapocniTransakciju();
                Izvrsi();
                repozitorijum.Commit();

            }
            catch (Exception ex)
            {
                repozitorijum.Rollback();
                Console.WriteLine(ex.Message);
            }
            finally
            {
                repozitorijum.ZatvoriKonekciju();
            }
        }

        protected abstract void Izvrsi();
    }
}
