using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuzickiDogadjaj
{
    public partial class FrmBrisanjeIzmenaIzvodjaca : Form
    {
        KBrisanjeIzmenaIzvodjaca kontroler;
        public FrmBrisanjeIzmenaIzvodjaca()
        {
            InitializeComponent();
            kontroler = new KBrisanjeIzmenaIzvodjaca(this);
        }

        private void FrmBrisanjeIzmenaIzvodjaca_Load(object sender, EventArgs e)
        {
            kontroler.srediFormu(cmbIzvodjac, groupBox1);
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            bool uspelo = kontroler.ObrisiIzvodjaca(cmbIzvodjac);
            if (uspelo)
            {
                this.Close();
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            MessageBox.Show("Spremno za izmenu");
        }

        private void btnSacuvajIzmenu_Click(object sender, EventArgs e)
        {
            bool uspelo = kontroler.IzmeniIzvodjaca(cmbIzvodjac, txtImePrezime, txtUmetnickoIme, txtZanr);
            if (uspelo)
            {
                this.Close();
            }
        }
    }
}
