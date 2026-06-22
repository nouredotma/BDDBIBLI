namespace Noureddine_S2_EF
{
    partial class FrmMesLocations
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dgvMesLocations = new System.Windows.Forms.DataGridView();
            this.btnImprimer = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesLocations)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMesLocations
            // 
            this.dgvMesLocations.AllowUserToAddRows = false;
            this.dgvMesLocations.AllowUserToDeleteRows = false;
            this.dgvMesLocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMesLocations.Location = new System.Drawing.Point(12, 12);
            this.dgvMesLocations.Name = "dgvMesLocations";
            this.dgvMesLocations.ReadOnly = true;
            this.dgvMesLocations.RowHeadersWidth = 51;
            this.dgvMesLocations.Size = new System.Drawing.Size(880, 360);
            this.dgvMesLocations.TabIndex = 0;
            // 
            // btnImprimer
            // 
            this.btnImprimer.Location = new System.Drawing.Point(280, 385);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(200, 35);
            this.btnImprimer.TabIndex = 1;
            this.btnImprimer.Text = "Imprimer mes locations";
            this.btnImprimer.UseVisualStyleBackColor = true;
            this.btnImprimer.Click += new System.EventHandler(this.btnImprimer_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(520, 385);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(100, 35);
            this.btnFermer.TabIndex = 2;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // FrmMesLocations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 430);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnImprimer);
            this.Controls.Add(this.dgvMesLocations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmMesLocations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mes Locations";
            this.Load += new System.EventHandler(this.FrmMesLocations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesLocations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMesLocations;
        private System.Windows.Forms.Button btnImprimer;
        private System.Windows.Forms.Button btnFermer;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
