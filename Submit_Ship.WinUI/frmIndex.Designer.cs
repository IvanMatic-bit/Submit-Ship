
namespace Submit_Ship.WinUI
{
    partial class frmIndex
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.uslugaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaUslugaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.državaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adresaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.novaAdresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kamionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaKamionaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviKamionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zahtjevToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaZahtjevaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaKvarovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.isporukaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaIsporukaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.korisnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviKorisnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvještajiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kamionKvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korisnikIsporukeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.uslugeZaradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uslugaToolStripMenuItem,
            this.adresaToolStripMenuItem,
            this.kamionToolStripMenuItem,
            this.zahtjevToolStripMenuItem,
            this.kvarToolStripMenuItem,
            this.isporukaToolStripMenuItem,
            this.korisnikToolStripMenuItem,
            this.izvještajiToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1051, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // uslugaToolStripMenuItem
            // 
            this.uslugaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem,
            this.novaUslugaToolStripMenuItem});
            this.uslugaToolStripMenuItem.Name = "uslugaToolStripMenuItem";
            this.uslugaToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.uslugaToolStripMenuItem.Text = "Usluga";
            // 
            // pretragaToolStripMenuItem
            // 
            this.pretragaToolStripMenuItem.Name = "pretragaToolStripMenuItem";
            this.pretragaToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.pretragaToolStripMenuItem.Text = "Pretraga";
            this.pretragaToolStripMenuItem.Click += new System.EventHandler(this.pretragaToolStripMenuItem_Click);
            // 
            // novaUslugaToolStripMenuItem
            // 
            this.novaUslugaToolStripMenuItem.Name = "novaUslugaToolStripMenuItem";
            this.novaUslugaToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.novaUslugaToolStripMenuItem.Text = "Nova usluga";
            this.novaUslugaToolStripMenuItem.Click += new System.EventHandler(this.novaUslugaToolStripMenuItem_Click);
            // 
            // adresaToolStripMenuItem
            // 
            this.adresaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.državaToolStripMenuItem,
            this.gradToolStripMenuItem,
            this.adresaToolStripMenuItem1,
            this.novaAdresaToolStripMenuItem});
            this.adresaToolStripMenuItem.Name = "adresaToolStripMenuItem";
            this.adresaToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adresaToolStripMenuItem.Text = "Adresa";
            // 
            // državaToolStripMenuItem
            // 
            this.državaToolStripMenuItem.Name = "državaToolStripMenuItem";
            this.državaToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.državaToolStripMenuItem.Text = "Država";
            this.državaToolStripMenuItem.Click += new System.EventHandler(this.državaToolStripMenuItem_Click);
            // 
            // gradToolStripMenuItem
            // 
            this.gradToolStripMenuItem.Name = "gradToolStripMenuItem";
            this.gradToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.gradToolStripMenuItem.Text = "Grad";
            this.gradToolStripMenuItem.Click += new System.EventHandler(this.gradToolStripMenuItem_Click);
            // 
            // adresaToolStripMenuItem1
            // 
            this.adresaToolStripMenuItem1.Name = "adresaToolStripMenuItem1";
            this.adresaToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.adresaToolStripMenuItem1.Text = "Adresa";
            this.adresaToolStripMenuItem1.Click += new System.EventHandler(this.adresaToolStripMenuItem1_Click);
            // 
            // novaAdresaToolStripMenuItem
            // 
            this.novaAdresaToolStripMenuItem.Name = "novaAdresaToolStripMenuItem";
            this.novaAdresaToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.novaAdresaToolStripMenuItem.Text = "Nova adresa";
            this.novaAdresaToolStripMenuItem.Click += new System.EventHandler(this.novaAdresaToolStripMenuItem_Click);
            // 
            // kamionToolStripMenuItem
            // 
            this.kamionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaKamionaToolStripMenuItem,
            this.noviKamionToolStripMenuItem});
            this.kamionToolStripMenuItem.Name = "kamionToolStripMenuItem";
            this.kamionToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.kamionToolStripMenuItem.Text = "Kamion";
            // 
            // pretragaKamionaToolStripMenuItem
            // 
            this.pretragaKamionaToolStripMenuItem.Name = "pretragaKamionaToolStripMenuItem";
            this.pretragaKamionaToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.pretragaKamionaToolStripMenuItem.Text = "Pretraga kamiona";
            this.pretragaKamionaToolStripMenuItem.Click += new System.EventHandler(this.pretragaKamionaToolStripMenuItem_Click);
            // 
            // noviKamionToolStripMenuItem
            // 
            this.noviKamionToolStripMenuItem.Name = "noviKamionToolStripMenuItem";
            this.noviKamionToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.noviKamionToolStripMenuItem.Text = "Novi kamion";
            this.noviKamionToolStripMenuItem.Click += new System.EventHandler(this.noviKamionToolStripMenuItem_Click);
            // 
            // zahtjevToolStripMenuItem
            // 
            this.zahtjevToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaZahtjevaToolStripMenuItem});
            this.zahtjevToolStripMenuItem.Name = "zahtjevToolStripMenuItem";
            this.zahtjevToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.zahtjevToolStripMenuItem.Text = "Zahtjev";
            // 
            // pretragaZahtjevaToolStripMenuItem
            // 
            this.pretragaZahtjevaToolStripMenuItem.Name = "pretragaZahtjevaToolStripMenuItem";
            this.pretragaZahtjevaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.pretragaZahtjevaToolStripMenuItem.Text = "Pretraga zahtjeva";
            this.pretragaZahtjevaToolStripMenuItem.Click += new System.EventHandler(this.pretragaZahtjevaToolStripMenuItem_Click);
            // 
            // kvarToolStripMenuItem
            // 
            this.kvarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaKvarovaToolStripMenuItem});
            this.kvarToolStripMenuItem.Name = "kvarToolStripMenuItem";
            this.kvarToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.kvarToolStripMenuItem.Text = "Kvar";
            // 
            // pretragaKvarovaToolStripMenuItem
            // 
            this.pretragaKvarovaToolStripMenuItem.Name = "pretragaKvarovaToolStripMenuItem";
            this.pretragaKvarovaToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.pretragaKvarovaToolStripMenuItem.Text = "Pretraga kvarova";
            this.pretragaKvarovaToolStripMenuItem.Click += new System.EventHandler(this.pretragaKvarovaToolStripMenuItem_Click);
            // 
            // isporukaToolStripMenuItem
            // 
            this.isporukaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaIsporukaToolStripMenuItem,
            this.toolStripMenuItem1});
            this.isporukaToolStripMenuItem.Name = "isporukaToolStripMenuItem";
            this.isporukaToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.isporukaToolStripMenuItem.Text = "Isporuka";
            // 
            // pretragaIsporukaToolStripMenuItem
            // 
            this.pretragaIsporukaToolStripMenuItem.Name = "pretragaIsporukaToolStripMenuItem";
            this.pretragaIsporukaToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.pretragaIsporukaToolStripMenuItem.Text = "Pretraga isporuka";
            this.pretragaIsporukaToolStripMenuItem.Click += new System.EventHandler(this.pretragaIsporukaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.toolStripMenuItem1.Text = "Nova isporuka";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // korisnikToolStripMenuItem
            // 
            this.korisnikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaKorisnikaToolStripMenuItem,
            this.noviKorisnikToolStripMenuItem});
            this.korisnikToolStripMenuItem.Name = "korisnikToolStripMenuItem";
            this.korisnikToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.korisnikToolStripMenuItem.Text = "Korisnik";
            // 
            // pretragaKorisnikaToolStripMenuItem
            // 
            this.pretragaKorisnikaToolStripMenuItem.Name = "pretragaKorisnikaToolStripMenuItem";
            this.pretragaKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.pretragaKorisnikaToolStripMenuItem.Text = "Pretraga korisnika";
            this.pretragaKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.pretragaKorisnikaToolStripMenuItem_Click);
            // 
            // noviKorisnikToolStripMenuItem
            // 
            this.noviKorisnikToolStripMenuItem.Name = "noviKorisnikToolStripMenuItem";
            this.noviKorisnikToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.noviKorisnikToolStripMenuItem.Text = "Novi korisnik";
            this.noviKorisnikToolStripMenuItem.Click += new System.EventHandler(this.noviKorisnikToolStripMenuItem_Click);
            // 
            // izvještajiToolStripMenuItem
            // 
            this.izvještajiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kamionKvarToolStripMenuItem,
            this.korisnikIsporukeToolStripMenuItem,
            this.uslugeZaradaToolStripMenuItem});
            this.izvještajiToolStripMenuItem.Name = "izvještajiToolStripMenuItem";
            this.izvještajiToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.izvještajiToolStripMenuItem.Text = "Izvještaji";
            // 
            // kamionKvarToolStripMenuItem
            // 
            this.kamionKvarToolStripMenuItem.Name = "kamionKvarToolStripMenuItem";
            this.kamionKvarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kamionKvarToolStripMenuItem.Text = "KamionKvar";
            this.kamionKvarToolStripMenuItem.Click += new System.EventHandler(this.kamionKvarToolStripMenuItem_Click);
            // 
            // korisnikIsporukeToolStripMenuItem
            // 
            this.korisnikIsporukeToolStripMenuItem.Name = "korisnikIsporukeToolStripMenuItem";
            this.korisnikIsporukeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.korisnikIsporukeToolStripMenuItem.Text = "KorisnikIsporuke";
            this.korisnikIsporukeToolStripMenuItem.Click += new System.EventHandler(this.korisnikIsporukeToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 516);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1051, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // uslugeZaradaToolStripMenuItem
            // 
            this.uslugeZaradaToolStripMenuItem.Name = "uslugeZaradaToolStripMenuItem";
            this.uslugeZaradaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.uslugeZaradaToolStripMenuItem.Text = "UslugeZarada";
            this.uslugeZaradaToolStripMenuItem.Click += new System.EventHandler(this.uslugeZaradaToolStripMenuItem_Click);
            // 
            // frmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 538);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmIndex";
            this.Text = "frmIndex";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem uslugaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaUslugaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem državaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adresaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem novaAdresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kamionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaKamionaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviKamionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zahtjevToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaZahtjevaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaKvarovaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem isporukaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaIsporukaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem korisnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviKorisnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvještajiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kamionKvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem korisnikIsporukeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uslugeZaradaToolStripMenuItem;
    }
}



