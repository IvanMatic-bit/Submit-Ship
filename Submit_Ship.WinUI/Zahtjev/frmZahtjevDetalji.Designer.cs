
namespace Submit_Ship.WinUI.Zahtjev
{
    partial class frmZahtjevDetalji
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
            this.Naslov = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPrihvati = new System.Windows.Forms.Button();
            this.btnOdbij = new System.Windows.Forms.Button();
            this.rtbSadrzaj = new System.Windows.Forms.RichTextBox();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtKlijent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Naslov
            // 
            this.Naslov.AutoSize = true;
            this.Naslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Naslov.Location = new System.Drawing.Point(12, 63);
            this.Naslov.Name = "Naslov";
            this.Naslov.Size = new System.Drawing.Size(67, 24);
            this.Naslov.TabIndex = 1;
            this.Naslov.Text = "Naslov";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Datum i vrijeme kreiranja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Klijent ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sadržaj";
            // 
            // btnPrihvati
            // 
            this.btnPrihvati.BackColor = System.Drawing.Color.Green;
            this.btnPrihvati.Location = new System.Drawing.Point(299, 484);
            this.btnPrihvati.Name = "btnPrihvati";
            this.btnPrihvati.Size = new System.Drawing.Size(118, 39);
            this.btnPrihvati.TabIndex = 11;
            this.btnPrihvati.Text = "Prihvati";
            this.btnPrihvati.UseVisualStyleBackColor = false;
            this.btnPrihvati.Visible = false;
            this.btnPrihvati.Click += new System.EventHandler(this.btnPrihvati_Click);
            // 
            // btnOdbij
            // 
            this.btnOdbij.BackColor = System.Drawing.Color.Red;
            this.btnOdbij.Location = new System.Drawing.Point(472, 484);
            this.btnOdbij.Name = "btnOdbij";
            this.btnOdbij.Size = new System.Drawing.Size(118, 39);
            this.btnOdbij.TabIndex = 12;
            this.btnOdbij.Text = "Odbij";
            this.btnOdbij.UseVisualStyleBackColor = false;
            this.btnOdbij.Visible = false;
            this.btnOdbij.Click += new System.EventHandler(this.btnOdbij_Click);
            // 
            // rtbSadrzaj
            // 
            this.rtbSadrzaj.Location = new System.Drawing.Point(16, 307);
            this.rtbSadrzaj.Name = "rtbSadrzaj";
            this.rtbSadrzaj.ReadOnly = true;
            this.rtbSadrzaj.Size = new System.Drawing.Size(574, 143);
            this.rtbSadrzaj.TabIndex = 13;
            this.rtbSadrzaj.Text = "";
            // 
            // txtNaslov
            // 
            this.txtNaslov.Location = new System.Drawing.Point(395, 63);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.ReadOnly = true;
            this.txtNaslov.Size = new System.Drawing.Size(195, 20);
            this.txtNaslov.TabIndex = 14;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Enabled = false;
            this.dtpDatum.Location = new System.Drawing.Point(395, 121);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 20);
            this.dtpDatum.TabIndex = 15;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(395, 181);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(195, 20);
            this.txtStatus.TabIndex = 16;
            // 
            // txtKlijent
            // 
            this.txtKlijent.Location = new System.Drawing.Point(395, 234);
            this.txtKlijent.Name = "txtKlijent";
            this.txtKlijent.ReadOnly = true;
            this.txtKlijent.Size = new System.Drawing.Size(195, 20);
            this.txtKlijent.TabIndex = 17;
            // 
            // frmZahtjevDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 592);
            this.Controls.Add(this.txtKlijent);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.txtNaslov);
            this.Controls.Add(this.rtbSadrzaj);
            this.Controls.Add(this.btnOdbij);
            this.Controls.Add(this.btnPrihvati);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Naslov);
            this.Name = "frmZahtjevDetalji";
            this.Text = "frmZahtjevDetalji";
            this.Load += new System.EventHandler(this.frmZahtjevDetalji_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Naslov;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPrihvati;
        private System.Windows.Forms.Button btnOdbij;
        private System.Windows.Forms.RichTextBox rtbSadrzaj;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtKlijent;
    }
}