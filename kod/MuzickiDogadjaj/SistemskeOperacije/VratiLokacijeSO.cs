using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class VratiLokacijeSO : OpstaSistemskaOperacija
    {
        public List<Lokacija> Lokacije { get; private set; }
        protected override void IzvrsiKonkretnuOperaciju(IObjekat objekat)
        {
            Lokacije = new List<Lokacija>(broker.VratiSve(objekat).Cast<Lokacija>());
        }

        protected override void Validacija(IObjekat objekat)
        {
            if (!(objekat is Lokacija))
            {
                throw new ArgumentException();
            }
        }
    }
}
