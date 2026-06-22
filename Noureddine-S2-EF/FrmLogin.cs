using System;
using System.Windows.Forms;

namespace Noureddine_S2_EF
{
    public partial class FrmLogin : Form
    {
        private const string AdminPassword = "admin";

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if (txtMotDePasse.Text == AdminPassword)
            {
                Hide();
                using (var menu = new FrmMenu())
                {
                    menu.ShowDialog();
                }
                txtMotDePasse.Clear();
                Show();
            }
            else
            {
                MessageBox.Show("Mot de passe incorrect.", "Authentification",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMotDePasse.Clear();
                txtMotDePasse.Focus();
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
