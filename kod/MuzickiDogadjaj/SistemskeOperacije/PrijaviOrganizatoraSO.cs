using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace SistemskeOperacije
{
    public class PrijaviOrganizatoraSO : OpstaSistemskaOperacija
    { 
        public Organizator Organizator { get; private set; }

        protected override void IzvrsiKonkretnuOperaciju(IObjekat objekat)
        {
            Organizator = (Organizator)broker.VratiJedan(objekat);
        }

        protected override void Validacija(IObjekat objekat)
        {
            if (!(objekat is Organizator))
            {
                throw new ArgumentException();
            }
        }
    }
}
