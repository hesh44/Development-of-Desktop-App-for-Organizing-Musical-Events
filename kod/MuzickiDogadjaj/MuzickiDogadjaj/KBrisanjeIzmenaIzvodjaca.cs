using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuzickiDogadjaj
{
    class KBrisanjeIzmenaIzvodjaca
    {
        private FrmBrisanjeIzmenaIzvodjaca frmBrisanjeIzmenaIzvodjaca;

        public KBrisanjeIzmenaIzvodjaca(FrmBrisanjeIzmenaIzvodjaca frmBrisanjeIzmenaIzvodjaca)
        {
            this.frmBrisanjeIzmenaIzvodjaca = frmBrisanjeIzmenaIzvodjaca;
        }

        internal void srediFormu(ComboBox cmbIzvodjac, GroupBox groupBox1)
        {
            groupBox1.Enabled = false;
            try
            {
                cmbIzvodjac.DataSource = Komunikacija.Instance.vratiIzvodjace();

            }
            catch (Exception)
            {
                MessageBox.Show("Server je prekinuo rad i ne moze da pronadje izvodjace!");
                frmBrisanjeIzmenaIzvodjaca.Close();
            }
        }

        internal bool ObrisiIzvodjaca(ComboBox cmbIzvodjac)
        {
            try
            {
                if (cmbIzvodjac.SelectedIndex < 0)
                {
                    MessageBox.Show("Izaberite izvodjaca koga zelite da obrisete!");
                    return false;
                }

                Izvodjac i = (Izvodjac)cmbIzvodjac.SelectedItem;



                bool uspesno;
                try
                {
                    uspesno = Komunikacija.Instance.ObrisiIzvodjaca(i);

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
                if (uspesno)
                {
                    MessageBox.Show($"Obrisan je izvodjac po imenu: {i.UmetnickoIme}!");
                    return true;
                }
                else
                {
                    MessageBox.Show("Sistem ne moze da obrise izvodjaca");
                    return false;
                }
            }
            catch (Exception)
            {

                throw new Exception("Greska pri brisanju");
            }
        }

        internal bool IzmeniIzvodjaca(ComboBox cmbIzvodjac, TextBox txtImePrezime, TextBox txtUmetnickoIme, TextBox txtZanr)
        {
            try
            {
                if (cmbIzvodjac.SelectedIndex < 0)
                {
                    MessageBox.Show("Izaberite izvodjaca koga zelite da izmenite!");
                    return false;
                }


                Izvodjac i = (Izvodjac)cmbIzvodjac.SelectedItem;

                if (!String.IsNullOrEmpty(txtImePrezime.Text))
                {
                    i.ImePrezime = txtImePrezime.Text;
                }
                if (!String.IsNullOrEmpty(txtUmetnickoIme.Text))
                {
                    i.UmetnickoIme = txtUmetnickoIme.Text;
                }
                if (!String.IsNullOrEmpty(txtZanr.Text))
                {
                    i.Zanr = txtZanr.Text;
                }




                bool uspesno;
                try
                {
                    uspesno = Komunikacija.Instance.IzmeniIzvodjaca(i);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
                if (uspesno)
                {
                    MessageBox.Show($"Napravljene su izmene nad izvodjacem: {i.UmetnickoIme} !");
                    return true;
                }
                else
                {
                    MessageBox.Show("Nije moguce sacuvati izmene izvodjaca.");
                    return false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
