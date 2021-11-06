using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class MuzickiDogadjaj : IObjekat
    {
        public int MuzickiDogadjajID { get; set; }
        public string NazivDogadjaja { get; set; }
        public int Kapacitet { get; set; }
        public Organizator Organizator { get; set; }
        public Lokacija Lokacija { get; set; }
        public List<Bina> Bine { get; set; }

        public override string ToString()
        {
            return NazivDogadjaja; 
        }

        public MuzickiDogadjaj()
        {
            Bine = new List<Bina>();
        }

        public string VratiImeKlase()
        {
            return "MuzickiDogadjaj";
        }

        public string VratiVrednostAtributa()
        {
            return $"{MuzickiDogadjajID}, '{NazivDogadjaja}',  {Kapacitet}, {Organizator.Id}, '{Lokacija.LokacijaID}'";
        }

        public string VratiUslovZaTrazenje()
        {
            return $"MuzickiDogadjajID = {MuzickiDogadjajID}";
        }

        public string VratiImeID()
        {
            return "MuzickiDogadjajID";
        }

        public string PostaviVrednostAtributa()
        {
            return $"NazivDogadjaja = '{NazivDogadjaja}', Kapacitet = {Kapacitet}, OrganizatorId = {Organizator.Id}, LokacijaId = {Lokacija.LokacijaID}";
        }

        public IObjekat VratiObjekat(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public List<IObjekat> VratiListu(SqlDataReader reader)
        {
            List<IObjekat> muzickiDogadjaji = new List<IObjekat>();

            while (reader.Read())
            {
                MuzickiDogadjaj md = new MuzickiDogadjaj
                {
                    MuzickiDogadjajID = reader.GetInt32(0),
                    NazivDogadjaja = reader.GetString(1),
                    Kapacitet = reader.GetInt32(2),
                };
                md.Organizator = new Organizator();
                md.Organizator.Id = reader.GetInt32(3);
                md.Lokacija = new Lokacija();
                md.Lokacija.LokacijaID = reader.GetInt32(4);

                muzickiDogadjaji.Add(md);
            }
            return muzickiDogadjaji;
        }
    }
}
