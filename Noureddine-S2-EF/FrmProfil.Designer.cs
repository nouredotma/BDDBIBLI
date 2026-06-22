namespace Noureddine_S2_EF
{
    partial class FrmProfil
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
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblMotDePasse = new System.Windows.Forms.Label();
            this.lblDateInscription = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMotDePasse = new System.Windows.Forms.TextBox();
            this.dtpDateInscription = new System.Windows.Forms.DateTimePicker();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(55, 33);
            this.lblNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(55, 74);
            this.lblPrenom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(43, 13);
            this.lblPrenom.TabIndex = 1;
            this.lblPrenom.Text = "Prénom";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(55, 115);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // lblMotDePasse
            // 
            this.lblMotDePasse.AutoSize = true;
            this.lblMotDePasse.Location = new System.Drawing.Point(55, 155);
            this.lblMotDePasse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMotDePasse.Name = "lblMotDePasse";
            this.lblMotDePasse.Size = new System.Drawing.Size(71, 13);
            this.lblMotDePasse.TabIndex = 3;
            this.lblMotDePasse.Text = "Mot de passe";
            // 
            // lblDateInscription
            // 
            this.lblDateInscription.AutoSize = true;
            this.lblDateInscription.Location = new System.Drawing.Point(55, 196);
            this.lblDateInscription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateInscription.Name = "lblDateInscription";
            this.lblDateInscription.Size = new System.Drawing.Size(80, 13);
            this.lblDateInscription.TabIndex = 4;
            this.lblDateInscription.Text = "Date inscription";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(160, 31);
            this.txtNom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(241, 20);
            this.txtNom.TabIndex = 5;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(160, 72);
            this.txtPrenom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(241, 20);
            this.txtPrenom.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(160, 112);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(241, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // txtMotDePasse
            // 
            this.txtMotDePasse.Location = new System.Drawing.Point(160, 153);
            this.txtMotDePasse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMotDePasse.Name = "txtMotDePasse";
            this.txtMotDePasse.PasswordChar = '*';
            this.txtMotDePasse.Size = new System.Drawing.Size(241, 20);
            this.txtMotDePasse.TabIndex = 8;
            // 
            // dtpDateInscription
            // 
            this.dtpDateInscription.Enabled = false;
            this.dtpDateInscription.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateInscription.Location = new System.Drawing.Point(160, 194);
            this.dtpDateInscription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDateInscription.Name = "dtpDateInscription";
            this.dtpDateInscription.Size = new System.Drawing.Size(241, 20);
            this.dtpDateInscription.TabIndex = 9;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.LightGreen;
            this.btnEnregistrer.Location = new System.Drawing.Point(130, 245);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(165, 32);
            this.btnEnregistrer.TabIndex = 10;
            this.btnEnregistrer.Text = "Enregistrer les modifications";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(325, 245);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 32);
            this.btnFermer.TabIndex = 11;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // FrmProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 301);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.dtpDateInscription);
            this.Controls.Add(this.txtMotDePasse);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblDateInscription);
            this.Controls.Add(this.lblMotDePasse);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FrmProfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mon Profil";
            this.Load += new System.EventHandler(this.FrmProfil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblMotDePasse;
        private System.Windows.Forms.Label lblDateInscription;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMotDePasse;
        private System.Windows.Forms.DateTimePicker dtpDateInscription;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnFermer;
    }
}
