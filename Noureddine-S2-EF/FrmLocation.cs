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

        public FrmLocation()
        {
            InitializeComponent();
        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            Afficher();
        }

        private void Afficher()
        {
            MySqlConnection con = new MySqlConnection(chaine);
            con.Open();

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM location", con);
            dt = new DataTable();
            da.Fill(dt);

            dgvLocations.DataSource = dt;
            con.Close();
        }

        private void dgvLocations_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLocations.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvLocations.SelectedRows[0];
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
            MessageBox.Show("Suppression effectuée.");
        }

        private void btnImprimer_Click(object sender, EventArgs e)
        {
            i = 0;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font f1 = new Font("Arial", 12, FontStyle.Bold);
            Font f2 = new Font("Arial", 10);

            int x = 50;
            int y = 50;

            e.Graphics.DrawString("Liste des locations", f1, Brushes.Black, x, y);
            y = y + 40;

            while (i < dt.Rows.Count)
            {
                string ligne = dt.Rows[i][0].ToString() + "  "
                    + dt.Rows[i][1].ToString() + "  "
                    + dt.Rows[i][2].ToString() + "  "
                    + dt.Rows[i][3].ToString() + "  "
                    + dt.Rows[i][5].ToString();

                e.Graphics.DrawString(ligne, f2, Brushes.Black, x, y);
                y = y + 25;
                i++;

                if (y > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            e.HasMorePages = false;
        }
    }
}
