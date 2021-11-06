using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class VratiBineZaOvajMuzickiDSO : OpstaSistemskaOperacija
    {
        public List<Bina> Bine { get; private set; }
       
        protected override void IzvrsiKonkretnuOperaciju(IObjekat objekat)
        {
            MuzickiDogadjaj md = (MuzickiDogadjaj)objekat;
            Bina b = new Bina();
            b.MuzickiDogadjajID = md.MuzickiDogadjajID;
            Bine = new List<Bina>(broker.VratiSveSaUslovom(b).Cast<Bina>());
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
