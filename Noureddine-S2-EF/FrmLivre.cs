using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Noureddine_S2_EF
{
    public partial class FrmLivre : Form
    {
        string chaine = "server=127.0.0.1;database=bddbibli;uid=root;pwd=;";

        public FrmLivre()
        {
            InitializeComponent();
        }

        private void FrmLivre_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(chaine);
            con.Open();

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM livre", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.ReadOnly = true;

            con.Close();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
