
namespace Submit_Ship.WinUI.Izvjestaji
{
    partial class frmKorisnikIsporuke
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.cmbKorisnik = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDatumOd = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumDo = new System.Windows.Forms.DateTimePicker();
            this.rvIsporuke = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bsIsporuka = new System.Windows.Forms.BindingSource(this.components);
            this.btnIzvjestaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsIsporuka)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbKorisnik
            // 
            this.cmbKorisnik.FormattingEnabled = true;
            this.cmbKorisnik.Location = new System.Drawing.Point(48, 31);
            this.cmbKorisnik.Name = "cmbKorisnik";
            this.cmbKorisnik.Size = new System.Drawing.Size(500, 21);
            this.cmbKorisnik.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Korisnik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Od ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Do";
            // 
            // dtpDatumOd
            // 
            this.dtpDatumOd.Location = new System.Drawing.Point(48, 92);
            this.dtpDatumOd.Name = "dtpDatumOd";
            this.dtpDatumOd.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumOd.TabIndex = 4;
            // 
            // dtpDatumDo
            // 
            this.dtpDatumDo.Location = new System.Drawing.Point(348, 92);
            this.dtpDatumDo.Name = "dtpDatumDo";
            this.dtpDatumDo.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumDo.TabIndex = 5;
            // 
            // rvIsporuke
            // 
            reportDataSource3.Name = "dsKorisnikIsporuke";
            reportDataSource3.Value = this.bsIsporuka;
            this.rvIsporuke.LocalReport.DataSources.Add(reportDataSource3);
            this.rvIsporuke.LocalReport.ReportEmbeddedResource = "Submit_Ship.WinUI.Izvjestaji.rptKorisnikIsporuke.rdlc";
            this.rvIsporuke.Location = new System.Drawing.Point(12, 142);
            this.rvIsporuke.Name = "rvIsporuke";
            this.rvIsporuke.ServerReport.BearerToken = null;
            this.rvIsporuke.Size = new System.Drawing.Size(776, 296);
            this.rvIsporuke.TabIndex = 6;
            // 
            // bsIsporuka
            // 
            this.bsIsporuka.DataSource = typeof(Submit_Ship.Model.Isporuka);
            // 
            // btnIzvjestaj
            // 
            this.btnIzvjestaj.Location = new System.Drawing.Point(598, 89);
            this.btnIzvjestaj.Name = "btnIzvjestaj";
            this.btnIzvjestaj.Size = new System.Drawing.Size(90, 23);
            this.btnIzvjestaj.TabIndex = 7;
            this.btnIzvjestaj.Text = "Prikaži izvještaj";
            this.btnIzvjestaj.UseVisualStyleBackColor = true;
            this.btnIzvjestaj.Click += new System.EventHandler(this.btnIzvjestaj_Click);
            // 
            // frmKorisnikIsporuke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIzvjestaj);
            this.Controls.Add(this.rvIsporuke);
            this.Controls.Add(this.dtpDatumDo);
            this.Controls.Add(this.dtpDatumOd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKorisnik);
            this.Name = "frmKorisnikIsporuke";
            this.Text = "frmKorisnikIsporuke";
            this.Load += new System.EventHandler(this.frmKorisnikIsporuke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsIsporuka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKorisnik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDatumOd;
        private System.Windows.Forms.DateTimePicker dtpDatumDo;
        private Microsoft.Reporting.WinForms.ReportViewer rvIsporuke;
        private System.Windows.Forms.BindingSource bsIsporuka;
        private System.Windows.Forms.Button btnIzvjestaj;
    }
}