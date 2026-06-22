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

        private void OpenChild(Form form)
        {
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenChild(new FrmDashboard());
        }

        private void btnAdherents_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La gestion des adhérents n'est pas demandée dans l'examen.",
                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLivres_Click(object sender, EventArgs e)
        {
            OpenChild(new FrmLivre());
        }

        private void btnLocations_Click(object sender, EventArgs e)
        {
            OpenChild(new FrmLocation());
        }

        private void btnImpression_Click(object sender, EventArgs e)
        {
            OpenChild(new FrmImpression());
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
