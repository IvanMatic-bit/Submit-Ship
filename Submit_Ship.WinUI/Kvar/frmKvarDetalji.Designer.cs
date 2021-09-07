
namespace Submit_Ship.WinUI.Kvar
{
    partial class frmKvarDetalji
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKamion = new System.Windows.Forms.TextBox();
            this.txtVozac = new System.Windows.Forms.TextBox();
            this.rtbProblem = new System.Windows.Forms.RichTextBox();
            this.rtbKomentar = new System.Windows.Forms.RichTextBox();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kamion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vozač";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Problem";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Komentar";
            // 
            // txtKamion
            // 
            this.txtKamion.Location = new System.Drawing.Point(360, 72);
            this.txtKamion.Name = "txtKamion";
            this.txtKamion.ReadOnly = true;
            this.txtKamion.Size = new System.Drawing.Size(219, 20);
            this.txtKamion.TabIndex = 4;
            // 
            // txtVozac
            // 
            this.txtVozac.Location = new System.Drawing.Point(360, 120);
            this.txtVozac.Name = "txtVozac";
            this.txtVozac.ReadOnly = true;
            this.txtVozac.Size = new System.Drawing.Size(219, 20);
            this.txtVozac.TabIndex = 5;
            // 
            // rtbProblem
            // 
            this.rtbProblem.Location = new System.Drawing.Point(360, 175);
            this.rtbProblem.Name = "rtbProblem";
            this.rtbProblem.ReadOnly = true;
            this.rtbProblem.Size = new System.Drawing.Size(219, 106);
            this.rtbProblem.TabIndex = 6;
            this.rtbProblem.Text = "";
            // 
            // rtbKomentar
            // 
            this.rtbKomentar.Location = new System.Drawing.Point(360, 337);
            this.rtbKomentar.Name = "rtbKomentar";
            this.rtbKomentar.Size = new System.Drawing.Size(219, 93);
            this.rtbKomentar.TabIndex = 7;
            this.rtbKomentar.Text = "";
            // 
            // btnSnimi
            // 
            this.btnSnimi.Location = new System.Drawing.Point(360, 453);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(218, 23);
            this.btnSnimi.TabIndex = 8;
            this.btnSnimi.Text = "Spasi komentar";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(360, 24);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 9;
            this.txtId.Visible = false;
            // 
            // frmKvarDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 488);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.rtbKomentar);
            this.Controls.Add(this.rtbProblem);
            this.Controls.Add(this.txtVozac);
            this.Controls.Add(this.txtKamion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmKvarDetalji";
            this.Text = "frmKvarDetalji";
            this.Load += new System.EventHandler(this.frmKvarDetalji_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKamion;
        private System.Windows.Forms.TextBox txtVozac;
        private System.Windows.Forms.RichTextBox rtbProblem;
        private System.Windows.Forms.RichTextBox rtbKomentar;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.TextBox txtId;
    }
}