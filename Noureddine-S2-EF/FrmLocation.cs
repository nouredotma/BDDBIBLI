using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Noureddine_S2_EF
{
    public partial class FrmLocation : Form
    {
        string chaine = "server=127.0.0.1;database=bddbibli;uid=root;pwd=;";

        DataTable dt;
        int i = 0;
        int indexLigne = -1;

        public FrmLocation()
        {
            InitializeComponent();
        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            Afficher();
            ViderSaisie();
        }

        private void ViderSaisie()
        {
            txtIdLocation.Clear();
            txtIdLivre.Clear();
            txtIdAdherent.Clear();
            txtStatut.Clear();
            dtpDateLocation.Value = DateTime.Today;
            dtpDateRetour.Value = DateTime.Today;
            chkDateRetour.Checked = false;
            dtpDateRetour.Enabled = false;
        }

        private void RemplirSaisie(DataGridViewRow row)
        {
            txtIdLocation.Text = row.Cells[0].Value.ToString();
            txtIdLivre.Text = row.Cells[1].Value.ToString();
            txtIdAdherent.Text = row.Cells[2].Value.ToString();
            dtpDateLocation.Value = Convert.ToDateTime(row.Cells[3].Value);

            if (row.Cells[4].Value == DBNull.Value)
                chkDateRetour.Checked = false;
            else
            {
                chkDateRetour.Checked = true;
                dtpDateRetour.Value = Convert.ToDateTime(row.Cells[4].Value);
            }

            txtStatut.Text = row.Cells[5].Value.ToString();
        }

        private void Afficher()
        {
            MySqlConnection con = new MySqlConnection(chaine);
            con.Open();

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM location", con);
            dt = new DataTable();
            da.Fill(dt);

            dgvLocations.DataSource = dt;
            dgvLocations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();
        }

        private void dgvLocations_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLocations.SelectedRows.Count > 0)
            {
                RemplirSaisie(dgvLocations.SelectedRows[0]);
            }
            else
            {
                ViderSaisie();
            }
        }

        private void dgvLocations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            // 2e clic sur la même ligne = désélectionner
            if (indexLigne == e.RowIndex)
            {
                dgvLocations.ClearSelection();
                indexLigne = -1;
                ViderSaisie();
            }
            else
            {
                indexLigne = e.RowIndex;
            }
        }

        private void chkDateRetour_CheckedChanged(object sender, EventArgs e)
        {
            dtpDateRetour.Enabled = chkDateRetour.Checked;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(chaine);
            con.Open();

            string sql = "INSERT INTO location (idlivre, idadherent, datelocation, dateretour, statut) VALUES (@idlivre, @idadherent, @datelocation, @dateretour, @statut)";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@idlivre", txtIdLivre.Text);
            cmd.Parameters.AddWithValue("@idadherent", txtIdAdherent.Text);
            cmd.Parameters.AddWithValue("@datelocation", dtpDateLocation.Value.ToString("yyyy-MM-dd"));

            if (chkDateRetour.Checked)
                cmd.Parameters.AddWithValue("@dateretour", dtpDateRetour.Value.ToString("yyyy-MM-dd"));
            else
                cmd.Parameters.AddWithValue("@dateretour", DBNull.Value);

            cmd.Parameters.AddWithValue("@statut", txtStatut.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            Afficher();
            dgvLocations.ClearSelection();
            indexLigne = -1;
            ViderSaisie();
            MessageBox.Show("Ajout effectué.");
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(chaine);
            con.Open();

            string sql = "UPDATE location SET idlivre=@idlivre, idadherent=@idadherent, datelocation=@datelocation, dateretour=@dateretour, statut=@statut WHERE idlocation=@idlocation";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@idlivre", txtIdLivre.Text);
            cmd.Parameters.AddWithValue("@idadherent", txtIdAdherent.Text);
            cmd.Parameters.AddWithValue("@datelocation", dtpDateLocation.Value.ToString("yyyy-MM-dd"));

            if (chkDateRetour.Checked)
                cmd.Parameters.AddWithValue("@dateretour", dtpDateRetour.Value.ToString("yyyy-MM-dd"));
            else
                cmd.Parameters.AddWithValue("@dateretour", DBNull.Value);

            cmd.Parameters.AddWithValue("@statut", txtStatut.Text);
            cmd.Parameters.AddWithValue("@idlocation", txtIdLocation.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            Afficher();
            MessageBox.Show("Modification effectuée.");
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            if (txtRecherche.Text == "")
            {
                Afficher();
                dgvLocations.ClearSelection();
                indexLigne = -1;
                ViderSaisie();
                return;
            }

            MySqlConnection con = new MySqlConnection(chaine);
            con.Open();

            string sql = "SELECT * FROM location WHERE statut LIKE @statut";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
            da.SelectCommand.Parameters.AddWithValue("@statut", "%" + txtRecherche.Text + "%");

            dt = new DataTable();
            da.Fill(dt);
            dgvLocations.DataSource = dt;

            con.Close();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(chaine);
            con.Open();

            string sql = "DELETE FROM location WHERE idlocation=@idlocation";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@idlocation", txtIdLocation.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            Afficher();
            dgvLocations.ClearSelection();
            indexLigne = -1;
            ViderSaisie();
            MessageBox.Show("Suppression effectuée.");
        }

        private void btnImprimer_Click(object sender, EventArgs e)
        {
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("Aucune location à imprimer.");
                return;
            }

            i = 0;
            AideImpression.OuvrirGrandApercu(printPreviewDialog1);
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            AideImpression.DessinerTableLocations(e.Graphics, dt, ref i, "Liste des locations", e);
        }
    }
}
