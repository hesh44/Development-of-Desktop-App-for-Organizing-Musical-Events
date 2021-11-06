
namespace MuzickiDogadjaj
{
    partial class FrmGlavnaForma
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.muzickiDogadjajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmenaBrisanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvodjacToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.izmenaBrisanjeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.unosNastupaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjaviSeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muzickiDogadjajToolStripMenuItem,
            this.izvodjacToolStripMenuItem,
            this.unosNastupaToolStripMenuItem,
            this.odjaviSeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(508, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // muzickiDogadjajToolStripMenuItem
            // 
            this.muzickiDogadjajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosToolStripMenuItem,
            this.izmenaBrisanjeToolStripMenuItem});
            this.muzickiDogadjajToolStripMenuItem.Name = "muzickiDogadjajToolStripMenuItem";
            this.muzickiDogadjajToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.muzickiDogadjajToolStripMenuItem.Text = "Muzički događaj";
            // 
            // unosToolStripMenuItem
            // 
            this.unosToolStripMenuItem.Name = "unosToolStripMenuItem";
            this.unosToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.unosToolStripMenuItem.Text = "Unos";
            this.unosToolStripMenuItem.Click += new System.EventHandler(this.unosToolStripMenuItem_Click);
            // 
            // izmenaBrisanjeToolStripMenuItem
            // 
            this.izmenaBrisanjeToolStripMenuItem.Name = "izmenaBrisanjeToolStripMenuItem";
            this.izmenaBrisanjeToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.izmenaBrisanjeToolStripMenuItem.Text = "Izmena / Brisanje";
            this.izmenaBrisanjeToolStripMenuItem.Click += new System.EventHandler(this.izmenaBrisanjeToolStripMenuItem_Click);
            // 
            // izvodjacToolStripMenuItem
            // 
            this.izvodjacToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosToolStripMenuItem1,
            this.izmenaBrisanjeToolStripMenuItem1});
            this.izvodjacToolStripMenuItem.Name = "izvodjacToolStripMenuItem";
            this.izvodjacToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.izvodjacToolStripMenuItem.Text = "Izvođač";
            // 
            // unosToolStripMenuItem1
            // 
            this.unosToolStripMenuItem1.Name = "unosToolStripMenuItem1";
            this.unosToolStripMenuItem1.Size = new System.Drawing.Size(206, 26);
            this.unosToolStripMenuItem1.Text = "Unos";
            this.unosToolStripMenuItem1.Click += new System.EventHandler(this.unosToolStripMenuItem1_Click);
            // 
            // izmenaBrisanjeToolStripMenuItem1
            // 
            this.izmenaBrisanjeToolStripMenuItem1.Name = "izmenaBrisanjeToolStripMenuItem1";
            this.izmenaBrisanjeToolStripMenuItem1.Size = new System.Drawing.Size(206, 26);
            this.izmenaBrisanjeToolStripMenuItem1.Text = "Brisanje / Izmena";
            this.izmenaBrisanjeToolStripMenuItem1.Click += new System.EventHandler(this.izmenaBrisanjeToolStripMenuItem1_Click);
            // 
            // unosNastupaToolStripMenuItem
            // 
            this.unosNastupaToolStripMenuItem.Name = "unosNastupaToolStripMenuItem";
            this.unosNastupaToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.unosNastupaToolStripMenuItem.Text = "Unos nastupa";
            this.unosNastupaToolStripMenuItem.Click += new System.EventHandler(this.unosNastupaToolStripMenuItem_Click);
            // 
            // odjaviSeToolStripMenuItem
            // 
            this.odjaviSeToolStripMenuItem.Name = "odjaviSeToolStripMenuItem";
            this.odjaviSeToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.odjaviSeToolStripMenuItem.Text = "Odjavi se";
            this.odjaviSeToolStripMenuItem.Click += new System.EventHandler(this.odjaviSeToolStripMenuItem_Click);
            // 
            // FrmGlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 239);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmGlavnaForma";
            this.Text = "Glavna forma";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem muzickiDogadjajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmenaBrisanjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvodjacToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem izmenaBrisanjeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem unosNastupaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odjaviSeToolStripMenuItem;
    }
}