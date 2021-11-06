
namespace MuzickiDogadjaj
{
    partial class FrmUnosIzvodjaca
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
            this.btnSacuvajIzvodjaca = new System.Windows.Forms.Button();
            this.txtZanr = new System.Windows.Forms.TextBox();
            this.txtImePrezime = new System.Windows.Forms.TextBox();
            this.txtUmetnickoIme = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSacuvajIzvodjaca
            // 
            this.btnSacuvajIzvodjaca.Location = new System.Drawing.Point(24, 166);
            this.btnSacuvajIzvodjaca.Margin = new System.Windows.Forms.Padding(4);
            this.btnSacuvajIzvodjaca.Name = "btnSacuvajIzvodjaca";
            this.btnSacuvajIzvodjaca.Size = new System.Drawing.Size(331, 28);
            this.btnSacuvajIzvodjaca.TabIndex = 21;
            this.btnSacuvajIzvodjaca.Text = "Sačuvaj izvođača";
            this.btnSacuvajIzvodjaca.UseVisualStyleBackColor = true;
            this.btnSacuvajIzvodjaca.Click += new System.EventHandler(this.btnSacuvajIzvodjaca_Click);
            // 
            // txtZanr
            // 
            this.txtZanr.Location = new System.Drawing.Point(129, 117);
            this.txtZanr.Margin = new System.Windows.Forms.Padding(4);
            this.txtZanr.Name = "txtZanr";
            this.txtZanr.Size = new System.Drawing.Size(226, 22);
            this.txtZanr.TabIndex = 19;
            // 
            // txtImePrezime
            // 
            this.txtImePrezime.Location = new System.Drawing.Point(129, 71);
            this.txtImePrezime.Margin = new System.Windows.Forms.Padding(4);
            this.txtImePrezime.Name = "txtImePrezime";
            this.txtImePrezime.Size = new System.Drawing.Size(226, 22);
            this.txtImePrezime.TabIndex = 18;
            // 
            // txtUmetnickoIme
            // 
            this.txtUmetnickoIme.Location = new System.Drawing.Point(129, 22);
            this.txtUmetnickoIme.Margin = new System.Windows.Forms.Padding(4);
            this.txtUmetnickoIme.Name = "txtUmetnickoIme";
            this.txtUmetnickoIme.Size = new System.Drawing.Size(226, 22);
            this.txtUmetnickoIme.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 120);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Žanr muzike:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ime i prezime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Umetničko ime:";
            // 
            // FrmUnosIzvodjaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 217);
            this.Controls.Add(this.btnSacuvajIzvodjaca);
            this.Controls.Add(this.txtZanr);
            this.Controls.Add(this.txtImePrezime);
            this.Controls.Add(this.txtUmetnickoIme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FrmUnosIzvodjaca";
            this.Text = "Unos izvodjaca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSacuvajIzvodjaca;
        private System.Windows.Forms.TextBox txtZanr;
        private System.Windows.Forms.TextBox txtImePrezime;
        private System.Windows.Forms.TextBox txtUmetnickoIme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}