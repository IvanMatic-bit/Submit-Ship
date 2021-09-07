
namespace Submit_Ship.WinUI.Zahtjev
{
    partial class frmZahtjev
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.grbZahtjevi = new System.Windows.Forms.GroupBox();
            this.dgvZahtjevi = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naslov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sadrzaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Klijent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusZahtjeva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbZahtjevi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZahtjevi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pretraga";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(12, 70);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(200, 20);
            this.txtPretraga.TabIndex = 1;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(232, 67);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazi.TabIndex = 2;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(399, 70);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(187, 21);
            this.cmbStatus.TabIndex = 3;
            this.cmbStatus.SelectedValueChanged += new System.EventHandler(this.cmbStatus_SelectedValueChanged);
            // 
            // grbZahtjevi
            // 
            this.grbZahtjevi.Controls.Add(this.dgvZahtjevi);
            this.grbZahtjevi.Location = new System.Drawing.Point(12, 133);
            this.grbZahtjevi.Name = "grbZahtjevi";
            this.grbZahtjevi.Size = new System.Drawing.Size(776, 305);
            this.grbZahtjevi.TabIndex = 4;
            this.grbZahtjevi.TabStop = false;
            this.grbZahtjevi.Text = "Zahtjevi";
            // 
            // dgvZahtjevi
            // 
            this.dgvZahtjevi.AllowUserToAddRows = false;
            this.dgvZahtjevi.AllowUserToDeleteRows = false;
            this.dgvZahtjevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZahtjevi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Naslov,
            this.Sadrzaj,
            this.Klijent,
            this.StatusZahtjeva});
            this.dgvZahtjevi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvZahtjevi.Location = new System.Drawing.Point(3, 16);
            this.dgvZahtjevi.Name = "dgvZahtjevi";
            this.dgvZahtjevi.ReadOnly = true;
            this.dgvZahtjevi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZahtjevi.Size = new System.Drawing.Size(770, 286);
            this.dgvZahtjevi.TabIndex = 0;
            this.dgvZahtjevi.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvZahtjevi_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filtriranje po statusu";
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
            // Sadrzaj
            // 
            this.Sadrzaj.DataPropertyName = "Sadrzaj";
            this.Sadrzaj.HeaderText = "Sadrzaj";
            this.Sadrzaj.Name = "Sadrzaj";
            this.Sadrzaj.ReadOnly = true;
            // 
            // Klijent
            // 
            this.Klijent.DataPropertyName = "Klijent";
            this.Klijent.HeaderText = "Klijent";
            this.Klijent.Name = "Klijent";
            this.Klijent.ReadOnly = true;
            // 
            // StatusZahtjeva
            // 
            this.StatusZahtjeva.DataPropertyName = "StatusZahtjeva";
            this.StatusZahtjeva.HeaderText = "Status zahtjeva";
            this.StatusZahtjeva.Name = "StatusZahtjeva";
            this.StatusZahtjeva.ReadOnly = true;
            // 
            // frmZahtjev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grbZahtjevi);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.label1);
            this.Name = "frmZahtjev";
            this.Text = "da";
            this.Load += new System.EventHandler(this.frmZahtjev_Load);
            this.grbZahtjevi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZahtjevi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.GroupBox grbZahtjevi;
        private System.Windows.Forms.DataGridView dgvZahtjevi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naslov;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sadrzaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Klijent;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusZahtjeva;
    }
}