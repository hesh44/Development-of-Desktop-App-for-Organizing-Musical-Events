
namespace MuzickiDogadjaj
{
    partial class FrmUnosMuzickogD
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSacuvajMuzickiD = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNe = new System.Windows.Forms.RadioButton();
            this.rbDa = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.btnObrisiBinu = new System.Windows.Forms.Button();
            this.btnDodajBinu = new System.Windows.Forms.Button();
            this.txtNazivBine = new System.Windows.Forms.TextBox();
            this.txtSponzor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbAudioSistem = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNazivDogadjaja = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOrganizator = new System.Windows.Forms.Label();
            this.txtKapacitet = new System.Windows.Forms.TextBox();
            this.cmbLokacija = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 237);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(389, 143);
            this.dataGridView1.TabIndex = 29;
            // 
            // btnSacuvajMuzickiD
            // 
            this.btnSacuvajMuzickiD.Location = new System.Drawing.Point(12, 602);
            this.btnSacuvajMuzickiD.Margin = new System.Windows.Forms.Padding(4);
            this.btnSacuvajMuzickiD.Name = "btnSacuvajMuzickiD";
            this.btnSacuvajMuzickiD.Size = new System.Drawing.Size(418, 39);
            this.btnSacuvajMuzickiD.TabIndex = 28;
            this.btnSacuvajMuzickiD.Text = "Sačuvaj muzički događaj";
            this.btnSacuvajMuzickiD.UseVisualStyleBackColor = true;
            this.btnSacuvajMuzickiD.Click += new System.EventHandler(this.btnSacuvajMuzickiD_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNe);
            this.groupBox1.Controls.Add(this.rbDa);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnObrisiBinu);
            this.groupBox1.Controls.Add(this.btnDodajBinu);
            this.groupBox1.Controls.Add(this.txtNazivBine);
            this.groupBox1.Controls.Add(this.txtSponzor);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmbAudioSistem);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(13, 196);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(417, 397);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unos bine:";
            // 
            // rbNe
            // 
            this.rbNe.AutoSize = true;
            this.rbNe.Checked = true;
            this.rbNe.Location = new System.Drawing.Point(197, 103);
            this.rbNe.Name = "rbNe";
            this.rbNe.Size = new System.Drawing.Size(47, 21);
            this.rbNe.TabIndex = 32;
            this.rbNe.TabStop = true;
            this.rbNe.Text = "Ne";
            this.rbNe.UseVisualStyleBackColor = true;
            // 
            // rbDa
            // 
            this.rbDa.AutoSize = true;
            this.rbDa.Location = new System.Drawing.Point(147, 103);
            this.rbDa.Name = "rbDa";
            this.rbDa.Size = new System.Drawing.Size(47, 21);
            this.rbDa.TabIndex = 31;
            this.rbDa.Text = "Da";
            this.rbDa.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 141);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "Audio sistem:";
            // 
            // btnObrisiBinu
            // 
            this.btnObrisiBinu.Location = new System.Drawing.Point(220, 184);
            this.btnObrisiBinu.Margin = new System.Windows.Forms.Padding(4);
            this.btnObrisiBinu.Name = "btnObrisiBinu";
            this.btnObrisiBinu.Size = new System.Drawing.Size(183, 36);
            this.btnObrisiBinu.TabIndex = 7;
            this.btnObrisiBinu.Text = "Obriši binu";
            this.btnObrisiBinu.UseVisualStyleBackColor = true;
            this.btnObrisiBinu.Click += new System.EventHandler(this.btnObrisiBinu_Click);
            // 
            // btnDodajBinu
            // 
            this.btnDodajBinu.Location = new System.Drawing.Point(14, 184);
            this.btnDodajBinu.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajBinu.Name = "btnDodajBinu";
            this.btnDodajBinu.Size = new System.Drawing.Size(180, 36);
            this.btnDodajBinu.TabIndex = 6;
            this.btnDodajBinu.Text = "Dodaj binu";
            this.btnDodajBinu.UseVisualStyleBackColor = true;
            this.btnDodajBinu.Click += new System.EventHandler(this.btnDodajBinu_Click);
            // 
            // txtNazivBine
            // 
            this.txtNazivBine.Location = new System.Drawing.Point(142, 26);
            this.txtNazivBine.Margin = new System.Windows.Forms.Padding(4);
            this.txtNazivBine.Name = "txtNazivBine";
            this.txtNazivBine.Size = new System.Drawing.Size(240, 22);
            this.txtNazivBine.TabIndex = 5;
            // 
            // txtSponzor
            // 
            this.txtSponzor.Location = new System.Drawing.Point(142, 66);
            this.txtSponzor.Margin = new System.Windows.Forms.Padding(4);
            this.txtSponzor.Name = "txtSponzor";
            this.txtSponzor.Size = new System.Drawing.Size(240, 22);
            this.txtSponzor.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(54, 103);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "Vip zona:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(56, 67);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Sponzor:";
            // 
            // cmbAudioSistem
            // 
            this.cmbAudioSistem.FormattingEnabled = true;
            this.cmbAudioSistem.Items.AddRange(new object[] {
            "Adamson",
            "Bose",
            "JBL",
            "Void Acustics",
            "Martin Audio",
            "Primavera Sound",
            "Bowers & Wilkins"});
            this.cmbAudioSistem.Location = new System.Drawing.Point(142, 138);
            this.cmbAudioSistem.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAudioSistem.Name = "cmbAudioSistem";
            this.cmbAudioSistem.Size = new System.Drawing.Size(240, 24);
            this.cmbAudioSistem.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 27);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Naziv:";
            // 
            // txtNazivDogadjaja
            // 
            this.txtNazivDogadjaja.Location = new System.Drawing.Point(151, 53);
            this.txtNazivDogadjaja.Margin = new System.Windows.Forms.Padding(4);
            this.txtNazivDogadjaja.Name = "txtNazivDogadjaja";
            this.txtNazivDogadjaja.Size = new System.Drawing.Size(240, 22);
            this.txtNazivDogadjaja.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Organizator:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 137);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Lokacija:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Kapacitet:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Naziv događaja:";
            // 
            // lblOrganizator
            // 
            this.lblOrganizator.AutoSize = true;
            this.lblOrganizator.Location = new System.Drawing.Point(152, 20);
            this.lblOrganizator.Name = "lblOrganizator";
            this.lblOrganizator.Size = new System.Drawing.Size(0, 17);
            this.lblOrganizator.TabIndex = 29;
            // 
            // txtKapacitet
            // 
            this.txtKapacitet.Location = new System.Drawing.Point(151, 92);
            this.txtKapacitet.Margin = new System.Windows.Forms.Padding(4);
            this.txtKapacitet.Name = "txtKapacitet";
            this.txtKapacitet.Size = new System.Drawing.Size(240, 22);
            this.txtKapacitet.TabIndex = 30;
            // 
            // cmbLokacija
            // 
            this.cmbLokacija.FormattingEnabled = true;
            this.cmbLokacija.Location = new System.Drawing.Point(150, 132);
            this.cmbLokacija.Margin = new System.Windows.Forms.Padding(4);
            this.cmbLokacija.Name = "cmbLokacija";
            this.cmbLokacija.Size = new System.Drawing.Size(240, 24);
            this.cmbLokacija.TabIndex = 31;
            // 
            // FrmUnosMuzickogD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 649);
            this.Controls.Add(this.cmbLokacija);
            this.Controls.Add(this.txtKapacitet);
            this.Controls.Add(this.lblOrganizator);
            this.Controls.Add(this.btnSacuvajMuzickiD);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNazivDogadjaja);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "FrmUnosMuzickogD";
            this.Text = "Unos muzickog dogadjaja";
            this.Load += new System.EventHandler(this.FrmUnosMuzickogD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSacuvajMuzickiD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnObrisiBinu;
        private System.Windows.Forms.Button btnDodajBinu;
        private System.Windows.Forms.TextBox txtNazivBine;
        private System.Windows.Forms.TextBox txtSponzor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbAudioSistem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNazivDogadjaja;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOrganizator;
        private System.Windows.Forms.TextBox txtKapacitet;
        private System.Windows.Forms.RadioButton rbDa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbLokacija;
        private System.Windows.Forms.RadioButton rbNe;
    }
}