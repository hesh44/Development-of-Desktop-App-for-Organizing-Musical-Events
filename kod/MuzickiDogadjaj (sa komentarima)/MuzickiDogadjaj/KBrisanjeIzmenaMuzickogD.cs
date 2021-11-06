using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuzickiDogadjaj
{
    public class KBrisanjeIzmenaMuzickogD
    {
        private FrmBrisanjeIzmenaMuzickogD frmBrisanjeIzmenaMuzickogD;

        public KBrisanjeIzmenaMuzickogD(FrmBrisanjeIzmenaMuzickogD frmBrisanjeIzmenaMuzickogD)
        {
            this.frmBrisanjeIzmenaMuzickogD = frmBrisanjeIzmenaMuzickogD;
        }


        internal void srediFormu(System.Windows.Forms.ComboBox cmbMuzickiD, GroupBox groupBox1, Button btnObrisi, Button btnIzmeni, ComboBox cmbLokacija)
        {
            groupBox1.Enabled = false;

            try
            {
                cmbMuzickiD.DataSource = Komunikacija.Instance.vratiMuzickeD();
                cmbLokacija.DataSource = Komunikacija.Instance.vratiLokacije();
            }
            catch (Exception)
            {
                MessageBox.Show("Server je prekinuo rad i ne moze da pronadje muzicke dogadjaje ");
                frmBrisanjeIzmenaMuzickogD.Close();
            }
        }

        internal bool ObrisiFilm(ComboBox cmbMuzickiD)
        {
            try
            {
                if (cmbMuzickiD.SelectedIndex < 0)
                {
                    MessageBox.Show("Izaberite muzicki dogadjaj za brisanje!");
                    return false;
                }

                Domen.MuzickiDogadjaj md = (Domen.MuzickiDogadjaj)cmbMuzickiD.SelectedItem;
                bool uspelo;
                try
                {
                    uspelo = Komunikacija.Instance.ObrisiMuzickiD(md);

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
                if (uspelo)
                {
                    MessageBox.Show($"Obrisan je muzicki dogadjaj po imenu: {md.NazivDogadjaja} kao i njegove bine");
                    return true;
                }
                else
                {
                    MessageBox.Show("Sistem ne moze da obrise muzicki dogadjaj!");
                    return false;
                }
            }
            catch (Exception)
            {
                throw new Exception("Greska pri brisanju");
            }
        }

    
        internal bool SacuvajIzmenuMuzickogD(ComboBox cmbMuzickiD, TextBox txtNazivDogadjaja, TextBox txtDatumDogadjaja, TextBox txtKapacitet, ComboBox cmbLokacija)
        {
            try
            {
                if (cmbMuzickiD.SelectedIndex < 0)
                {
                    MessageBox.Show("Izaberite muzicki dogadjaj koji zelite da izmenite");
                    return false;
                }

                Domen.MuzickiDogadjaj md = (Domen.MuzickiDogadjaj)cmbMuzickiD.SelectedItem;

                if (!String.IsNullOrEmpty(txtNazivDogadjaja.Text))
                {
                    md.NazivDogadjaja = txtNazivDogadjaja.Text;
                }
                //try
                //{
                //    md.DatumDogadjaja = Convert.ToDateTime(txtDatumDogadjaja.Text);
                //}
                //catch (Exception)
                //{
                //    MessageBox.Show("Datum nije u odgovarajucem formatu");
                //    return false;
                //}
                try
                {
                    md.Kapacitet = Convert.ToInt32(txtKapacitet.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Kapacitet mora biti tipa integer");
                    return false;
                }
                if (cmbLokacija.SelectedIndex < 0)
                {
                    MessageBox.Show("Niste uneli lokaciju");
                    return false;
                }
               
               


                bool uspelo;
                try
                {
                    uspelo = Komunikacija.Instance.SacuvajIzmenuMuzickogD(md);

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
                if (uspelo)
                {
                    MessageBox.Show($"Napravljene su izmene nad muzickim dogadjajem: {md.NazivDogadjaja}");
                    return true;
                }
                else
                {
                    MessageBox.Show("Nije moguce sacuvati izmene nad muzickim dogadjajem.");
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
