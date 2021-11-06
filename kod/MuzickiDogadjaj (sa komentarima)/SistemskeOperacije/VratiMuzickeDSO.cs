using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class VratiMuzickeDSO : OpstaSistemskaOperacija
    {
        public List<MuzickiDogadjaj> MuzickiDogadjaji { get; private set; }
        protected override void IzvrsiKonkretnuOperaciju(IObjekat objekat)
        {
            MuzickiDogadjaji = new List<MuzickiDogadjaj>(broker.VratiSve(objekat).Cast<MuzickiDogadjaj>());
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
