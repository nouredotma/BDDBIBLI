using System;
using System.Windows.Forms;

namespace Noureddine_S2_EF
{
    public partial class FrmUserMenu : Form
    {
        public FrmUserMenu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void OuvrirForm(Form f)
        {
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog(this);
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            OuvrirForm(new FrmProfil());
        }

        private void btnMesLocations_Click(object sender, EventArgs e)
        {
            OuvrirForm(new FrmMesLocations());
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblTitre_Click(object sender, EventArgs e)
        {

        }
    }
}
