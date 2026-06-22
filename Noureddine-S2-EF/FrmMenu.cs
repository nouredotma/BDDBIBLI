using System;
using System.Windows.Forms;

namespace Noureddine_S2_EF
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void OuvrirForm(Form f)
        {
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog(this);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OuvrirForm(new FrmDashboard());
        }

        private void btnAdherents_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La gestion des adhérents n'est pas demandée.");
        }

        private void btnLivres_Click(object sender, EventArgs e)
        {
            OuvrirForm(new FrmLivre());
        }

        private void btnLocations_Click(object sender, EventArgs e)
        {
            OuvrirForm(new FrmLocation());
        }

        private void btnImpression_Click(object sender, EventArgs e)
        {
            OuvrirForm(new FrmImpression());
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
