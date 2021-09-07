
namespace Submit_Ship.WinUI.Usluga
{
    partial class frmUslugaDetalji
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
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.Naslov = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtxtOpis = new System.Windows.Forms.RichTextBox();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(64, 48);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(262, 20);
            this.txtNaziv.TabIndex = 0;
            this.txtNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaziv_Validating);
            // 
            // Naslov
            // 
            this.Naslov.AutoSize = true;
            this.Naslov.Location = new System.Drawing.Point(64, 29);
            this.Naslov.Name = "Naslov";
            this.Naslov.Size = new System.Drawing.Size(34, 13);
            this.Naslov.TabIndex = 1;
            this.Naslov.Text = "Naziv";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(64, 125);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(262, 20);
            this.txtCijena.TabIndex = 2;
            this.txtCijena.Validating += new System.ComponentModel.CancelEventHandler(this.txtCijena_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cijena";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Opis";
            // 
            // rtxtOpis
            // 
            this.rtxtOpis.Location = new System.Drawing.Point(64, 210);
            this.rtxtOpis.Name = "rtxtOpis";
            this.rtxtOpis.Size = new System.Drawing.Size(262, 157);
            this.rtxtOpis.TabIndex = 5;
            this.rtxtOpis.Text = "";
            this.rtxtOpis.Validating += new System.ComponentModel.CancelEventHandler(this.rtxtOpis_Validating);
            // 
            // btnSnimi
            // 
            this.btnSnimi.Location = new System.Drawing.Point(64, 420);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(262, 23);
            this.btnSnimi.TabIndex = 6;
            this.btnSnimi.Text = "Snimi";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmUslugaDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 476);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.rtxtOpis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.Naslov);
            this.Controls.Add(this.txtNaziv);
            this.Name = "frmUslugaDetalji";
            this.Text = "frmUslugaDetalji";
            this.Load += new System.EventHandler(this.frmUslugaDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label Naslov;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtxtOpis;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}