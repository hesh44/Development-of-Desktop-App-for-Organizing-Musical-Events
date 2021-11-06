using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    // Abstract method: can only be used in an abstract class, and it does not have a body. The body is provided by the derived class (inherited from).
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
