using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Noureddine_S2_EF
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    lblNbAdherents.Text = GetCount(conn, "adherent").ToString();
                    lblNbLivres.Text = GetCount(conn, "livre").ToString();
                    lblNbLocations.Text = GetCount(conn, "location").ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion : " + ex.Message, "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static int GetCount(MySqlConnection conn, string table)
        {
            using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM " + table, conn))
            {
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
