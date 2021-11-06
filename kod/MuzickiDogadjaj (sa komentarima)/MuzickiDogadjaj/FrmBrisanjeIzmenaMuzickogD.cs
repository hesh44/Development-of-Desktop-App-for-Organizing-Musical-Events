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
    public partial class FrmBrisanjeIzmenaMuzickogD : Form
    {
        KBrisanjeIzmenaMuzickogD kontroler;
        public FrmBrisanjeIzmenaMuzickogD()
        {
            InitializeComponent();
            kontroler = new KBrisanjeIzmenaMuzickogD(this);
        }

        private void FrmBrisanjeIzmenaMuzickogD_Load(object sender, EventArgs e)
        {
            kontroler.srediFormu(cmbMuzickiD, groupBox1, btnObrisi, btnIzmeni, cmbLokacija);
        }

        

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            bool uspelo = kontroler.ObrisiFilm(cmbMuzickiD);
            if (uspelo)
            {
                this.Close();
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;

            MessageBox.Show("Muzicki dogadjaj je spreman za izmenu!");
        }

        private void btnSacuvajIzmenu_Click_1(object sender, EventArgs e)
        {
            bool uspelo = kontroler.SacuvajIzmenuMuzickogD(cmbMuzickiD, txtNazivDogadjaja, txtDatumDogadjaja, txtKapacitet, cmbLokacija);
            if (uspelo)
            {
                this.Close();
            }
        }
    }
}
