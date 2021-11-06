using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Izvodjac : IObjekat
    {
        public int IzvodjacID { get; set; }
        public string UmetnickoIme { get; set; }
        public string ImePrezime { get; set; }
        public string Zanr { get; set; }

        public override string ToString()
        {
            return UmetnickoIme;
        }
        public string PostaviVrednostAtributa()
        {
            return $"UmetnickoIme = '{UmetnickoIme}', ImePrezime = '{ImePrezime}', Zanr = '{Zanr}'";
        }

        public string VratiImeID()
        {
            return "IzvodjacID";
        }

        public string VratiImeKlase()
        {
            return "Izvodjac";
        }

        public List<IObjekat> VratiListu(SqlDataReader reader)
        {
            List<IObjekat> izvodjaci = new List<IObjekat>();
            while (reader.Read())
            {
                Izvodjac izvodjac = new Izvodjac
                {
                    IzvodjacID = reader.GetInt32(0),
                    UmetnickoIme = reader.GetString(1),
                    ImePrezime = reader.GetString(2),
                    Zanr = reader.GetString(3)

                };
                izvodjaci.Add(izvodjac);
            }
            return izvodjaci;
        }

        public IObjekat VratiObjekat(SqlDataReader reader)
        {
            IObjekat izvodjac = null;
            while (reader.Read())
            {
                izvodjac = new Izvodjac
                {
                    IzvodjacID = reader.GetInt32(0),
                    UmetnickoIme = reader.GetString(1),
                    ImePrezime = reader.GetString(2),
                    Zanr = reader.GetString(3)

                };
            }
            return izvodjac;
        }

        public string VratiUslovZaTrazenje()
        {
            return $"IzvodjacID = {IzvodjacID}";
        }

        public string VratiVrednostAtributa()
        {
            return $"{IzvodjacID}, '{UmetnickoIme}', '{ImePrezime}', '{Zanr}'"; 
        }
    }
}
