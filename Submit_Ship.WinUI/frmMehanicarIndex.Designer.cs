
namespace Submit_Ship.WinUI
{
    partial class frmMehanicarIndex
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
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.kamioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledKamionaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kvaroviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mojProfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mojiPodaciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjaviEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kamioniToolStripMenuItem,
            this.mojProfilToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // kamioniToolStripMenuItem
            // 
            this.kamioniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledKamionaToolStripMenuItem,
            this.kvaroviToolStripMenuItem});
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
            // kvaroviToolStripMenuItem
            // 
            this.kvaroviToolStripMenuItem.Name = "kvaroviToolStripMenuItem";
            this.kvaroviToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kvaroviToolStripMenuItem.Text = "Kvarovi";
            this.kvaroviToolStripMenuItem.Click += new System.EventHandler(this.kvaroviToolStripMenuItem_Click);
            // 
            // mojProfilToolStripMenuItem
            // 
            this.mojProfilToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mojProfilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mojiPodaciToolStripMenuItem,
            this.odjaviEToolStripMenuItem});
            this.mojProfilToolStripMenuItem.Name = "mojProfilToolStripMenuItem";
            this.mojProfilToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.mojProfilToolStripMenuItem.Text = "Moj profil";
            // 
            // mojiPodaciToolStripMenuItem
            // 
            this.mojiPodaciToolStripMenuItem.Name = "mojiPodaciToolStripMenuItem";
            this.mojiPodaciToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mojiPodaciToolStripMenuItem.Text = "Moji podaci";
            this.mojiPodaciToolStripMenuItem.Click += new System.EventHandler(this.mojiPodaciToolStripMenuItem_Click);
            // 
            // odjaviEToolStripMenuItem
            // 
            this.odjaviEToolStripMenuItem.Name = "odjaviEToolStripMenuItem";
            this.odjaviEToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.odjaviEToolStripMenuItem.Text = "Odjavi se";
            this.odjaviEToolStripMenuItem.Click += new System.EventHandler(this.odjaviEToolStripMenuItem_Click);
            // 
            // frmMehanicarIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 861);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmMehanicarIndex";
            this.Text = "frmMehanicarIndex";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem kamioniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledKamionaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kvaroviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mojProfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mojiPodaciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odjaviEToolStripMenuItem;
    }
}



