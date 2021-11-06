using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Nastup : IObjekat
    {
        public int NastupID { get; set; }
        public int MuzickiDogadjajID { get; set; }
        public int RB { get; set; }
        public int IzvodjacID { get; set; }
        //public DateTime Datum { get; set; }
        public DateTime PocetkaNastupa { get; set; }
        public DateTime KrajNastupa { get; set; }

        //public string PostaviVrednostAtributa()
        //{
        //    return $"NastupID = {NastupID}, MuzickiDogadjajID = {MuzickiDogadjajID}, RB = {RB}, IzvodjacID = '{IzvodjacID}', Datum = {Datum}, PocetkaNastupa = {PocetkaNastupa}, KrajNastupa = {KrajNastupa}";
        //}
        public string PostaviVrednostAtributa()
        {
            return $"NastupID = {NastupID}, MuzickiDogadjajID = {MuzickiDogadjajID}, RB = {RB}, IzvodjacID = '{IzvodjacID}',  PocetkaNastupa = {PocetkaNastupa}, KrajNastupa = {KrajNastupa}";
        }

        public string VratiImeID()
        {
            return "NastupID";
        }

        public string VratiImeKlase()
        {
            return "Nastup";
        }

        public List<IObjekat> VratiListu(SqlDataReader reader)
        {
            List<IObjekat> nastupi = new List<IObjekat>();
            while (reader.Read())
            {
                Nastup nastup = new Nastup();
                nastup.NastupID = reader.GetInt32(0);
                nastup.MuzickiDogadjajID = reader.GetInt32(1);
                nastup.RB = reader.GetInt32(2);
                nastup.IzvodjacID = reader.GetInt32(3);
                //nastup.Datum = reader.GetDateTime(4);
                try
                {
                    nastup.PocetkaNastupa = Convert.ToDateTime(reader.GetDateTime(4).ToString("yyyy-MM-dd hh:mm:ss"));
                }
                catch (Exception)
                {
                    throw;
                }
                nastup.KrajNastupa = reader.GetDateTime(5);
                nastupi.Add(nastup);
            }
            return nastupi;
        }

        public IObjekat VratiObjekat(SqlDataReader reader)
        {
            IObjekat nastup = null;
            while (reader.Read())
            {
                nastup = new Nastup
                {
                    NastupID = reader.GetInt32(0),
                    MuzickiDogadjajID = reader.GetInt32(1),
                    RB = reader.GetInt32(2),
                    IzvodjacID = reader.GetInt32(3),
                 
                    KrajNastupa = reader.GetDateTime(5)
                };
                try
                {
                    PocetkaNastupa = Convert.ToDateTime(reader.GetDateTime(4).ToString("yyyy-MM-dd hh:mm:ss"));
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return nastup;
        }

        public string VratiUslovZaTrazenje()
        {
           // return $"MuzickiDogadjajID={MuzickiDogadjajID}, RB={RB}, Datum={Datum}, IzvodjacID = {IzvodjacID}";
            return $"MuzickiDogadjajID={MuzickiDogadjajID}, RB={RB}, IzvodjacID = {IzvodjacID}";
        }

        public string VratiVrednostAtributa()
        {
            //return $"{NastupID}, {MuzickiDogadjajID}, {RB}, {IzvodjacID}, '{Datum.ToString("yyyy-MM-dd")}', '{PocetkaNastupa.ToString("yyyy-MM-dd hh:mm")}', '{KrajNastupa.ToString("yyyy-MM-dd hh:mm")}'";
            return $"{NastupID}, {MuzickiDogadjajID}, {RB}, {IzvodjacID},  '{PocetkaNastupa.ToString("yyyy-MM-dd hh:mm:ss")}', '{KrajNastupa.ToString("yyyy-MM-dd hh:mm:ss")}'";
        }
    }
}
