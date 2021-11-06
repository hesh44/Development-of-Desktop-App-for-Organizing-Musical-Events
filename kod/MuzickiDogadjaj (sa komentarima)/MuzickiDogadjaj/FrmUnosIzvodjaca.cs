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
    public partial class FrmUnosIzvodjaca : Form
    {
        KUnosIzvodjaca kontroler;
        public FrmUnosIzvodjaca()
        {
            InitializeComponent();
            kontroler = new KUnosIzvodjaca();
        }

        private void FrmUnosIzvodjaca_Load(object sender, EventArgs e)
        {

        }

        private void btnSacuvajIzvodjaca_Click(object sender, EventArgs e)
        {
            bool uspelo = kontroler.sacuvajIzvodjaca(txtUmetnickoIme, txtImePrezime, txtZanr);
            if (uspelo == true)
            {
                this.Close();
            }
        }
    }
}
