
namespace Submit_Ship.WinUI.Grad
{
    partial class frmGrad
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDrzava = new System.Windows.Forms.ComboBox();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.btnDrzavaDodaj = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv grada";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(60, 68);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(228, 20);
            this.txtNaziv.TabIndex = 1;
            this.txtNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaziv_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Država";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbDrzava
            // 
            this.cmbDrzava.FormattingEnabled = true;
            this.cmbDrzava.Location = new System.Drawing.Point(60, 157);
            this.cmbDrzava.Name = "cmbDrzava";
            this.cmbDrzava.Size = new System.Drawing.Size(157, 21);
            this.cmbDrzava.TabIndex = 3;
            this.cmbDrzava.Validating += new System.ComponentModel.CancelEventHandler(this.cmbDrzava_Validating);
            // 
            // btnSnimi
            // 
            this.btnSnimi.Location = new System.Drawing.Point(60, 238);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(228, 23);
            this.btnSnimi.TabIndex = 4;
            this.btnSnimi.Text = "Snimi";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // btnDrzavaDodaj
            // 
            this.btnDrzavaDodaj.Location = new System.Drawing.Point(235, 155);
            this.btnDrzavaDodaj.Name = "btnDrzavaDodaj";
            this.btnDrzavaDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDrzavaDodaj.TabIndex = 5;
            this.btnDrzavaDodaj.Text = "Dodaj drzavu";
            this.btnDrzavaDodaj.UseVisualStyleBackColor = true;
            this.btnDrzavaDodaj.Click += new System.EventHandler(this.btnDrzavaDodaj_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmGrad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 282);
            this.Controls.Add(this.btnDrzavaDodaj);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.cmbDrzava);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label1);
            this.Name = "frmGrad";
            this.Text = "frmGrad";
            this.Load += new System.EventHandler(this.frmGrad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDrzava;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.Button btnDrzavaDodaj;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}