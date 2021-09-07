
namespace Submit_Ship.WinUI.Kamion
{
    partial class frmKamion
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
            this.Kamioni = new System.Windows.Forms.GroupBox();
            this.dgvKamioni = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.Kamioni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKamioni)).BeginInit();
            this.SuspendLayout();
            // 
            // Kamioni
            // 
            this.Kamioni.Controls.Add(this.dgvKamioni);
            this.Kamioni.Location = new System.Drawing.Point(12, 116);
            this.Kamioni.Name = "Kamioni";
            this.Kamioni.Size = new System.Drawing.Size(776, 322);
            this.Kamioni.TabIndex = 0;
            this.Kamioni.TabStop = false;
            this.Kamioni.Text = "Kamioni";
            // 
            // dgvKamioni
            // 
            this.dgvKamioni.AllowUserToAddRows = false;
            this.dgvKamioni.AllowUserToDeleteRows = false;
            this.dgvKamioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKamioni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id});
            this.dgvKamioni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKamioni.Location = new System.Drawing.Point(3, 16);
            this.dgvKamioni.Name = "dgvKamioni";
            this.dgvKamioni.ReadOnly = true;
            this.dgvKamioni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKamioni.Size = new System.Drawing.Size(770, 303);
            this.dgvKamioni.TabIndex = 0;
            this.dgvKamioni.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvKamioni_MouseDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(235, 52);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(107, 28);
            this.btnPrikazi.TabIndex = 1;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Location = new System.Drawing.Point(15, 59);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(192, 21);
            this.cmbFilter.TabIndex = 2;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // frmKamion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.Kamioni);
            this.Name = "frmKamion";
            this.Text = "frmKamion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmKamion_Load);
            this.Kamioni.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKamioni)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Kamioni;
        private System.Windows.Forms.DataGridView dgvKamioni;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.ComboBox cmbFilter;
    }
}