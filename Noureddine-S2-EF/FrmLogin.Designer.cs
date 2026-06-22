namespace Noureddine_S2_EF
{
    partial class FrmLogin
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
            this.lblMotDePasse = new System.Windows.Forms.Label();
            this.txtMotDePasse = new System.Windows.Forms.TextBox();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitre.Location = new System.Drawing.Point(200, 51);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(256, 29);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Bibli - Espace Admin";
            this.lblTitre.Click += new System.EventHandler(this.lblTitre_Click);
            // 
            // lblMotDePasse
            // 
            this.lblMotDePasse.AutoSize = true;
            this.lblMotDePasse.Location = new System.Drawing.Point(115, 128);
            this.lblMotDePasse.Name = "lblMotDePasse";
            this.lblMotDePasse.Size = new System.Drawing.Size(89, 16);
            this.lblMotDePasse.TabIndex = 1;
            this.lblMotDePasse.Text = "Mot de passe";
            // 
            // txtMotDePasse
            // 
            this.txtMotDePasse.Location = new System.Drawing.Point(235, 125);
            this.txtMotDePasse.Name = "txtMotDePasse";
            this.txtMotDePasse.PasswordChar = '*';
            this.txtMotDePasse.Size = new System.Drawing.Size(280, 22);
            this.txtMotDePasse.TabIndex = 2;
            // 
            // btnConnexion
            // 
            this.btnConnexion.BackColor = System.Drawing.Color.LightGreen;
            this.btnConnexion.Location = new System.Drawing.Point(155, 198);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(140, 45);
            this.btnConnexion.TabIndex = 3;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = false;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.LightGray;
            this.btnQuitter.Location = new System.Drawing.Point(335, 198);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(140, 45);
            this.btnQuitter.TabIndex = 4;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btnConnexion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 300);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.txtMotDePasse);
            this.Controls.Add(this.lblMotDePasse);
            this.Controls.Add(this.lblTitre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblMotDePasse;
        private System.Windows.Forms.TextBox txtMotDePasse;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Button btnQuitter;
    }
}
