
namespace Submit_Ship.WinUI.Isporuka
{
    partial class frmIsporuka
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvIsporuke = new System.Windows.Forms.DataGridView();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naslov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpisIsporuke = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placeno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdresaUtovara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdresaIstovara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Klijent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kamion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usluga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zaposlenik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusIsporuke = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumKreiranja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumIsporuke = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsporuke)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvIsporuke);
            this.groupBox1.Location = new System.Drawing.Point(12, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1349, 279);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Isporuke";
            // 
            // dgvIsporuke
            // 
            this.dgvIsporuke.AllowUserToAddRows = false;
            this.dgvIsporuke.AllowUserToDeleteRows = false;
            this.dgvIsporuke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIsporuke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Naslov,
            this.OpisIsporuke,
            this.Placeno,
            this.AdresaUtovara,
            this.AdresaIstovara,
            this.Klijent,
            this.Kamion,
            this.Usluga,
            this.Zaposlenik,
            this.Cijena,
            this.StatusIsporuke,
            this.DatumKreiranja,
            this.DatumIsporuke});
            this.dgvIsporuke.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIsporuke.Location = new System.Drawing.Point(3, 16);
            this.dgvIsporuke.Name = "dgvIsporuke";
            this.dgvIsporuke.ReadOnly = true;
            this.dgvIsporuke.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIsporuke.Size = new System.Drawing.Size(1343, 260);
            this.dgvIsporuke.TabIndex = 0;
            this.dgvIsporuke.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvIsporuke_MouseDoubleClick);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(24, 73);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(234, 20);
            this.txtPretraga.TabIndex = 1;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(292, 73);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(121, 23);
            this.btnPrikazi.TabIndex = 2;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(499, 73);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(213, 21);
            this.cmbStatus.TabIndex = 3;
            this.cmbStatus.SelectedValueChanged += new System.EventHandler(this.cmbStatus_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Traži";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(499, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Status";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Naslov
            // 
            this.Naslov.DataPropertyName = "Naslov";
            this.Naslov.HeaderText = "Naslov";
            this.Naslov.Name = "Naslov";
            this.Naslov.ReadOnly = true;
            // 
            // OpisIsporuke
            // 
            this.OpisIsporuke.DataPropertyName = "OpisIsporuke";
            this.OpisIsporuke.HeaderText = "Opis isporuke";
            this.OpisIsporuke.Name = "OpisIsporuke";
            this.OpisIsporuke.ReadOnly = true;
            // 
            // Placeno
            // 
            this.Placeno.DataPropertyName = "Placeno";
            this.Placeno.HeaderText = "Plaćeno";
            this.Placeno.Name = "Placeno";
            this.Placeno.ReadOnly = true;
            // 
            // AdresaUtovara
            // 
            this.AdresaUtovara.DataPropertyName = "AdresaUtovaraNaziv";
            this.AdresaUtovara.HeaderText = "AdresaUtovara";
            this.AdresaUtovara.Name = "AdresaUtovara";
            this.AdresaUtovara.ReadOnly = true;
            // 
            // AdresaIstovara
            // 
            this.AdresaIstovara.DataPropertyName = "AdresaIstovaraNaziv";
            this.AdresaIstovara.HeaderText = "Adresa istovara";
            this.AdresaIstovara.Name = "AdresaIstovara";
            this.AdresaIstovara.ReadOnly = true;
            // 
            // Klijent
            // 
            this.Klijent.DataPropertyName = "Klijent";
            this.Klijent.HeaderText = "Klijent";
            this.Klijent.Name = "Klijent";
            this.Klijent.ReadOnly = true;
            // 
            // Kamion
            // 
            this.Kamion.DataPropertyName = "Kamion";
            this.Kamion.HeaderText = "Kamion";
            this.Kamion.Name = "Kamion";
            this.Kamion.ReadOnly = true;
            // 
            // Usluga
            // 
            this.Usluga.DataPropertyName = "UslugaNaziv";
            this.Usluga.HeaderText = "Usluga";
            this.Usluga.Name = "Usluga";
            this.Usluga.ReadOnly = true;
            // 
            // Zaposlenik
            // 
            this.Zaposlenik.DataPropertyName = "Zaposlenik";
            this.Zaposlenik.HeaderText = "Zaposlenik";
            this.Zaposlenik.Name = "Zaposlenik";
            this.Zaposlenik.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // StatusIsporuke
            // 
            this.StatusIsporuke.DataPropertyName = "StatusIsporukeNaziv";
            this.StatusIsporuke.HeaderText = "StatusIsporuke";
            this.StatusIsporuke.Name = "StatusIsporuke";
            this.StatusIsporuke.ReadOnly = true;
            // 
            // DatumKreiranja
            // 
            this.DatumKreiranja.DataPropertyName = "DatumKreiranja";
            this.DatumKreiranja.HeaderText = "Datum kreiranja";
            this.DatumKreiranja.Name = "DatumKreiranja";
            this.DatumKreiranja.ReadOnly = true;
            // 
            // DatumIsporuke
            // 
            this.DatumIsporuke.DataPropertyName = "DatumIsporuke";
            this.DatumIsporuke.HeaderText = "Datum isporuke";
            this.DatumIsporuke.Name = "DatumIsporuke";
            this.DatumIsporuke.ReadOnly = true;
            // 
            // frmIsporuka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmIsporuka";
            this.Text = "frmIsporuka";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmIsporuka_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsporuke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvIsporuke;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naslov;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpisIsporuke;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placeno;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdresaUtovara;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdresaIstovara;
        private System.Windows.Forms.DataGridViewTextBoxColumn Klijent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kamion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usluga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zaposlenik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusIsporuke;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumKreiranja;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumIsporuke;
    }
}