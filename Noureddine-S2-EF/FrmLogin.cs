using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Noureddine_S2_EF
{
    public partial class FrmLogin : Form
    {
        string chaine = "server=127.0.0.1;database=bddbibli;uid=root;pwd=;";

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

                if (this.IsDisposed)
                    return;

                txtMotDePasse.Clear();
                this.Show();
            }
            else
            {
                MySqlConnection con = new MySqlConnection(chaine);
                con.Open();

                string sql = "SELECT idadherent FROM adherent WHERE motdepasse = @motdepasse";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@motdepasse", txtMotDePasse.Text);
                object result = cmd.ExecuteScalar();

                con.Close();

                if (result != null)
                {
                    Session.IdAdherentConnecte = Convert.ToInt32(result);

                    this.Hide();
                    FrmUserMenu menu = new FrmUserMenu();
                    menu.ShowDialog();

                    if (this.IsDisposed)
                        return;

                    Session.IdAdherentConnecte = 0;
                    txtMotDePasse.Clear();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Mot de passe incorrect.");
                }
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
