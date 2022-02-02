using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooloskiVrt.Common.Domen
{
    public interface IDomenskiObjekat
    {
        string NazivTabele { get; }
        string Vrednosti { get; }
        string Kolone { get; }
        string Uslov { get; }
        string IdKolona { get; }
        int Id { get; }

        IDomenskiObjekat ProcitajRed(SqlDataReader rezultat);
    }
}
