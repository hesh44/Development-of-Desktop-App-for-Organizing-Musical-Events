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
    public partial class FrmUnosMuzickogD : Form
    {
        KUnosMuzickogD kontroler;
        public FrmUnosMuzickogD()
        {
            kontroler = new KUnosMuzickogD(this);
            InitializeComponent();
        }

        private void FrmUnosMuzickogD_Load(object sender, EventArgs e)
        {
            kontroler.srediFormu(cmbLokacija, dataGridView1, lblOrganizator);
        }

        private void btnDodajBinu_Click(object sender, EventArgs e)
        {
            kontroler.DodajBinu(txtNazivBine, txtSponzor, rbDa, cmbAudioSistem);
        }

        private void btnObrisiBinu_Click(object sender, EventArgs e)
        {
            kontroler.ObrisiBinu(dataGridView1);
        }

        private void btnSacuvajMuzickiD_Click(object sender, EventArgs e)
        {
            bool uspelo = kontroler.sacuvajMuzickiD(txtNazivDogadjaja, txtKapacitet, cmbLokacija, lblOrganizator, txtNazivBine);
            if (uspelo == true)
            {
                this.Close();
            }
        }
    }
}
