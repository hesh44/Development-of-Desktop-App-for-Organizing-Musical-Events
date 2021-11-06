using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domen;

namespace MuzickiDogadjaj
{
    class KUnosIzvodjaca
    {
        internal bool sacuvajIzvodjaca(TextBox txtUmetnickoIme, TextBox txtImePrezime, TextBox txtZanr)
        {
            try
            {
                Izvodjac i = new Izvodjac();

                if (String.IsNullOrEmpty(txtUmetnickoIme.Text))
                {
                    MessageBox.Show("Niste uneli umetnicko ime!");
                    return false;
                }
                i.UmetnickoIme = txtUmetnickoIme.Text;

                List<Izvodjac> lista = (List<Izvodjac>)Komunikacija.Instance.vratiIzvodjace();
                foreach (Izvodjac i1 in lista)
                {
                    if (i.UmetnickoIme.ToLower() == i1.UmetnickoIme.ToLower())
                    {
                        MessageBox.Show("Vec postoji izvodjac pod ovim umetnickim imenom!");
                        return false;
                    }
                }

                if (String.IsNullOrEmpty(txtImePrezime.Text))
                {
                    MessageBox.Show("Niste uneli ime i prezime!");
                    return false;
                }
                i.ImePrezime = txtImePrezime.Text;


                if (String.IsNullOrEmpty(txtZanr.Text))
                {
                    MessageBox.Show("Niste uneli zanr!");
                    return false;
                }
                i.Zanr = txtZanr.Text;
                


                bool uspesno = false;
                try
                {
                    uspesno = Komunikacija.Instance.SacuvajIzvodjaca(i);

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

                if (uspesno)
                {
                    MessageBox.Show("Dodat je novi izvodjac po imenu " + i.UmetnickoIme + " !");
                    return true;
                }
                else
                {
                    MessageBox.Show("Sistem ne moze da zapamti izvodjaca");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
