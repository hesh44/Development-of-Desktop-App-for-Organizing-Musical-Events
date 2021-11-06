using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuzickiDogadjaj
{
    class KUnosNastupa
    {
        public static Organizator o;

        public static Nastup nastup;
        FrmUnosNastupa frmUnosNastupa;

        public KUnosNastupa(FrmUnosNastupa frmUnosNastupa)
        {
            nastup = new Nastup();
            this.frmUnosNastupa = frmUnosNastupa;
        }

        internal void srediFormu(ComboBox cmbMuzickiD, ComboBox cmbBina, ComboBox cmbIzvodjac, GroupBox groupBox1)
        {
            try
            {
                groupBox1.Enabled = false;
                cmbMuzickiD.DataSource = Komunikacija.Instance.vratiMuzickeD();
            }
            catch (Exception)
            {
                MessageBox.Show("Server je prekinuo rad");
                frmUnosNastupa.Close();
            }
        }

      

        internal void srediFormu2(ComboBox cmbMuzickiD, Button btnPotvrdiMuzickiD, GroupBox groupBox1, ComboBox cmbBina, ComboBox cmbIzvodjac)
        {
            try
            {
                cmbBina.DataSource = Komunikacija.Instance.vratiBineZaOvajMuzickiD(cmbMuzickiD.SelectedItem as Domen.MuzickiDogadjaj);
            }
            catch (Exception)
            {
                MessageBox.Show("Server je prekinuo sa radom i ne mogu da se pronadju bine ovog muzickog dogadjaja");
                frmUnosNastupa.Close();
                return;
            }
            if(cmbBina.Items.Count == 0)
            {
                groupBox1.Enabled = false;
                MessageBox.Show("Ovaj dogadjaj nema unete bine. Izaberite drugi dogadjaj");
                return;
            }
            try
            {
                cmbIzvodjac.DataSource = Komunikacija.Instance.vratiIzvodjace();
            }
            catch (Exception)
            {
                MessageBox.Show("Server je prekinuo sa radom i ne mogu da se pronadju izvodjaci");
                frmUnosNastupa.Close();
                return;
            }

            groupBox1.Enabled = true;
            MessageBox.Show("Sistem je pronasao bine muzickog dogadjaja "+cmbMuzickiD.SelectedItem.ToString());
        }

    
        internal bool sacuvajNastup(ComboBox cmbMuzickiD, ComboBox cmbBina, ComboBox cmbIzvodjac, MaskedTextBox txtMskdPocetak, TextBox txtTrajanje)
        {
            try
            {
                Domen.MuzickiDogadjaj md = (Domen.MuzickiDogadjaj)cmbMuzickiD.SelectedItem;

                nastup.MuzickiDogadjajID = md.MuzickiDogadjajID;
                // ???????????????????
                nastup.RB = (cmbBina.SelectedItem as Bina).RB;
                nastup.IzvodjacID = (cmbIzvodjac.SelectedItem as Izvodjac).IzvodjacID;

                // datum
                //try
                //{
                //    DateTime testDatuma = Convert.ToDateTime(txtMskdDatum.Text);
                //}
                //catch (Exception)
                //{
                //    MessageBox.Show("Datum mora biti u odgovarajucem formatu");
                //    return false;
                //}

                // datum i vreme pocetka 
                try
                {
                   // string vreme = Convert.ToDateTime(txtMskdPocetak.Text).ToString("hh:mm:ss");
                    nastup.PocetkaNastupa = Convert.ToDateTime(txtMskdPocetak.Text );
                }
                catch (Exception)
                {
                    MessageBox.Show("Datum i vreme pocetka nastupa mora biti u odgovarajucem formatu");
                    return false;
                }

                // vreme kraj (dodajem timespan na pocetakNastupa)
                try
                {
                    TimeSpan ts = TimeSpan.FromMinutes(Convert.ToDouble(txtTrajanje.Text)); ;

                    //string vreme = Convert.ToDateTime(txtMskdKraj.Text).ToString("hh:mm:ss"); 
                    //nastup.KrajNastupa = Convert.ToDateTime(txtMskdDatum.Text + " " + vreme);
                    nastup.KrajNastupa = nastup.PocetkaNastupa.Add(ts);
                }
                catch (Exception)
                {
                    MessageBox.Show("Trajanje mora biti u odgovarajucem formatu!");
                    return false;
                }

                //if (nastup.KrajNastupa <= nastup.PocetkaNastupa)
                //{
                //    MessageBox.Show("Kraja nastupa mora biti posle pocetka nastupa");
                //    return false;
                //}

                bool uspesno = Komunikacija.Instance.sacuvajNastup(nastup);
                if (uspesno)
                {
                    MessageBox.Show("Dodat je nov nastup izvodjaca " + cmbIzvodjac.SelectedItem.ToString() + " na dogadjaju " + md.NazivDogadjaja);
                    return uspesno;
                }
                else
                {
                    MessageBox.Show("Sistem ne moze da zapamti nastup!");
                    return uspesno;
                }
            }
            catch (Exception e)
            {
                throw;
                //MessageBox.Show(e.Message);
                return false;
            }
        }
    }
}
