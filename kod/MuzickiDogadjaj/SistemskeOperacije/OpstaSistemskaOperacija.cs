using BrokerBazePodataka;
using Domen;
using System;
using System.Data.SqlClient;
using System.Diagnostics;

namespace SistemskeOperacije
{
     public abstract class OpstaSistemskaOperacija
    {
        protected Broker broker = new Broker();
        protected abstract void IzvrsiKonkretnuOperaciju(IObjekat objekat);
        protected abstract void Validacija(IObjekat objekat);

       public void Izvrsi(IObjekat objekat)
        {
            try
            {
                broker.OtvoriKonekciju();

                Validacija(objekat);


                broker.PokreniTransakciju();
                IzvrsiKonkretnuOperaciju(objekat);
                broker.CommitTransakcije();
            }
            catch (SqlException esql) when (esql.Number == 2601)
            {
                Debug.WriteLine(">>> " + esql.Message);
                broker.RollbackTransakcije();
            }
            catch (Exception)
            {
                broker.RollbackTransakcije();
            }
            finally
            {
                broker.ZatvoriKonekciju();
            }
        }

    }
}
