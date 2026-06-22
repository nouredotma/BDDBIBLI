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
        string chaine = "server=127.0.0.1;database=bddbibli;uid=root;pwd=;";

        DataTable dt;
        int i = 0;

        public FrmImpression()
        {
            InitializeComponent();
        }

        private void FrmImpression_Load(object sender, EventArgs e)
        {
            // Dates par défaut = données de la base (juin 2025)
            dtpDateDebut.Value = new DateTime(2025, 6, 1);
            dtpDateFin.Value = new DateTime(2025, 6, 30);
        }

        private void btnImprimerLocations_Click(object sender, EventArgs e)
        {
            if (dtpDateDebut.Value.Date > dtpDateFin.Value.Date)
            {
                MessageBox.Show("La date de début doit être avant la date de fin.");
                return;
            }

            try
            {
                MySqlConnection con = new MySqlConnection(chaine);
                con.Open();

                string sql = "SELECT * FROM location WHERE datelocation BETWEEN @debut AND @fin";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                da.SelectCommand.Parameters.AddWithValue("@debut", dtpDateDebut.Value.Date);
                da.SelectCommand.Parameters.AddWithValue("@fin", dtpDateFin.Value.Date);

                dt = new DataTable();
                da.Fill(dt);
                con.Close();

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Aucune location trouvée entre ces deux dates.");
                    return;
                }

                i = 0;
                AideImpression.OuvrirGrandApercu(printPreviewDialog1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            string titre = "Locations entre " + dtpDateDebut.Value.ToShortDateString()
                + " et " + dtpDateFin.Value.ToShortDateString();

            AideImpression.DessinerTableLocations(e.Graphics, dt, ref i, titre, e);
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
