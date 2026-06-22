using System;
using System.Windows.Forms;

namespace Noureddine_S2_EF
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard f = new FrmDashboard();
            f.ShowDialog();
        }

        private void btnAdherents_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La gestion des adhérents n'est pas demandée.");
        }

        private void btnLivres_Click(object sender, EventArgs e)
        {
            FrmLivre f = new FrmLivre();
            f.ShowDialog();
        }

        private void btnLocations_Click(object sender, EventArgs e)
        {
            FrmLocation f = new FrmLocation();
            f.ShowDialog();
        }

        private void btnImpression_Click(object sender, EventArgs e)
        {
            FrmImpression f = new FrmImpression();
            f.ShowDialog();
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
