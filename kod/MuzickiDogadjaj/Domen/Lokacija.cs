using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Lokacija : IObjekat
    {

        public int LokacijaID { get; set; }
        public string NazivLokacije { get; set; }
        public string Grad { get; set; }
        public int Povrsina { get; set; }
        public double CenaZakupa { get; set; }
        public string Valuta { get; set; }

        public override string ToString()
        {
            return NazivLokacije;
        }
        public string PostaviVrednostAtributa()
        {
            throw new NotImplementedException();
        }

        public string VratiImeID()
        {
            throw new NotImplementedException();
        }

        public string VratiImeKlase()
        {
            return "Lokacija";
        }

        public List<IObjekat> VratiListu(SqlDataReader reader)
        {
            List<IObjekat> lokacije = new List<IObjekat>();
            while (reader.Read())
            {
                Lokacija lokacija = new Lokacija
                {
                    LokacijaID = reader.GetInt32(0),
                    NazivLokacije = reader.GetString(1),
                    Grad = reader.GetString(2),
                    Povrsina = reader.GetInt32(3),
                    CenaZakupa = reader.GetDouble(4),
                    Valuta = reader.GetString(5)
                };
                lokacije.Add(lokacija);
            }
            return lokacije;
        }

        public IObjekat VratiObjekat(SqlDataReader reader)
        {
            IObjekat lokacija = null;
            while (reader.Read())
            {
                lokacija = new Lokacija
                {
                    LokacijaID = reader.GetInt32(0),
                    NazivLokacije = reader.GetString(1),
                    Grad = reader.GetString(2),
                    Povrsina = reader.GetInt32(3),
                    CenaZakupa = reader.GetDouble(4),
                    Valuta = reader.GetString(5)
                };
            }
            return lokacija;
        }

        public string VratiUslovZaTrazenje()
        {
            return $"LokacijaID = {LokacijaID}";
        }

        public string VratiVrednostAtributa()
        {
            throw new NotImplementedException();
        }
    }
}
