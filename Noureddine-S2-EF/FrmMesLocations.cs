using System;
using System.Data;
using System.Drawing.Printing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Noureddine_S2_EF
{
    public partial class FrmMesLocations : Form
    {
        string chaine = "server=127.0.0.1;database=bddbibli;uid=root;pwd=;";

        DataTable dt;
        int i = 0;

        public FrmMesLocations()
        {
            InitializeComponent();
        }

        private void FrmMesLocations_Load(object sender, EventArgs e)
        {
            Afficher();
        }

        private void Afficher()
        {
            MySqlConnection con = new MySqlConnection(chaine);
            con.Open();

            string sql = "SELECT * FROM location WHERE idadherent = @idadherent";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
            da.SelectCommand.Parameters.AddWithValue("@idadherent", Session.IdAdherentConnecte);

            dt = new DataTable();
            da.Fill(dt);

            dgvMesLocations.DataSource = dt;
            dgvMesLocations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();
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
            AideImpression.DessinerTableLocations(e.Graphics, dt, ref i, "Mes locations", e);
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
