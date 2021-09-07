
namespace Submit_Ship.WinUI
{
    partial class frmAdministratorIndex
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviKorisnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kamioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledKamionaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaKamionaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cjenovnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledCjenovnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviCjenovnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mojProfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mojiPodaciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjaviSeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 839);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1184, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.korisniciToolStripMenuItem,
            this.kamioniToolStripMenuItem,
            this.cjenovnikToolStripMenuItem,
            this.mojProfilToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledKorisnikaToolStripMenuItem,
            this.noviKorisnikToolStripMenuItem});
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.korisniciToolStripMenuItem.Text = "Korisnici";
            // 
            // pregledKorisnikaToolStripMenuItem
            // 
            this.pregledKorisnikaToolStripMenuItem.Name = "pregledKorisnikaToolStripMenuItem";
            this.pregledKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.pregledKorisnikaToolStripMenuItem.Text = "Pregled korisnika";
            this.pregledKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.pregledKorisnikaToolStripMenuItem_Click);
            // 
            // noviKorisnikToolStripMenuItem
            // 
            this.noviKorisnikToolStripMenuItem.Name = "noviKorisnikToolStripMenuItem";
            this.noviKorisnikToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.noviKorisnikToolStripMenuItem.Text = "Novi korisnik";
            this.noviKorisnikToolStripMenuItem.Click += new System.EventHandler(this.noviKorisnikToolStripMenuItem_Click);
            // 
            // kamioniToolStripMenuItem
            // 
            this.kamioniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledKamionaToolStripMenuItem,
            this.pretragaKamionaToolStripMenuItem});
            this.kamioniToolStripMenuItem.Name = "kamioniToolStripMenuItem";
            this.kamioniToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.kamioniToolStripMenuItem.Text = "Kamioni";
            // 
            // pregledKamionaToolStripMenuItem
            // 
            this.pregledKamionaToolStripMenuItem.Name = "pregledKamionaToolStripMenuItem";
            this.pregledKamionaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pregledKamionaToolStripMenuItem.Text = "Pregled kamiona";
            this.pregledKamionaToolStripMenuItem.Click += new System.EventHandler(this.pregledKamionaToolStripMenuItem_Click);
            // 
            // pretragaKamionaToolStripMenuItem
            // 
            this.pretragaKamionaToolStripMenuItem.Name = "pretragaKamionaToolStripMenuItem";
            this.pretragaKamionaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pretragaKamionaToolStripMenuItem.Text = "Novi kamion";
            this.pretragaKamionaToolStripMenuItem.Click += new System.EventHandler(this.pretragaKamionaToolStripMenuItem_Click);
            // 
            // cjenovnikToolStripMenuItem
            // 
            this.cjenovnikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledCjenovnikaToolStripMenuItem,
            this.noviCjenovnikToolStripMenuItem});
            this.cjenovnikToolStripMenuItem.Name = "cjenovnikToolStripMenuItem";
            this.cjenovnikToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.cjenovnikToolStripMenuItem.Text = "Cjenovnik";
            // 
            // pregledCjenovnikaToolStripMenuItem
            // 
            this.pregledCjenovnikaToolStripMenuItem.Name = "pregledCjenovnikaToolStripMenuItem";
            this.pregledCjenovnikaToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.pregledCjenovnikaToolStripMenuItem.Text = "Pregled cjenovnika";
            this.pregledCjenovnikaToolStripMenuItem.Click += new System.EventHandler(this.pregledCjenovnikaToolStripMenuItem_Click);
            // 
            // noviCjenovnikToolStripMenuItem
            // 
            this.noviCjenovnikToolStripMenuItem.Name = "noviCjenovnikToolStripMenuItem";
            this.noviCjenovnikToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.noviCjenovnikToolStripMenuItem.Text = "Novi cjenovnik";
            this.noviCjenovnikToolStripMenuItem.Click += new System.EventHandler(this.noviCjenovnikToolStripMenuItem_Click);
            // 
            // mojProfilToolStripMenuItem
            // 
            this.mojProfilToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mojProfilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mojiPodaciToolStripMenuItem,
            this.odjaviSeToolStripMenuItem});
            this.mojProfilToolStripMenuItem.Name = "mojProfilToolStripMenuItem";
            this.mojProfilToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.mojProfilToolStripMenuItem.Text = "Moj profil";
            // 
            // mojiPodaciToolStripMenuItem
            // 
            this.mojiPodaciToolStripMenuItem.Name = "mojiPodaciToolStripMenuItem";
            this.mojiPodaciToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.mojiPodaciToolStripMenuItem.Text = "Moji podaci";
            this.mojiPodaciToolStripMenuItem.Click += new System.EventHandler(this.mojiPodaciToolStripMenuItem_Click);
            // 
            // odjaviSeToolStripMenuItem
            // 
            this.odjaviSeToolStripMenuItem.Name = "odjaviSeToolStripMenuItem";
            this.odjaviSeToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.odjaviSeToolStripMenuItem.Text = "Odjavi se";
            this.odjaviSeToolStripMenuItem.Click += new System.EventHandler(this.odjaviSeToolStripMenuItem_Click);
            // 
            // frmAdministratorIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 861);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmAdministratorIndex";
            this.Text = "frmAdministratorIndex";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviKorisnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kamioniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledKamionaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaKamionaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cjenovnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledCjenovnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviCjenovnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mojProfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mojiPodaciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odjaviSeToolStripMenuItem;
    }
}



