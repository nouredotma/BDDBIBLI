namespace Noureddine_S2_EF
{
    partial class FrmLocation
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
            this.dgvLocations = new System.Windows.Forms.DataGridView();
            this.grpSaisie = new System.Windows.Forms.GroupBox();
            this.chkDateRetour = new System.Windows.Forms.CheckBox();
            this.dtpDateRetour = new System.Windows.Forms.DateTimePicker();
            this.dtpDateLocation = new System.Windows.Forms.DateTimePicker();
            this.txtStatut = new System.Windows.Forms.TextBox();
            this.txtIdAdherent = new System.Windows.Forms.TextBox();
            this.txtIdLivre = new System.Windows.Forms.TextBox();
            this.txtIdLocation = new System.Windows.Forms.TextBox();
            this.lblStatut = new System.Windows.Forms.Label();
            this.lblDateRetour = new System.Windows.Forms.Label();
            this.lblDateLocation = new System.Windows.Forms.Label();
            this.lblIdAdherent = new System.Windows.Forms.Label();
            this.lblIdLivre = new System.Windows.Forms.Label();
            this.lblIdLocation = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnImprimer = new System.Windows.Forms.Button();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.lblRecherche = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocations)).BeginInit();
            this.grpSaisie.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLocations
            // 
            this.dgvLocations.AllowUserToAddRows = false;
            this.dgvLocations.AllowUserToDeleteRows = false;
            this.dgvLocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocations.Location = new System.Drawing.Point(12, 12);
            this.dgvLocations.MultiSelect = false;
            this.dgvLocations.Name = "dgvLocations";
            this.dgvLocations.ReadOnly = true;
            this.dgvLocations.RowHeadersWidth = 51;
            this.dgvLocations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLocations.Size = new System.Drawing.Size(880, 200);
            this.dgvLocations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLocations.TabIndex = 0;
            dgvLocations.SelectionChanged += new System.EventHandler(this.dgvLocations_SelectionChanged);
            this.dgvLocations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLocations_CellClick);
            // 
            // grpSaisie
            // 
            this.grpSaisie.Controls.Add(this.chkDateRetour);
            this.grpSaisie.Controls.Add(this.dtpDateRetour);
            this.grpSaisie.Controls.Add(this.dtpDateLocation);
            this.grpSaisie.Controls.Add(this.txtStatut);
            this.grpSaisie.Controls.Add(this.txtIdAdherent);
            this.grpSaisie.Controls.Add(this.txtIdLivre);
            this.grpSaisie.Controls.Add(this.txtIdLocation);
            this.grpSaisie.Controls.Add(this.lblStatut);
            this.grpSaisie.Controls.Add(this.lblDateRetour);
            this.grpSaisie.Controls.Add(this.lblDateLocation);
            this.grpSaisie.Controls.Add(this.lblIdAdherent);
            this.grpSaisie.Controls.Add(this.lblIdLivre);
            this.grpSaisie.Controls.Add(this.lblIdLocation);
            this.grpSaisie.Location = new System.Drawing.Point(12, 230);
            this.grpSaisie.Name = "grpSaisie";
            this.grpSaisie.Size = new System.Drawing.Size(880, 155);
            this.grpSaisie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSaisie.TabIndex = 1;
            this.grpSaisie.TabStop = false;
            this.grpSaisie.Text = "Saisie location";
            // 
            // chkDateRetour
            // 
            this.chkDateRetour.AutoSize = true;
            this.chkDateRetour.Location = new System.Drawing.Point(520, 73);
            this.chkDateRetour.Name = "chkDateRetour";
            this.chkDateRetour.Size = new System.Drawing.Size(18, 17);
            this.chkDateRetour.TabIndex = 12;
            this.chkDateRetour.UseVisualStyleBackColor = true;
            this.chkDateRetour.CheckedChanged += new System.EventHandler(this.chkDateRetour_CheckedChanged);
            // 
            // dtpDateRetour
            // 
            this.dtpDateRetour.Enabled = false;
            this.dtpDateRetour.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateRetour.Location = new System.Drawing.Point(640, 70);
            this.dtpDateRetour.Name = "dtpDateRetour";
            this.dtpDateRetour.Size = new System.Drawing.Size(200, 22);
            this.dtpDateRetour.TabIndex = 11;
            // 
            // dtpDateLocation
            // 
            this.dtpDateLocation.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateLocation.Location = new System.Drawing.Point(640, 27);
            this.dtpDateLocation.Name = "dtpDateLocation";
            this.dtpDateLocation.Size = new System.Drawing.Size(200, 22);
            this.dtpDateLocation.TabIndex = 10;
            // 
            // txtStatut
            // 
            this.txtStatut.Location = new System.Drawing.Point(120, 117);
            this.txtStatut.Name = "txtStatut";
            this.txtStatut.Size = new System.Drawing.Size(200, 22);
            this.txtStatut.TabIndex = 9;
            // 
            // txtIdAdherent
            // 
            this.txtIdAdherent.Location = new System.Drawing.Point(120, 87);
            this.txtIdAdherent.Name = "txtIdAdherent";
            this.txtIdAdherent.Size = new System.Drawing.Size(200, 22);
            this.txtIdAdherent.TabIndex = 8;
            // 
            // txtIdLivre
            // 
            this.txtIdLivre.Location = new System.Drawing.Point(120, 57);
            this.txtIdLivre.Name = "txtIdLivre";
            this.txtIdLivre.Size = new System.Drawing.Size(200, 22);
            this.txtIdLivre.TabIndex = 7;
            // 
            // txtIdLocation
            // 
            this.txtIdLocation.Location = new System.Drawing.Point(120, 27);
            this.txtIdLocation.Name = "txtIdLocation";
            this.txtIdLocation.ReadOnly = true;
            this.txtIdLocation.Size = new System.Drawing.Size(200, 22);
            this.txtIdLocation.TabIndex = 6;
            // 
            // lblStatut
            // 
            this.lblStatut.AutoSize = true;
            this.lblStatut.Location = new System.Drawing.Point(15, 120);
            this.lblStatut.Name = "lblStatut";
            this.lblStatut.Size = new System.Drawing.Size(43, 16);
            this.lblStatut.TabIndex = 5;
            this.lblStatut.Text = "Statut";
            // 
            // lblDateRetour
            // 
            this.lblDateRetour.AutoSize = true;
            this.lblDateRetour.Location = new System.Drawing.Point(420, 73);
            this.lblDateRetour.Name = "lblDateRetour";
            this.lblDateRetour.Size = new System.Drawing.Size(80, 16);
            this.lblDateRetour.TabIndex = 4;
            this.lblDateRetour.Text = "Date retour";
            // 
            // lblDateLocation
            // 
            this.lblDateLocation.AutoSize = true;
            this.lblDateLocation.Location = new System.Drawing.Point(420, 30);
            this.lblDateLocation.Name = "lblDateLocation";
            this.lblDateLocation.Size = new System.Drawing.Size(92, 16);
            this.lblDateLocation.TabIndex = 3;
            this.lblDateLocation.Text = "Date location";
            // 
            // lblIdAdherent
            // 
            this.lblIdAdherent.AutoSize = true;
            this.lblIdAdherent.Location = new System.Drawing.Point(15, 90);
            this.lblIdAdherent.Name = "lblIdAdherent";
            this.lblIdAdherent.Size = new System.Drawing.Size(76, 16);
            this.lblIdAdherent.TabIndex = 2;
            this.lblIdAdherent.Text = "Id adhérent";
            // 
            // lblIdLivre
            // 
            this.lblIdLivre.AutoSize = true;
            this.lblIdLivre.Location = new System.Drawing.Point(15, 60);
            this.lblIdLivre.Name = "lblIdLivre";
            this.lblIdLivre.Size = new System.Drawing.Size(49, 16);
            this.lblIdLivre.TabIndex = 1;
            this.lblIdLivre.Text = "Id livre";
            // 
            // lblIdLocation
            // 
            this.lblIdLocation.AutoSize = true;
            this.lblIdLocation.Location = new System.Drawing.Point(15, 30);
            this.lblIdLocation.Name = "lblIdLocation";
            this.lblIdLocation.Size = new System.Drawing.Size(72, 16);
            this.lblIdLocation.TabIndex = 0;
            this.lblIdLocation.Text = "Id location";
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.LightGreen;
            this.btnAjouter.Location = new System.Drawing.Point(12, 420);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(110, 40);
            this.btnAjouter.TabIndex = 2;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.LightBlue;
            this.btnModifier.Location = new System.Drawing.Point(128, 420);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(110, 40);
            this.btnModifier.TabIndex = 3;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnRechercher
            // 
            this.btnRechercher.BackColor = System.Drawing.Color.Khaki;
            this.btnRechercher.Location = new System.Drawing.Point(244, 420);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(110, 40);
            this.btnRechercher.TabIndex = 4;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = false;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.LightCoral;
            this.btnSupprimer.Location = new System.Drawing.Point(360, 420);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(110, 40);
            this.btnSupprimer.TabIndex = 5;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnImprimer
            // 
            this.btnImprimer.Location = new System.Drawing.Point(476, 420);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(110, 40);
            this.btnImprimer.TabIndex = 6;
            this.btnImprimer.Text = "Imprimer";
            this.btnImprimer.UseVisualStyleBackColor = true;
            this.btnImprimer.Click += new System.EventHandler(this.btnImprimer_Click);
            // 
            // txtRecherche
            // 
            this.txtRecherche.Location = new System.Drawing.Point(700, 392);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(192, 22);
            this.txtRecherche.TabIndex = 7;
            // 
            // lblRecherche
            // 
            this.lblRecherche.AutoSize = true;
            this.lblRecherche.Location = new System.Drawing.Point(590, 395);
            this.lblRecherche.Name = "lblRecherche";
            this.lblRecherche.Size = new System.Drawing.Size(94, 16);
            this.lblRecherche.TabIndex = 8;
            this.lblRecherche.Text = "Mot-clé statut";
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
            // FrmLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 480);
            this.Controls.Add(this.lblRecherche);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.btnImprimer);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.grpSaisie);
            this.Controls.Add(this.dgvLocations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmLocation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLocation";
            this.Load += new System.EventHandler(this.FrmLocation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocations)).EndInit();
            this.grpSaisie.ResumeLayout(false);
            this.grpSaisie.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLocations;
        private System.Windows.Forms.GroupBox grpSaisie;
        private System.Windows.Forms.TextBox txtIdLocation;
        private System.Windows.Forms.TextBox txtIdLivre;
        private System.Windows.Forms.TextBox txtIdAdherent;
        private System.Windows.Forms.TextBox txtStatut;
        private System.Windows.Forms.DateTimePicker dtpDateLocation;
        private System.Windows.Forms.DateTimePicker dtpDateRetour;
        private System.Windows.Forms.CheckBox chkDateRetour;
        private System.Windows.Forms.Label lblIdLocation;
        private System.Windows.Forms.Label lblIdLivre;
        private System.Windows.Forms.Label lblIdAdherent;
        private System.Windows.Forms.Label lblDateLocation;
        private System.Windows.Forms.Label lblDateRetour;
        private System.Windows.Forms.Label lblStatut;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnImprimer;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Label lblRecherche;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
