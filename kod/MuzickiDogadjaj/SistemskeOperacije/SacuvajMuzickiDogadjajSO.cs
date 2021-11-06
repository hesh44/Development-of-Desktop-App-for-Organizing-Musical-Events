using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class SacuvajMuzickiDogadjajSO : OpstaSistemskaOperacija
    {
        public bool Uspelo { get; private set; }

        protected override void IzvrsiKonkretnuOperaciju(IObjekat objekat)
        {
            MuzickiDogadjaj md = (MuzickiDogadjaj)objekat;
            int id = broker.DajSledeciID(objekat);
            md.MuzickiDogadjajID = id;
            if (broker.Sacuvaj(objekat) != 1)
            {
                Uspelo = false;
            }
            else
            {
                Uspelo = true;
            }

            if (Uspelo == true)
            {
                foreach (Bina b in md.Bine)
                {
                    b.MuzickiDogadjajID = id;
                    if (broker.Sacuvaj(b) != 1)
                    {
                        Uspelo = false;
                    }
                    else
                    {
                        Uspelo = true;
                    }
                }
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
