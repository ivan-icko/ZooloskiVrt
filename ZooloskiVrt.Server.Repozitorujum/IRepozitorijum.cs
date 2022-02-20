using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooloskiVrt.Common.Domen;

namespace ZooloskiVrt.Server.Repozitorujum
{
    public interface IRepozitorijum<T> where T: class
    {
        void OtvoriKonekciju();
        void ZapocniTransakciju();
        void Commit();
        void Rollback();
        void ZatvoriKonekciju();


        List<T> VratiSve(T t);
        List<T> Pretrazi(T t);
        void Sacuvaj(T t);
        T IzaberiRed(T t);
        void Azuriraj(T t);
        void Obrisi(T t);
        
        int VratiNajveciId(T t);
    }
}
