using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class SacuvajNastupSO : OpstaSistemskaOperacija
    {
        public bool Uspelo { get; private set; }
        
        protected override void IzvrsiKonkretnuOperaciju(IObjekat objekat)
        {
            Nastup n = (Nastup)objekat;

            int id = broker.DajSledeciID(objekat);
            n.NastupID = id;
            if (broker.Sacuvaj(objekat) != 1)
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
            if (!(objekat is Nastup))
            {
                throw new ArgumentException();
            }
        }
    }
}
