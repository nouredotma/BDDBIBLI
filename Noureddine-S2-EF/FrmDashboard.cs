using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Noureddine_S2_EF
{
    public partial class FrmDashboard : Form
    {
        // Chaine de connexion MySQL (modifier pwd si nécessaire)
        string chaine = "server=127.0.0.1;database=bddbibli;uid=root;pwd=;";

        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(chaine);
            con.Open();

            MySqlCommand cmd1 = new MySqlCommand("SELECT COUNT(*) FROM adherent", con);
            lblNbAdherents.Text = cmd1.ExecuteScalar().ToString();

            MySqlCommand cmd2 = new MySqlCommand("SELECT COUNT(*) FROM livre", con);
            lblNbLivres.Text = cmd2.ExecuteScalar().ToString();

            MySqlCommand cmd3 = new MySqlCommand("SELECT COUNT(*) FROM location", con);
            lblNbLocations.Text = cmd3.ExecuteScalar().ToString();

            con.Close();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
