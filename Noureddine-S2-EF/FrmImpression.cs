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

        private void btnImprimerLocations_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(chaine);
            con.Open();

            string sql = "SELECT * FROM location WHERE datelocation BETWEEN @debut AND @fin";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
            da.SelectCommand.Parameters.AddWithValue("@debut", dtpDateDebut.Value.ToString("yyyy-MM-dd"));
            da.SelectCommand.Parameters.AddWithValue("@fin", dtpDateFin.Value.ToString("yyyy-MM-dd"));

            dt = new DataTable();
            da.Fill(dt);
            con.Close();

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Aucune location trouvée.");
                return;
            }

            i = 0;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font f1 = new Font("Arial", 12, FontStyle.Bold);
            Font f2 = new Font("Arial", 10);

            int x = 50;
            int y = 50;

            e.Graphics.DrawString("Locations entre " + dtpDateDebut.Value.ToShortDateString()
                + " et " + dtpDateFin.Value.ToShortDateString(), f1, Brushes.Black, x, y);
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

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
