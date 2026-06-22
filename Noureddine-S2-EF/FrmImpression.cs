using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Noureddine_S2_EF
{
    public partial class FrmImpression : Form
    {
        private DataTable tableImpression;
        private int ligneImpression;

        public FrmImpression()
        {
            InitializeComponent();
        }

        private void FrmImpression_Load(object sender, EventArgs e)
        {
            dtpDateDebut.Value = new DateTime(2025, 6, 1);
            dtpDateFin.Value = new DateTime(2025, 6, 30);
        }

        private void btnImprimerLocations_Click(object sender, EventArgs e)
        {
            if (dtpDateDebut.Value.Date > dtpDateFin.Value.Date)
            {
                MessageBox.Show("La date de début doit être antérieure à la date de fin.",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"SELECT * FROM location
                                   WHERE datelocation BETWEEN @debut AND @fin
                                   ORDER BY datelocation";

                    var adapter = new MySqlDataAdapter(sql, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@debut", dtpDateDebut.Value.Date);
                    adapter.SelectCommand.Parameters.AddWithValue("@fin", dtpDateFin.Value.Date);

                    tableImpression = new DataTable();
                    adapter.Fill(tableImpression);
                }

                if (tableImpression.Rows.Count == 0)
                {
                    MessageBox.Show("Aucune location trouvée entre ces deux dates.",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                ligneImpression = 0;
                printPreviewDialog1.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font titre = new Font("Arial", 14, FontStyle.Bold);
            Font entete = new Font("Arial", 10, FontStyle.Bold);
            Font texte = new Font("Arial", 10, FontStyle.Regular);

            int x = 50;
            int y = 50;

            e.Graphics.DrawString("Locations entre " + dtpDateDebut.Value.ToShortDateString()
                + " et " + dtpDateFin.Value.ToShortDateString(), titre, Brushes.Black, x, y);
            y += 40;

            e.Graphics.DrawString("Id", entete, Brushes.Black, x, y);
            e.Graphics.DrawString("Id livre", entete, Brushes.Black, x + 50, y);
            e.Graphics.DrawString("Id adhérent", entete, Brushes.Black, x + 130, y);
            e.Graphics.DrawString("Date loc.", entete, Brushes.Black, x + 230, y);
            e.Graphics.DrawString("Date ret.", entete, Brushes.Black, x + 330, y);
            e.Graphics.DrawString("Statut", entete, Brushes.Black, x + 430, y);
            y += 25;

            while (ligneImpression < tableImpression.Rows.Count)
            {
                DataRow row = tableImpression.Rows[ligneImpression];
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

        private void btnFermer_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
