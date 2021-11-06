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
    public class Bina : IObjekat
    {
        [Browsable(false)]
        public int MuzickiDogadjajID { get; set; }
        public int RB { get; set; }
        public string Naziv { get; set; }
        public string Sponzor { get; set; }
        public bool VIPzona { get; set; }
        public string AudioSistem { get; set; }

        public override string ToString()
        {
            return Naziv;
        }

        public string PostaviVrednostAtributa()
        {
            return $"MuzickiDogadjajID = {MuzickiDogadjajID}, RB = {RB}, Naziv = {Naziv}, Sponzor = {Sponzor}, VIPzona = '{VIPzona}', AudioSistem = '{AudioSistem}'";
        }

        public string VratiImeID()
        {
            return "MuzickiDogadjajID";
        }

        public string VratiImeKlase()
        {
            return "Bina";
        }

        public List<IObjekat> VratiListu(SqlDataReader reader)
        {
            List<IObjekat> bine = new List<IObjekat>();
            while (reader.Read())
            {
                Bina bina = new Bina
                {
                    MuzickiDogadjajID = reader.GetInt32(0),
                    RB = reader.GetInt32(1),
                    Naziv = reader.GetString(2),
                    Sponzor = reader.GetString(3),
                    VIPzona = reader.GetBoolean(4),
                    AudioSistem = reader.GetString(5)
                };
                bine.Add(bina);
            }
            return bine;
        }

        public IObjekat VratiObjekat(SqlDataReader reader)
        {
            IObjekat bina = null;
            while (reader.Read())
            {
                bina = new Bina
                {
                    MuzickiDogadjajID = reader.GetInt32(0),
                    RB = reader.GetInt32(1),
                    Naziv = reader.GetString(2),
                    Sponzor = reader.GetString(3),
                    VIPzona = reader.GetBoolean(4),
                    AudioSistem = reader.GetString(5)
                };
            }
            return bina;
        }

        public string VratiUslovZaTrazenje()
        {
            return $"MuzickiDogadjajID = {MuzickiDogadjajID}";
        }

        public string VratiVrednostAtributa()
        {
            return $"{MuzickiDogadjajID}, {RB}, '{Naziv}', '{Sponzor}', {(VIPzona?1:0)}, '{AudioSistem}'";
        }
    }
}
