using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Noureddine_S2_EF
{
    public partial class FrmProfil : Form
    {
        string chaine = "server=127.0.0.1;database=bddbibli;uid=root;pwd=;";

        public FrmProfil()
        {
            InitializeComponent();
        }

        private void FrmProfil_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(chaine);
            con.Open();

            string sql = "SELECT * FROM adherent WHERE idadherent = @idadherent";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@idadherent", Session.IdAdherentConnecte);

            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtNom.Text = dr["nom"].ToString();
                txtPrenom.Text = dr["prenom"].ToString();
                txtEmail.Text = dr["email"].ToString();
                txtMotDePasse.Text = dr["motdepasse"].ToString();
                dtpDateInscription.Value = Convert.ToDateTime(dr["dateinscription"]);
            }

            dr.Close();
            con.Close();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(chaine);
            con.Open();

            string sql = "UPDATE adherent SET nom=@nom, prenom=@prenom, email=@email, motdepasse=@motdepasse WHERE idadherent=@idadherent";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@nom", txtNom.Text);
            cmd.Parameters.AddWithValue("@prenom", txtPrenom.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@motdepasse", txtMotDePasse.Text);
            cmd.Parameters.AddWithValue("@idadherent", Session.IdAdherentConnecte);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Modifications enregistrées.");
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
