
namespace Submit_Ship.WinUI.Isporuka
{
    partial class frmIsporukaDetalji
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
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbAdresaUtovara = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbAdresaIstovara = new System.Windows.Forms.ComboBox();
            this.btnAdresa = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dtmDatum = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbKamion = new System.Windows.Forms.ComboBox();
            this.cmbVozac = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbKlijent = new System.Windows.Forms.ComboBox();
            this.Klijent = new System.Windows.Forms.Label();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.cmbUsluga = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Opis = new System.Windows.Forms.Label();
            this.rtxtOpis = new System.Windows.Forms.RichTextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNaslov
            // 
            this.txtNaslov.Location = new System.Drawing.Point(57, 70);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(674, 20);
            this.txtNaslov.TabIndex = 0;
            this.txtNaslov.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaslov_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naslov";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(464, 676);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cijena";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(461, 705);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(280, 20);
            this.txtCijena.TabIndex = 4;
            this.txtCijena.Validating += new System.ComponentModel.CancelEventHandler(this.txtCijena_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Adresa utovara";
            // 
            // cmbAdresaUtovara
            // 
            this.cmbAdresaUtovara.FormattingEnabled = true;
            this.cmbAdresaUtovara.Location = new System.Drawing.Point(60, 262);
            this.cmbAdresaUtovara.Name = "cmbAdresaUtovara";
            this.cmbAdresaUtovara.Size = new System.Drawing.Size(280, 21);
            this.cmbAdresaUtovara.TabIndex = 7;
            this.cmbAdresaUtovara.Validating += new System.ComponentModel.CancelEventHandler(this.cmbAdresaUtovara_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Adresa istovara";
            // 
            // cmbAdresaIstovara
            // 
            this.cmbAdresaIstovara.FormattingEnabled = true;
            this.cmbAdresaIstovara.Location = new System.Drawing.Point(455, 262);
            this.cmbAdresaIstovara.Name = "cmbAdresaIstovara";
            this.cmbAdresaIstovara.Size = new System.Drawing.Size(280, 21);
            this.cmbAdresaIstovara.TabIndex = 9;
            this.cmbAdresaIstovara.Validating += new System.ComponentModel.CancelEventHandler(this.cmbAdresaIstovara_Validating);
            // 
            // btnAdresa
            // 
            this.btnAdresa.Location = new System.Drawing.Point(598, 313);
            this.btnAdresa.Name = "btnAdresa";
            this.btnAdresa.Size = new System.Drawing.Size(143, 23);
            this.btnAdresa.TabIndex = 10;
            this.btnAdresa.Text = "Dodaj adresu";
            this.btnAdresa.UseVisualStyleBackColor = true;
            this.btnAdresa.Click += new System.EventHandler(this.btnAdresa_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Datum";
            // 
            // dtmDatum
            // 
            this.dtmDatum.Location = new System.Drawing.Point(73, 377);
            this.dtmDatum.Name = "dtmDatum";
            this.dtmDatum.Size = new System.Drawing.Size(671, 20);
            this.dtmDatum.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 423);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Kamion";
            // 
            // cmbKamion
            // 
            this.cmbKamion.FormattingEnabled = true;
            this.cmbKamion.Location = new System.Drawing.Point(73, 461);
            this.cmbKamion.Name = "cmbKamion";
            this.cmbKamion.Size = new System.Drawing.Size(277, 21);
            this.cmbKamion.TabIndex = 14;
            this.cmbKamion.Validating += new System.ComponentModel.CancelEventHandler(this.cmbKamion_Validating);
            // 
            // cmbVozac
            // 
            this.cmbVozac.FormattingEnabled = true;
            this.cmbVozac.Location = new System.Drawing.Point(470, 461);
            this.cmbVozac.Name = "cmbVozac";
            this.cmbVozac.Size = new System.Drawing.Size(277, 21);
            this.cmbVozac.TabIndex = 16;
            this.cmbVozac.Validating += new System.ComponentModel.CancelEventHandler(this.cmbVozac_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(467, 423);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Vozač";
            // 
            // cmbKlijent
            // 
            this.cmbKlijent.FormattingEnabled = true;
            this.cmbKlijent.Location = new System.Drawing.Point(73, 552);
            this.cmbKlijent.Name = "cmbKlijent";
            this.cmbKlijent.Size = new System.Drawing.Size(671, 21);
            this.cmbKlijent.TabIndex = 18;
            this.cmbKlijent.Validating += new System.ComponentModel.CancelEventHandler(this.cmbKlijent_Validating);
            // 
            // Klijent
            // 
            this.Klijent.AutoSize = true;
            this.Klijent.Location = new System.Drawing.Point(70, 512);
            this.Klijent.Name = "Klijent";
            this.Klijent.Size = new System.Drawing.Size(35, 13);
            this.Klijent.TabIndex = 17;
            this.Klijent.Text = "Klijent";
            // 
            // btnSnimi
            // 
            this.btnSnimi.Location = new System.Drawing.Point(461, 791);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(280, 34);
            this.btnSnimi.TabIndex = 19;
            this.btnSnimi.Text = "Snimi";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // cmbUsluga
            // 
            this.cmbUsluga.FormattingEnabled = true;
            this.cmbUsluga.Location = new System.Drawing.Point(67, 624);
            this.cmbUsluga.Name = "cmbUsluga";
            this.cmbUsluga.Size = new System.Drawing.Size(668, 21);
            this.cmbUsluga.TabIndex = 20;
            this.cmbUsluga.Validating += new System.ComponentModel.CancelEventHandler(this.cmbUsluga_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(73, 594);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Kategorija";
            // 
            // Opis
            // 
            this.Opis.AutoSize = true;
            this.Opis.Location = new System.Drawing.Point(57, 111);
            this.Opis.Name = "Opis";
            this.Opis.Size = new System.Drawing.Size(28, 13);
            this.Opis.TabIndex = 22;
            this.Opis.Text = "Opis";
            // 
            // rtxtOpis
            // 
            this.rtxtOpis.Location = new System.Drawing.Point(63, 153);
            this.rtxtOpis.Name = "rtxtOpis";
            this.rtxtOpis.Size = new System.Drawing.Size(675, 71);
            this.rtxtOpis.TabIndex = 23;
            this.rtxtOpis.Text = "";
            this.rtxtOpis.Validating += new System.ComponentModel.CancelEventHandler(this.rtxtOpis_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmIsporukaDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 837);
            this.Controls.Add(this.rtxtOpis);
            this.Controls.Add(this.Opis);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbUsluga);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.cmbKlijent);
            this.Controls.Add(this.Klijent);
            this.Controls.Add(this.cmbVozac);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbKamion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtmDatum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAdresa);
            this.Controls.Add(this.cmbAdresaIstovara);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbAdresaUtovara);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNaslov);
            this.Name = "frmIsporukaDetalji";
            this.Text = "frmIsporukaDetalji";
            this.Load += new System.EventHandler(this.frmIsporukaDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbAdresaUtovara;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbAdresaIstovara;
        private System.Windows.Forms.Button btnAdresa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtmDatum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbKamion;
        private System.Windows.Forms.ComboBox cmbVozac;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbKlijent;
        private System.Windows.Forms.Label Klijent;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.ComboBox cmbUsluga;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Opis;
        private System.Windows.Forms.RichTextBox rtxtOpis;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}