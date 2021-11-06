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
    public partial class FrmUnosNastupa : Form
    {
        KUnosNastupa kontroler;
        
        public FrmUnosNastupa()
        {
            InitializeComponent();
            kontroler = new KUnosNastupa(this);
        }

        private void FrmUnosNastupa_Load(object sender, EventArgs e)
        {
            kontroler.srediFormu(cmbMuzickiD, cmbBina, cmbIzvodjac, groupBox1);
        }
        private void btnPotvrdiMuzickiD_Click(object sender, EventArgs e)
        {
            kontroler.srediFormu2(cmbMuzickiD, btnPotvrdiMuzickiD, groupBox1, cmbBina, cmbIzvodjac);
        }

        private void btnSacuvajNastup_Click(object sender, EventArgs e)
        {
            bool uspelo = kontroler.sacuvajNastup(cmbMuzickiD, cmbBina, cmbIzvodjac, txtMskdPocetak, txtTrajanje);
            if (uspelo)
            {
                this.Close();
            }
        }
    }
}
