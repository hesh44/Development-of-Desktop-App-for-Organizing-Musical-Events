using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class SacuvajIzvodjacaSO : OpstaSistemskaOperacija
    {
        public bool Uspelo { get; private set;}
        protected override void IzvrsiKonkretnuOperaciju(IObjekat objekat)
        {
            int id = broker.DajSledeciID(objekat);
            Izvodjac i = (Izvodjac)objekat;
            i.IzvodjacID = id;

            if (broker.Sacuvaj(i) != 1)
            {
                Uspelo = false;
            }
            else
            {
                Uspelo = true;
            }
        }

        protected override void Validacija(IObjekat objekat)
        {
            if (!(objekat is Izvodjac))
            {
                throw new ArgumentException();
            }
        }
    }
}
