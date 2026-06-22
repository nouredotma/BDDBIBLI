using System;
using System.Windows.Forms;

namespace Noureddine_S2_EF
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if (txtMotDePasse.Text == "admin")
            {
                this.Hide();
                FrmMenu menu = new FrmMenu();
                menu.ShowDialog();

                // Ne pas rouvrir le login si Déconnexion a fermé l'application
                if (this.IsDisposed)
                    return;

                txtMotDePasse.Clear();
                this.Show();
            }
            else
            {
                MessageBox.Show("Mot de passe incorrect.");
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblTitre_Click(object sender, EventArgs e)
        {

        }
    }
}
