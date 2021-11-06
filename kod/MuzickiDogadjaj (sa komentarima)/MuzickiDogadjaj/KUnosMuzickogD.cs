using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domen;

namespace MuzickiDogadjaj
{
    public class KUnosMuzickogD
    {
        internal static Organizator o;
        
        public static Domen.MuzickiDogadjaj muzickiDogadjaj;
        BindingList<Bina> listaBina; 
        private FrmUnosMuzickogD frmUnosMuzickogD;

        public KUnosMuzickogD(FrmUnosMuzickogD frmUnosMuzickogD)
        {
            muzickiDogadjaj = new Domen.MuzickiDogadjaj();
            this.frmUnosMuzickogD = frmUnosMuzickogD;
        }





        internal void srediFormu(ComboBox cmbLokacija, DataGridView dataGridView1, Label lblOrganizator)
        {
            try
            {
                lblOrganizator.Text = o.Ime + " " + o.Prezime;
                cmbLokacija.DataSource = Komunikacija.Instance.vratiLokacije();
                listaBina = new BindingList<Bina>();
                dataGridView1.DataSource = listaBina;
            }
            catch (Exception)
            {
                MessageBox.Show("Server je prekinuo rad");
                frmUnosMuzickogD.Close();
            }
        }




        internal void DodajBinu(TextBox txtNazivBine, TextBox txtSponzor, RadioButton rbDa, ComboBox cmbAudioSistem)
        {
            Bina bina = new Bina();


            if (String.IsNullOrEmpty(txtNazivBine.Text))
            {
                MessageBox.Show("Niste uneli naziv bine!");
                return;
            }
            bina.Naziv = txtNazivBine.Text;

            foreach (Bina bina1 in listaBina)
            {
                if(bina.Naziv == bina1.Naziv)
                {
                    MessageBox.Show("Bina pod ovim nazivom je vec uneta!");
                    return;
                }
            }

            bina.Sponzor = txtSponzor.Text;
            if (String.IsNullOrEmpty(txtSponzor.Text))
            {
                MessageBox.Show("Niste uneli naziv sponzora!");
                return;
            }
            
            
            bina.VIPzona = rbDa.Checked;


            try
            {
                bina.AudioSistem = cmbAudioSistem.SelectedItem.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Niste uneli audio sistem");
                return;
            }



            bina.RB = listaBina.Count() + 1;



            listaBina.Add(bina);


            txtNazivBine.Clear();
            txtSponzor.Clear();
            rbDa.Checked = false;
        }
        internal void ObrisiBinu(DataGridView dataGridView1)
        {
            try
            {
                Bina b = (Bina)dataGridView1.CurrentRow.DataBoundItem;

                listaBina.Remove(b);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }



        internal bool sacuvajMuzickiD(TextBox txtNazivDogadjaja, TextBox txtKapacitet, ComboBox cmbLokacija, Label lblOrganizator, TextBox txtNazivBine)
        {
            try
            {
                if (String.IsNullOrEmpty(txtNazivDogadjaja.Text))
                {
                    MessageBox.Show("Niste uneli naziv muzičkog događaja!");
                    return false;
                }
                muzickiDogadjaj.NazivDogadjaja = txtNazivDogadjaja.Text;

                List<Domen.MuzickiDogadjaj> lista = (List<Domen.MuzickiDogadjaj>)Komunikacija.Instance.vratiMuzickeD();
                foreach (Domen.MuzickiDogadjaj md1 in lista)
                {
                    if(muzickiDogadjaj.NazivDogadjaja.ToLower() == md1.NazivDogadjaja.ToLower())
                    {
                        MessageBox.Show("Vec postoji muzicki dogadjaj pod ovim nazivom!");
                        return false;
                    }
                }

                //try
                //{
                //    muzickiDogadjaj.DatumDogadjaja = Convert.ToDateTime(txtDatumDogadjaja.Text);
                //}
                //catch (Exception)
                //{
                //    MessageBox.Show("Niste uneli datum u odgovarajućem formatu!");
                //    return false;
                //}


                try
                {
                    muzickiDogadjaj.Kapacitet = Convert.ToInt32(txtKapacitet.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Kapacitet mora biti ceo broj!");
                    return false;
                }
                if (muzickiDogadjaj.Kapacitet <= 0)
                {
                    MessageBox.Show("Kapacitet mora biti pozitivan broj!");
                    return false;
                }


                Lokacija lokacija = (Lokacija)cmbLokacija.SelectedItem;
                muzickiDogadjaj.Lokacija = lokacija;

                
                muzickiDogadjaj.Organizator = o;



                muzickiDogadjaj.Bine = listaBina.ToList<Bina>();

                if (muzickiDogadjaj.Bine.Count <= 0)
                {
                    MessageBox.Show("Niste uneli ni jednu binu!");
                    return false;
                }




                    bool uspesno;
                try
                {
                    uspesno = Komunikacija.Instance.DodajMuzickiD(muzickiDogadjaj);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
                if (uspesno)
                {
                    MessageBox.Show("Dodat je muzički događaj po imenu: " + muzickiDogadjaj.NazivDogadjaja);
                    return true;
                }
                else
                {
                    MessageBox.Show("Sistem ne moze da zapamti muzički događaj");
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
    }
}
