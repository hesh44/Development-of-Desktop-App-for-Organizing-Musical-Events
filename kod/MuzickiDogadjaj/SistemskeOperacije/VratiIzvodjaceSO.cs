using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class VratiIzvodjaceSO : OpstaSistemskaOperacija
    {
        public List<Izvodjac> Izvodjaci { get; private set; }
        protected override void IzvrsiKonkretnuOperaciju(IObjekat objekat)
        {
            Izvodjaci = new List<Izvodjac>(broker.VratiSve(objekat).Cast<Izvodjac>());
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
