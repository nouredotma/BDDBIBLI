using System;
using System.Windows.Forms;

namespace Noureddine_S2_EF
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if (txtMotDePasse.Text == "admin")
            {
                this.Hide();
                FrmMenu menu = new FrmMenu();
                menu.ShowDialog();
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
    }
}
