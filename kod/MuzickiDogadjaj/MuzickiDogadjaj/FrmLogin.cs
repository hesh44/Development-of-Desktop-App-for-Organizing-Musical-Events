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
    public partial class FrmLogin : Form
    {
       
        KLogin kontroler = new KLogin();
        
        public FrmLogin()
        {
            InitializeComponent();
            kontroler.SrediFormu(groupBox1, lblPoruka, btnPoveziSe, lblPokusaj);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool uspelo = kontroler.UlogujSe(txtUsername, txtPassword, lblPokusaj, btnLogin);
            if (uspelo)
            {
                this.Hide();
            }
        }

        private void btnPoveziSe_Click(object sender, EventArgs e)
        {
            kontroler.PokusajPonovo(groupBox1, lblPoruka, btnPoveziSe, lblPokusaj);
        }
    }
}
