namespace Noureddine_S2_EF
{
    partial class FrmMenu
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
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnAdherents = new System.Windows.Forms.Button();
            this.btnLivres = new System.Windows.Forms.Button();
            this.btnLocations = new System.Windows.Forms.Button();
            this.btnImpression = new System.Windows.Forms.Button();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitre.Location = new System.Drawing.Point(257, 55);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(84, 29);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Menu:";
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(59, 105);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(480, 45);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnAdherents
            // 
            this.btnAdherents.Location = new System.Drawing.Point(59, 155);
            this.btnAdherents.Name = "btnAdherents";
            this.btnAdherents.Size = new System.Drawing.Size(480, 45);
            this.btnAdherents.TabIndex = 2;
            this.btnAdherents.Text = "Gestion des adhérents";
            this.btnAdherents.UseVisualStyleBackColor = true;
            this.btnAdherents.Click += new System.EventHandler(this.btnAdherents_Click);
            // 
            // btnLivres
            // 
            this.btnLivres.Location = new System.Drawing.Point(59, 205);
            this.btnLivres.Name = "btnLivres";
            this.btnLivres.Size = new System.Drawing.Size(480, 45);
            this.btnLivres.TabIndex = 3;
            this.btnLivres.Text = "Gestion des livres";
            this.btnLivres.UseVisualStyleBackColor = true;
            this.btnLivres.Click += new System.EventHandler(this.btnLivres_Click);
            // 
            // btnLocations
            // 
            this.btnLocations.Location = new System.Drawing.Point(59, 255);
            this.btnLocations.Name = "btnLocations";
            this.btnLocations.Size = new System.Drawing.Size(480, 45);
            this.btnLocations.TabIndex = 4;
            this.btnLocations.Text = "Gestion des locations";
            this.btnLocations.UseVisualStyleBackColor = true;
            this.btnLocations.Click += new System.EventHandler(this.btnLocations_Click);
            // 
            // btnImpression
            // 
            this.btnImpression.Location = new System.Drawing.Point(59, 305);
            this.btnImpression.Name = "btnImpression";
            this.btnImpression.Size = new System.Drawing.Size(480, 45);
            this.btnImpression.TabIndex = 5;
            this.btnImpression.Text = "Impression";
            this.btnImpression.UseVisualStyleBackColor = true;
            this.btnImpression.Click += new System.EventHandler(this.btnImpression_Click);
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.BackColor = System.Drawing.Color.LightCoral;
            this.btnDeconnexion.Location = new System.Drawing.Point(59, 365);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(480, 45);
            this.btnDeconnexion.TabIndex = 6;
            this.btnDeconnexion.Text = "Déconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = false;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 460);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.btnImpression);
            this.Controls.Add(this.btnLocations);
            this.Controls.Add(this.btnLivres);
            this.Controls.Add(this.btnAdherents);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.lblTitre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnAdherents;
        private System.Windows.Forms.Button btnLivres;
        private System.Windows.Forms.Button btnLocations;
        private System.Windows.Forms.Button btnImpression;
        private System.Windows.Forms.Button btnDeconnexion;
    }
}
