namespace Noureddine_S2_EF
{
    partial class FrmUserMenu
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
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnProfil = new System.Windows.Forms.Button();
            this.btnMesLocations = new System.Windows.Forms.Button();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitre.Location = new System.Drawing.Point(164, 44);
            this.lblTitre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(118, 24);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "User Menu:";
            this.lblTitre.Click += new System.EventHandler(this.lblTitre_Click);
            // 
            // btnProfil
            // 
            this.btnProfil.Location = new System.Drawing.Point(44, 81);
            this.btnProfil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(360, 37);
            this.btnProfil.TabIndex = 1;
            this.btnProfil.Text = "Mon Profil";
            this.btnProfil.UseVisualStyleBackColor = true;
            this.btnProfil.Click += new System.EventHandler(this.btnProfil_Click);
            // 
            // btnMesLocations
            // 
            this.btnMesLocations.Location = new System.Drawing.Point(44, 129);
            this.btnMesLocations.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMesLocations.Name = "btnMesLocations";
            this.btnMesLocations.Size = new System.Drawing.Size(360, 37);
            this.btnMesLocations.TabIndex = 2;
            this.btnMesLocations.Text = "Mes Locations";
            this.btnMesLocations.UseVisualStyleBackColor = true;
            this.btnMesLocations.Click += new System.EventHandler(this.btnMesLocations_Click);
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.BackColor = System.Drawing.Color.LightCoral;
            this.btnDeconnexion.Location = new System.Drawing.Point(44, 186);
            this.btnDeconnexion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(360, 37);
            this.btnDeconnexion.TabIndex = 3;
            this.btnDeconnexion.Text = "Déconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = false;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // FrmUserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 276);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.btnMesLocations);
            this.Controls.Add(this.btnProfil);
            this.Controls.Add(this.lblTitre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FrmUserMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUserMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnProfil;
        private System.Windows.Forms.Button btnMesLocations;
        private System.Windows.Forms.Button btnDeconnexion;
    }
}
