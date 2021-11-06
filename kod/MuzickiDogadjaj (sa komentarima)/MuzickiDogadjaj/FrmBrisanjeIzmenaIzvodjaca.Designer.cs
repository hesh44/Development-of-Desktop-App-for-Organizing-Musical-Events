
namespace MuzickiDogadjaj
{
    partial class FrmBrisanjeIzmenaIzvodjaca
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
            this.txtZanr = new System.Windows.Forms.TextBox();
            this.txtImePrezime = new System.Windows.Forms.TextBox();
            this.txtUmetnickoIme = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSacuvajIzmenu = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbIzvodjac = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtZanr
            // 
            this.txtZanr.Location = new System.Drawing.Point(140, 141);
            this.txtZanr.Margin = new System.Windows.Forms.Padding(4);
            this.txtZanr.Name = "txtZanr";
            this.txtZanr.Size = new System.Drawing.Size(188, 22);
            this.txtZanr.TabIndex = 27;
            // 
            // txtImePrezime
            // 
            this.txtImePrezime.Location = new System.Drawing.Point(140, 95);
            this.txtImePrezime.Margin = new System.Windows.Forms.Padding(4);
            this.txtImePrezime.Name = "txtImePrezime";
            this.txtImePrezime.Size = new System.Drawing.Size(188, 22);
            this.txtImePrezime.TabIndex = 26;
            // 
            // txtUmetnickoIme
            // 
            this.txtUmetnickoIme.Location = new System.Drawing.Point(140, 46);
            this.txtUmetnickoIme.Margin = new System.Windows.Forms.Padding(4);
            this.txtUmetnickoIme.Name = "txtUmetnickoIme";
            this.txtUmetnickoIme.Size = new System.Drawing.Size(188, 22);
            this.txtUmetnickoIme.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 144);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Žanr muzike:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Ime i prezime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Umetničko ime:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSacuvajIzmenu);
            this.groupBox1.Controls.Add(this.txtZanr);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtUmetnickoIme);
            this.groupBox1.Controls.Add(this.txtImePrezime);
            this.groupBox1.Location = new System.Drawing.Point(12, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 252);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Izmena";
            // 
            // btnSacuvajIzmenu
            // 
            this.btnSacuvajIzmenu.Location = new System.Drawing.Point(14, 201);
            this.btnSacuvajIzmenu.Name = "btnSacuvajIzmenu";
            this.btnSacuvajIzmenu.Size = new System.Drawing.Size(326, 34);
            this.btnSacuvajIzmenu.TabIndex = 40;
            this.btnSacuvajIzmenu.Text = "Sacuvaj izmenu";
            this.btnSacuvajIzmenu.UseVisualStyleBackColor = true;
            this.btnSacuvajIzmenu.Click += new System.EventHandler(this.btnSacuvajIzmenu_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(200, 108);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(167, 29);
            this.btnIzmeni.TabIndex = 33;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(26, 108);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(168, 29);
            this.btnObrisi.TabIndex = 32;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 17);
            this.label8.TabIndex = 31;
            this.label8.Text = "Odaberite operaciju:";
            // 
            // cmbIzvodjac
            // 
            this.cmbIzvodjac.FormattingEnabled = true;
            this.cmbIzvodjac.Location = new System.Drawing.Point(200, 21);
            this.cmbIzvodjac.Name = "cmbIzvodjac";
            this.cmbIzvodjac.Size = new System.Drawing.Size(167, 24);
            this.cmbIzvodjac.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 17);
            this.label9.TabIndex = 29;
            this.label9.Text = "Izaberite izvođača:";
            // 
            // FrmBrisanjeIzmenaIzvodjaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 429);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbIzvodjac);
            this.Controls.Add(this.label9);
            this.Name = "FrmBrisanjeIzmenaIzvodjaca";
            this.Text = "Brisanje i izmena izvodjaca";
            this.Load += new System.EventHandler(this.FrmBrisanjeIzmenaIzvodjaca_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtZanr;
        private System.Windows.Forms.TextBox txtImePrezime;
        private System.Windows.Forms.TextBox txtUmetnickoIme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSacuvajIzmenu;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbIzvodjac;
        private System.Windows.Forms.Label label9;
    }
}