using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public interface IObjekat
    {
        string VratiImeKlase();
        string VratiVrednostAtributa();
        string VratiUslovZaTrazenje();
        

        string VratiImeID();
        string PostaviVrednostAtributa();


        IObjekat VratiObjekat(SqlDataReader reader);
        List<IObjekat> VratiListu(SqlDataReader reader);
    }
}
