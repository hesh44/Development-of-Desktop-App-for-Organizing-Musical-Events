using BrokerBazePodataka;
using Domen;
using System;
using System.Data.SqlClient;
using System.Diagnostics;

namespace SistemskeOperacije
{
    // Abstract class: is a restricted class that cannot be used to create objects (to access it, it must be inherited from another class).
    // OSO sadrzi opste stvari vezana za brokera, npr:  inicijalizacija njegova, otvori kon, pokreni trans, i commit; dok validacija i izvrsi konkretnu operaciju zavise od objekta koji ce mu biti prosledjen, i one su overrajdovane u SO objekata
    public abstract class OpstaSistemskaOperacija
    {
        protected Broker broker = new Broker();
        //Abstract method: can only be used in an abstract class, and it does not have a body. The body is provided by the derived class (inherited from).
        protected abstract void IzvrsiKonkretnuOperaciju(IObjekat objekat);
        protected abstract void Validacija(IObjekat objekat);

        // pozivamo opste izvrsi koja je opsta sistemska operacija
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
                //System.Windows.Forms.MessageBox.Show(esql.Message);
                Debug.WriteLine(">>> " + esql.Message);
                broker.RollbackTransakcije();
            }
            catch (Exception ex)
            {
                //Debug.WriteLine(">>> " + ex.Message);
                broker.RollbackTransakcije();
            }
            finally
            {
                broker.ZatvoriKonekciju();
            }
        }

    }
}
