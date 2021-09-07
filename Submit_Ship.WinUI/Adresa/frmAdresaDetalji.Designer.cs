
namespace Submit_Ship.WinUI.Adresa
{
    partial class frmAdresaDetalji
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
            this.txtNaziv = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbGrad = new System.Windows.Forms.ComboBox();
            this.btnGrad = new System.Windows.Forms.Button();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNaziv
            // 
            this.txtNaziv.AutoSize = true;
            this.txtNaziv.Location = new System.Drawing.Point(43, 42);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(31, 13);
            this.txtNaziv.TabIndex = 0;
            this.txtNaziv.Text = "Ulica";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(46, 76);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(344, 20);
            this.txtAdresa.TabIndex = 1;
            this.txtAdresa.Validating += new System.ComponentModel.CancelEventHandler(this.txtAdresa_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Grad";
            // 
            // cmbGrad
            // 
            this.cmbGrad.FormattingEnabled = true;
            this.cmbGrad.Location = new System.Drawing.Point(46, 171);
            this.cmbGrad.Name = "cmbGrad";
            this.cmbGrad.Size = new System.Drawing.Size(227, 21);
            this.cmbGrad.TabIndex = 3;
            // 
            // btnGrad
            // 
            this.btnGrad.Location = new System.Drawing.Point(294, 171);
            this.btnGrad.Name = "btnGrad";
            this.btnGrad.Size = new System.Drawing.Size(96, 23);
            this.btnGrad.TabIndex = 4;
            this.btnGrad.Text = "Dodaj grad";
            this.btnGrad.UseVisualStyleBackColor = true;
            this.btnGrad.Click += new System.EventHandler(this.btnGrad_Click);
            // 
            // btnSnimi
            // 
            this.btnSnimi.Location = new System.Drawing.Point(49, 271);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(341, 23);
            this.btnSnimi.TabIndex = 5;
            this.btnSnimi.Text = "Snimi";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmAdresaDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 378);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.btnGrad);
            this.Controls.Add(this.cmbGrad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtNaziv);
            this.Name = "frmAdresaDetalji";
            this.Text = "frmAdresaDetalji";
            this.Load += new System.EventHandler(this.frmAdresaDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNaziv;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGrad;
        private System.Windows.Forms.Button btnGrad;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}