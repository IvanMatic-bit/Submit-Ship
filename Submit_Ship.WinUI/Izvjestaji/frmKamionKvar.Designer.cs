
namespace Submit_Ship.WinUI.Izvjestaji
{
    partial class frmKamionKvar
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
            this.rvKamionKvar = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cmbKamion = new System.Windows.Forms.ComboBox();
            this.bsKvarovi = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsKvarovi)).BeginInit();
            this.SuspendLayout();
            // 
            // rvKamionKvar
            // 
            this.rvKamionKvar.LocalReport.ReportEmbeddedResource = "Submit_Ship.WinUI.Izvjestaji.rptKamionKvar.rdlc";
            this.rvKamionKvar.Location = new System.Drawing.Point(12, 76);
            this.rvKamionKvar.Name = "rvKamionKvar";
            this.rvKamionKvar.ServerReport.BearerToken = null;
            this.rvKamionKvar.Size = new System.Drawing.Size(776, 362);
            this.rvKamionKvar.TabIndex = 0;
            // 
            // cmbKamion
            // 
            this.cmbKamion.FormattingEnabled = true;
            this.cmbKamion.Location = new System.Drawing.Point(13, 33);
            this.cmbKamion.Name = "cmbKamion";
            this.cmbKamion.Size = new System.Drawing.Size(321, 21);
            this.cmbKamion.TabIndex = 1;
            this.cmbKamion.SelectedIndexChanged += new System.EventHandler(this.cmbKamion_SelectedIndexChanged);
            // 
            // frmKamionKvar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbKamion);
            this.Controls.Add(this.rvKamionKvar);
            this.Name = "frmKamionKvar";
            this.Text = "frmKamionKvar";
            this.Load += new System.EventHandler(this.frmKamionKvar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsKvarovi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvKamionKvar;
        private System.Windows.Forms.ComboBox cmbKamion;
        private System.Windows.Forms.BindingSource bsKvarovi;
    }
}