using System.Configuration;
using MySql.Data.MySqlClient;

namespace Noureddine_S2_EF
{
    public static class DatabaseHelper
    {
        public static string ConnectionString =>
            ConfigurationManager.ConnectionStrings["BddBibli"].ConnectionString;

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
    }
}
