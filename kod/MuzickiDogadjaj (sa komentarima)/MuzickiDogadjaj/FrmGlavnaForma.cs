using Domen;
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
    public partial class FrmGlavnaForma : Form
    {
        KGlavnaForma kontoler;
        Organizator o;

        public FrmGlavnaForma()
        {
            InitializeComponent();
            kontoler = new KGlavnaForma();
        }

       
        
        
        // MUZICKI DOGADJAJ
        private void unosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kontoler.OtvoriZaUnosMuzickogD();
        }
        private void izmenaBrisanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kontoler.OtvoriZaIzmenuBrisanjeMuzickogD();
        }



        // IZVODJAC
        private void unosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            kontoler.OtvoriZaUnosIzvodjaca();
        }
        private void izmenaBrisanjeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            kontoler.OtvoriZaIzmenuBrisanjeIzvodjaca();
        }



        // NASTUP
        private void unosNastupaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kontoler.OtvoriZaUnosNastupa();
        }


        // ODJAVI SE
        private void odjaviSeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmLogin().ShowDialog();
        }
    }
}
