
namespace Submit_Ship.WinUI.Kamion
{
    partial class frmKamionDetalji
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
            this.txtProizvodac = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNosivost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDatumRegistracije = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clbOprema = new System.Windows.Forms.CheckedListBox();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proizvođač";
            // 
            // txtProizvodac
            // 
            this.txtProizvodac.Location = new System.Drawing.Point(96, 82);
            this.txtProizvodac.Name = "txtProizvodac";
            this.txtProizvodac.Size = new System.Drawing.Size(295, 20);
            this.txtProizvodac.TabIndex = 1;
            this.txtProizvodac.Validating += new System.ComponentModel.CancelEventHandler(this.txtProizvodac_Validating);
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(96, 150);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(295, 20);
            this.txtModel.TabIndex = 3;
            this.txtModel.Validating += new System.ComponentModel.CancelEventHandler(this.txtModel_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Model";
            // 
            // txtNosivost
            // 
            this.txtNosivost.Location = new System.Drawing.Point(96, 219);
            this.txtNosivost.Name = "txtNosivost";
            this.txtNosivost.Size = new System.Drawing.Size(295, 20);
            this.txtNosivost.TabIndex = 5;
            this.txtNosivost.Validating += new System.ComponentModel.CancelEventHandler(this.txtNosivost_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nosivost ( t )";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Datum registracije";
            // 
            // dtpDatumRegistracije
            // 
            this.dtpDatumRegistracije.Location = new System.Drawing.Point(96, 297);
            this.dtpDatumRegistracije.Name = "dtpDatumRegistracije";
            this.dtpDatumRegistracije.Size = new System.Drawing.Size(295, 20);
            this.dtpDatumRegistracije.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clbOprema);
            this.groupBox1.Location = new System.Drawing.Point(96, 350);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 150);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oprema";
            // 
            // clbOprema
            // 
            this.clbOprema.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbOprema.FormattingEnabled = true;
            this.clbOprema.Items.AddRange(new object[] {
            "Reduktor",
            "Spavaća kabina",
            "Kiper",
            "Hladnjača",
            "Cerada"});
            this.clbOprema.Location = new System.Drawing.Point(3, 16);
            this.clbOprema.Name = "clbOprema";
            this.clbOprema.Size = new System.Drawing.Size(289, 131);
            this.clbOprema.TabIndex = 0;
            // 
            // btnSnimi
            // 
            this.btnSnimi.Location = new System.Drawing.Point(99, 517);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(289, 23);
            this.btnSnimi.TabIndex = 9;
            this.btnSnimi.Text = "Snimi";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmKamionDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 575);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpDatumRegistracije);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNosivost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProizvodac);
            this.Controls.Add(this.label1);
            this.Name = "frmKamionDetalji";
            this.Text = "frmKamionDetalji";
            this.Load += new System.EventHandler(this.frmKamionDetalji_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProizvodac;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNosivost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDatumRegistracije;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox clbOprema;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}