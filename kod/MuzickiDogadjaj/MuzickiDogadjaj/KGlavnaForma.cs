using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzickiDogadjaj
{
    public class KGlavnaForma
    {
        public static Organizator o;

        internal void OtvoriZaUnosMuzickogD()
        {
            KUnosMuzickogD.o = o;
            FrmUnosMuzickogD unosMuzickiD = new FrmUnosMuzickogD();
            unosMuzickiD.ShowDialog();
        }

        internal void OtvoriZaIzmenuBrisanjeMuzickogD()
        {
            FrmBrisanjeIzmenaMuzickogD izmenaMuzickiD = new FrmBrisanjeIzmenaMuzickogD();
            izmenaMuzickiD.ShowDialog();
        }

        internal void OtvoriZaUnosIzvodjaca()
        {
            FrmUnosIzvodjaca unosIzvodjaca = new FrmUnosIzvodjaca();
            unosIzvodjaca.ShowDialog();
        }

        internal void OtvoriZaIzmenuBrisanjeIzvodjaca()
        {
            FrmBrisanjeIzmenaIzvodjaca izmenaIzvodjaca = new FrmBrisanjeIzmenaIzvodjaca();
            izmenaIzvodjaca.ShowDialog();
        }

        internal void OtvoriZaUnosNastupa()
        {
            FrmUnosNastupa unosNastupa = new FrmUnosNastupa();
            KUnosNastupa.o = o;
            unosNastupa.ShowDialog();
        }
    }
}
