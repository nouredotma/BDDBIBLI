namespace Noureddine_S2_EF
{
    partial class FrmDashboard
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
            this.grpAdherents = new System.Windows.Forms.GroupBox();
            this.lblNbAdherents = new System.Windows.Forms.Label();
            this.grpLivres = new System.Windows.Forms.GroupBox();
            this.lblNbLivres = new System.Windows.Forms.Label();
            this.grpLocations = new System.Windows.Forms.GroupBox();
            this.lblNbLocations = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.grpAdherents.SuspendLayout();
            this.grpLivres.SuspendLayout();
            this.grpLocations.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAdherents
            // 
            this.grpAdherents.Controls.Add(this.lblNbAdherents);
            this.grpAdherents.Location = new System.Drawing.Point(45, 44);
            this.grpAdherents.Name = "grpAdherents";
            this.grpAdherents.Size = new System.Drawing.Size(280, 160);
            this.grpAdherents.TabIndex = 0;
            this.grpAdherents.TabStop = false;
            this.grpAdherents.Text = "Nombre d\'adhérents";
            // 
            // lblNbAdherents
            // 
            this.lblNbAdherents.BackColor = System.Drawing.Color.Blue;
            this.lblNbAdherents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNbAdherents.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.lblNbAdherents.Location = new System.Drawing.Point(3, 18);
            this.lblNbAdherents.Name = "lblNbAdherents";
            this.lblNbAdherents.Size = new System.Drawing.Size(274, 139);
            this.lblNbAdherents.TabIndex = 0;
            this.lblNbAdherents.Text = "0";
            this.lblNbAdherents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpLivres
            // 
            this.grpLivres.Controls.Add(this.lblNbLivres);
            this.grpLivres.Location = new System.Drawing.Point(355, 44);
            this.grpLivres.Name = "grpLivres";
            this.grpLivres.Size = new System.Drawing.Size(280, 160);
            this.grpLivres.TabIndex = 1;
            this.grpLivres.TabStop = false;
            this.grpLivres.Text = "Nombre de livres";
            // 
            // lblNbLivres
            // 
            this.lblNbLivres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNbLivres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNbLivres.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.lblNbLivres.Location = new System.Drawing.Point(3, 18);
            this.lblNbLivres.Name = "lblNbLivres";
            this.lblNbLivres.Size = new System.Drawing.Size(274, 139);
            this.lblNbLivres.TabIndex = 0;
            this.lblNbLivres.Text = "0";
            this.lblNbLivres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpLocations
            // 
            this.grpLocations.Controls.Add(this.lblNbLocations);
            this.grpLocations.Location = new System.Drawing.Point(665, 44);
            this.grpLocations.Name = "grpLocations";
            this.grpLocations.Size = new System.Drawing.Size(280, 160);
            this.grpLocations.TabIndex = 2;
            this.grpLocations.TabStop = false;
            this.grpLocations.Text = "Nombre de locations";
            // 
            // lblNbLocations
            // 
            this.lblNbLocations.BackColor = System.Drawing.Color.Lime;
            this.lblNbLocations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNbLocations.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.lblNbLocations.Location = new System.Drawing.Point(3, 18);
            this.lblNbLocations.Name = "lblNbLocations";
            this.lblNbLocations.Size = new System.Drawing.Size(274, 139);
            this.lblNbLocations.TabIndex = 0;
            this.lblNbLocations.Text = "0";
            this.lblNbLocations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(455, 234);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(100, 35);
            this.btnFermer.TabIndex = 3;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 300);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.grpLocations);
            this.Controls.Add(this.grpLivres);
            this.Controls.Add(this.grpAdherents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDashboard";
            this.Load += new System.EventHandler(this.FrmDashboard_Load);
            this.grpAdherents.ResumeLayout(false);
            this.grpLivres.ResumeLayout(false);
            this.grpLocations.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAdherents;
        private System.Windows.Forms.Label lblNbAdherents;
        private System.Windows.Forms.GroupBox grpLivres;
        private System.Windows.Forms.Label lblNbLivres;
        private System.Windows.Forms.GroupBox grpLocations;
        private System.Windows.Forms.Label lblNbLocations;
        private System.Windows.Forms.Button btnFermer;
    }
}
