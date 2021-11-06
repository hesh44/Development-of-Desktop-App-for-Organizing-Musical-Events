using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class ObrisiMuzickiDSO : OpstaSistemskaOperacija
    {
        public bool Uspelo { get; private set; }

        protected override void IzvrsiKonkretnuOperaciju(IObjekat objekat)
        {
            if (broker.Obrisi(objekat) != 1)
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
            if (!(objekat is MuzickiDogadjaj))
            {
                throw new ArgumentException();
            }
        }
    }
}
