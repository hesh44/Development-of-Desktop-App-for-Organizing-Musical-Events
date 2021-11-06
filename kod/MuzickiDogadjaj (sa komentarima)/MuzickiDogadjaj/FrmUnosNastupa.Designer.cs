
namespace MuzickiDogadjaj
{
    partial class FrmUnosNastupa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbMuzickiD = new System.Windows.Forms.ComboBox();
            this.cmbBina = new System.Windows.Forms.ComboBox();
            this.cmbIzvodjac = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSacuvajNastup = new System.Windows.Forms.Button();
            this.btnPotvrdiMuzickiD = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTrajanje = new System.Windows.Forms.TextBox();
            this.txtMskdPocetak = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbMuzickiD
            // 
            this.cmbMuzickiD.FormattingEnabled = true;
            this.cmbMuzickiD.Location = new System.Drawing.Point(158, 25);
            this.cmbMuzickiD.Name = "cmbMuzickiD";
            this.cmbMuzickiD.Size = new System.Drawing.Size(205, 24);
            this.cmbMuzickiD.TabIndex = 0;
            // 
            // cmbBina
            // 
            this.cmbBina.FormattingEnabled = true;
            this.cmbBina.Location = new System.Drawing.Point(145, 21);
            this.cmbBina.Name = "cmbBina";
            this.cmbBina.Size = new System.Drawing.Size(205, 24);
            this.cmbBina.TabIndex = 1;
            // 
            // cmbIzvodjac
            // 
            this.cmbIzvodjac.FormattingEnabled = true;
            this.cmbIzvodjac.Location = new System.Drawing.Point(145, 64);
            this.cmbIzvodjac.Name = "cmbIzvodjac";
            this.cmbIzvodjac.Size = new System.Drawing.Size(205, 24);
            this.cmbIzvodjac.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Muzički događaj:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bina:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Izvođač:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Početak nastupa:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Trajanje (minuti):";
            // 
            // btnSacuvajNastup
            // 
            this.btnSacuvajNastup.Location = new System.Drawing.Point(31, 323);
            this.btnSacuvajNastup.Name = "btnSacuvajNastup";
            this.btnSacuvajNastup.Size = new System.Drawing.Size(332, 35);
            this.btnSacuvajNastup.TabIndex = 14;
            this.btnSacuvajNastup.Text = "Sačuvaj nastup";
            this.btnSacuvajNastup.UseVisualStyleBackColor = true;
            this.btnSacuvajNastup.Click += new System.EventHandler(this.btnSacuvajNastup_Click);
            // 
            // btnPotvrdiMuzickiD
            // 
            this.btnPotvrdiMuzickiD.Location = new System.Drawing.Point(31, 64);
            this.btnPotvrdiMuzickiD.Name = "btnPotvrdiMuzickiD";
            this.btnPotvrdiMuzickiD.Size = new System.Drawing.Size(332, 31);
            this.btnPotvrdiMuzickiD.TabIndex = 15;
            this.btnPotvrdiMuzickiD.Text = "Potvrdi muzički događaj";
            this.btnPotvrdiMuzickiD.UseVisualStyleBackColor = true;
            this.btnPotvrdiMuzickiD.Click += new System.EventHandler(this.btnPotvrdiMuzickiD_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTrajanje);
            this.groupBox1.Controls.Add(this.txtMskdPocetak);
            this.groupBox1.Controls.Add(this.cmbBina);
            this.groupBox1.Controls.Add(this.cmbIzvodjac);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(13, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 190);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtTrajanje
            // 
            this.txtTrajanje.Location = new System.Drawing.Point(143, 149);
            this.txtTrajanje.Name = "txtTrajanje";
            this.txtTrajanje.Size = new System.Drawing.Size(207, 22);
            this.txtTrajanje.TabIndex = 18;
            // 
            // txtMskdPocetak
            // 
            this.txtMskdPocetak.Location = new System.Drawing.Point(145, 107);
            this.txtMskdPocetak.Mask = "00.00.0000 00:00";
            this.txtMskdPocetak.Name = "txtMskdPocetak";
            this.txtMskdPocetak.Size = new System.Drawing.Size(205, 22);
            this.txtMskdPocetak.TabIndex = 17;
            this.txtMskdPocetak.ValidatingType = typeof(System.DateTime);
            // 
            // FrmUnosNastupa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 370);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSacuvajNastup);
            this.Controls.Add(this.btnPotvrdiMuzickiD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMuzickiD);
            this.Name = "FrmUnosNastupa";
            this.Text = "Unos nastupa";
            this.Load += new System.EventHandler(this.FrmUnosNastupa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMuzickiD;
        private System.Windows.Forms.ComboBox cmbBina;
        private System.Windows.Forms.ComboBox cmbIzvodjac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSacuvajNastup;
        private System.Windows.Forms.Button btnPotvrdiMuzickiD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtMskdPocetak;
        private System.Windows.Forms.TextBox txtTrajanje;
    }
}