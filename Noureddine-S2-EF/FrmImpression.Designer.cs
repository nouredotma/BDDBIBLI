namespace Noureddine_S2_EF
{
    partial class FrmImpression
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImpression));
            this.grpMenu = new System.Windows.Forms.GroupBox();
            this.grpLocationsDates = new System.Windows.Forms.GroupBox();
            this.btnImprimerLocations = new System.Windows.Forms.Button();
            this.dtpDateFin = new System.Windows.Forms.DateTimePicker();
            this.dtpDateDebut = new System.Windows.Forms.DateTimePicker();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.lblOption3 = new System.Windows.Forms.Label();
            this.lblOption2 = new System.Windows.Forms.Label();
            this.lblOption1 = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.grpMenu.SuspendLayout();
            this.grpLocationsDates.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.grpLocationsDates);
            this.grpMenu.Controls.Add(this.lblOption3);
            this.grpMenu.Controls.Add(this.lblOption2);
            this.grpMenu.Controls.Add(this.lblOption1);
            this.grpMenu.Location = new System.Drawing.Point(100, 58);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(560, 280);
            this.grpMenu.TabIndex = 0;
            this.grpMenu.TabStop = false;
            this.grpMenu.Text = "Sous-menu impression";
            // 
            // grpLocationsDates
            // 
            this.grpLocationsDates.Controls.Add(this.btnImprimerLocations);
            this.grpLocationsDates.Controls.Add(this.dtpDateFin);
            this.grpLocationsDates.Controls.Add(this.dtpDateDebut);
            this.grpLocationsDates.Controls.Add(this.lblDateFin);
            this.grpLocationsDates.Controls.Add(this.lblDateDebut);
            this.grpLocationsDates.Location = new System.Drawing.Point(23, 120);
            this.grpLocationsDates.Name = "grpLocationsDates";
            this.grpLocationsDates.Size = new System.Drawing.Size(510, 140);
            this.grpLocationsDates.TabIndex = 3;
            this.grpLocationsDates.TabStop = false;
            this.grpLocationsDates.Text = "Imprimer les locations entre deux dates";
            // 
            // btnImprimerLocations
            // 
            this.btnImprimerLocations.BackColor = System.Drawing.Color.LightGreen;
            this.btnImprimerLocations.Location = new System.Drawing.Point(180, 90);
            this.btnImprimerLocations.Name = "btnImprimerLocations";
            this.btnImprimerLocations.Size = new System.Drawing.Size(150, 35);
            this.btnImprimerLocations.TabIndex = 4;
            this.btnImprimerLocations.Text = "Imprimer";
            this.btnImprimerLocations.UseVisualStyleBackColor = false;
            this.btnImprimerLocations.Click += new System.EventHandler(this.btnImprimerLocations_Click);
            // 
            // dtpDateFin
            // 
            this.dtpDateFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFin.Location = new System.Drawing.Point(180, 55);
            this.dtpDateFin.Name = "dtpDateFin";
            this.dtpDateFin.Size = new System.Drawing.Size(200, 22);
            this.dtpDateFin.TabIndex = 3;
            // 
            // dtpDateDebut
            // 
            this.dtpDateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateDebut.Location = new System.Drawing.Point(180, 25);
            this.dtpDateDebut.Name = "dtpDateDebut";
            this.dtpDateDebut.Size = new System.Drawing.Size(200, 22);
            this.dtpDateDebut.TabIndex = 2;
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Location = new System.Drawing.Point(20, 58);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(58, 16);
            this.lblDateFin.TabIndex = 1;
            this.lblDateFin.Text = "Date fin :";
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Location = new System.Drawing.Point(20, 28);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(79, 16);
            this.lblDateDebut.TabIndex = 0;
            this.lblDateDebut.Text = "Date début :";
            // 
            // lblOption3
            // 
            this.lblOption3.AutoSize = true;
            this.lblOption3.Location = new System.Drawing.Point(20, 95);
            this.lblOption3.Name = "lblOption3";
            this.lblOption3.Size = new System.Drawing.Size(259, 16);
            this.lblOption3.TabIndex = 2;
            this.lblOption3.Text = "• Imprimer les locations entre deux dates ↓";
            // 
            // lblOption2
            // 
            this.lblOption2.AutoSize = true;
            this.lblOption2.ForeColor = System.Drawing.Color.Gray;
            this.lblOption2.Location = new System.Drawing.Point(20, 65);
            this.lblOption2.Name = "lblOption2";
            this.lblOption2.Size = new System.Drawing.Size(125, 16);
            this.lblOption2.TabIndex = 1;
            this.lblOption2.Text = "• Imprimer les livres";
            // 
            // lblOption1
            // 
            this.lblOption1.AutoSize = true;
            this.lblOption1.ForeColor = System.Drawing.Color.Gray;
            this.lblOption1.Location = new System.Drawing.Point(20, 35);
            this.lblOption1.Name = "lblOption1";
            this.lblOption1.Size = new System.Drawing.Size(153, 16);
            this.lblOption1.TabIndex = 0;
            this.lblOption1.Text = "• Imprimer les adhérents";
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(330, 358);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(100, 35);
            this.btnFermer.TabIndex = 1;
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
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // FrmImpression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.grpMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmImpression";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmImpression";
            this.Load += new System.EventHandler(this.FrmImpression_Load);
            this.grpMenu.ResumeLayout(false);
            this.grpMenu.PerformLayout();
            this.grpLocationsDates.ResumeLayout(false);
            this.grpLocationsDates.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMenu;
        private System.Windows.Forms.Label lblOption1;
        private System.Windows.Forms.Label lblOption2;
        private System.Windows.Forms.Label lblOption3;
        private System.Windows.Forms.GroupBox grpLocationsDates;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.DateTimePicker dtpDateDebut;
        private System.Windows.Forms.DateTimePicker dtpDateFin;
        private System.Windows.Forms.Button btnImprimerLocations;
        private System.Windows.Forms.Button btnFermer;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
