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
        private DataTable tableLocations;
        private int ligneImpression;

        public FrmLocation()
        {
            InitializeComponent();
        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            dtpDateLocation.Value = DateTime.Today;
            dtpDateRetour.Value = DateTime.Today;
            chkDateRetour.Checked = false;
            ChargerLocations();
        }

        private void ChargerLocations(string filtreStatut = "")
        {
            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT * FROM location";
                    if (!string.IsNullOrWhiteSpace(filtreStatut))
                    {
                        sql += " WHERE statut LIKE @statut";
                    }
                    sql += " ORDER BY idlocation";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                    if (!string.IsNullOrWhiteSpace(filtreStatut))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@statut", "%" + filtreStatut.Trim() + "%");
                    }

                    tableLocations = new DataTable();
                    adapter.Fill(tableLocations);
                    dgvLocations.DataSource = tableLocations;
                    dgvLocations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion : " + ex.Message, "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        }

        private void RemplirSaisie(DataGridViewRow row)
        {
            txtIdLocation.Text = row.Cells["idlocation"].Value.ToString();
            txtIdLivre.Text = row.Cells["idlivre"].Value.ToString();
            txtIdAdherent.Text = row.Cells["idadherent"].Value.ToString();
            dtpDateLocation.Value = Convert.ToDateTime(row.Cells["datelocation"].Value);

            if (row.Cells["dateretour"].Value == DBNull.Value)
            {
                chkDateRetour.Checked = false;
            }
            else
            {
                chkDateRetour.Checked = true;
                dtpDateRetour.Value = Convert.ToDateTime(row.Cells["dateretour"].Value);
            }

            txtStatut.Text = row.Cells["statut"].Value.ToString();
        }

        private void dgvLocations_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLocations.SelectedRows.Count > 0)
            {
                RemplirSaisie(dgvLocations.SelectedRows[0]);
            }
        }

        private void chkDateRetour_CheckedChanged(object sender, EventArgs e)
        {
            dtpDateRetour.Enabled = chkDateRetour.Checked;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"INSERT INTO location (idlivre, idadherent, datelocation, dateretour, statut)
                                   VALUES (@idlivre, @idadherent, @datelocation, @dateretour, @statut)";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@idlivre", int.Parse(txtIdLivre.Text));
                    cmd.Parameters.AddWithValue("@idadherent", int.Parse(txtIdAdherent.Text));
                    cmd.Parameters.AddWithValue("@datelocation", dtpDateLocation.Value.Date);
                    cmd.Parameters.AddWithValue("@dateretour", chkDateRetour.Checked ? (object)dtpDateRetour.Value.Date : DBNull.Value);
                    cmd.Parameters.AddWithValue("@statut", txtStatut.Text);
                    cmd.ExecuteNonQuery();
                }

                ChargerLocations();
                ViderSaisie();
                MessageBox.Show("Location ajoutée.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur ajout : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdLocation.Text))
            {
                MessageBox.Show("Sélectionnez une location à modifier.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"UPDATE location
                                   SET idlivre = @idlivre,
                                       idadherent = @idadherent,
                                       datelocation = @datelocation,
                                       dateretour = @dateretour,
                                       statut = @statut
                                   WHERE idlocation = @idlocation";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@idlivre", int.Parse(txtIdLivre.Text));
                    cmd.Parameters.AddWithValue("@idadherent", int.Parse(txtIdAdherent.Text));
                    cmd.Parameters.AddWithValue("@datelocation", dtpDateLocation.Value.Date);
                    cmd.Parameters.AddWithValue("@dateretour", chkDateRetour.Checked ? (object)dtpDateRetour.Value.Date : DBNull.Value);
                    cmd.Parameters.AddWithValue("@statut", txtStatut.Text);
                    cmd.Parameters.AddWithValue("@idlocation", int.Parse(txtIdLocation.Text));
                    cmd.ExecuteNonQuery();
                }

                ChargerLocations();
                MessageBox.Show("Location modifiée.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur modification : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            ChargerLocations(txtRecherche.Text);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdLocation.Text))
            {
                MessageBox.Show("Sélectionnez une location à supprimer.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult rep = MessageBox.Show("Supprimer cette location ?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rep != DialogResult.Yes)
                return;

            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(
                        "DELETE FROM location WHERE idlocation = @idlocation", conn);
                    cmd.Parameters.AddWithValue("@idlocation", int.Parse(txtIdLocation.Text));
                    cmd.ExecuteNonQuery();
                }

                ChargerLocations();
                ViderSaisie();
                MessageBox.Show("Location supprimée.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur suppression : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImprimer_Click(object sender, EventArgs e)
        {
            if (tableLocations == null || tableLocations.Rows.Count == 0)
            {
                MessageBox.Show("Aucune location à imprimer.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ligneImpression = 0;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font titre = new Font("Arial", 14, FontStyle.Bold);
            Font entete = new Font("Arial", 10, FontStyle.Bold);
            Font texte = new Font("Arial", 10, FontStyle.Regular);

            int x = 50;
            int y = 50;

            e.Graphics.DrawString("Liste des locations", titre, Brushes.Black, x, y);
            y += 40;

            e.Graphics.DrawString("Id", entete, Brushes.Black, x, y);
            e.Graphics.DrawString("Id livre", entete, Brushes.Black, x + 50, y);
            e.Graphics.DrawString("Id adhérent", entete, Brushes.Black, x + 130, y);
            e.Graphics.DrawString("Date loc.", entete, Brushes.Black, x + 230, y);
            e.Graphics.DrawString("Date ret.", entete, Brushes.Black, x + 330, y);
            e.Graphics.DrawString("Statut", entete, Brushes.Black, x + 430, y);
            y += 25;

            while (ligneImpression < tableLocations.Rows.Count)
            {
                DataRow row = tableLocations.Rows[ligneImpression];
                e.Graphics.DrawString(row["idlocation"].ToString(), texte, Brushes.Black, x, y);
                e.Graphics.DrawString(row["idlivre"].ToString(), texte, Brushes.Black, x + 50, y);
                e.Graphics.DrawString(row["idadherent"].ToString(), texte, Brushes.Black, x + 130, y);
                e.Graphics.DrawString(Convert.ToDateTime(row["datelocation"]).ToShortDateString(), texte, Brushes.Black, x + 230, y);

                string dateRetour = row["dateretour"] == DBNull.Value
                    ? ""
                    : Convert.ToDateTime(row["dateretour"]).ToShortDateString();

                e.Graphics.DrawString(dateRetour, texte, Brushes.Black, x + 330, y);
                e.Graphics.DrawString(row["statut"].ToString(), texte, Brushes.Black, x + 430, y);

                y += 22;
                ligneImpression++;

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
