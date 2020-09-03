using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class DatabaseConnection
    {
        private string ConnString { get; set; }
        protected IDbConnection Con { get; set; }

        protected DatabaseConnection(string connection)
        {
            ConnString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;
            Con = GetConnection();
        }

        private IDbConnection GetConnection()
        {
            IDbConnection connection = new SqlConnection(ConnString);
            return connection;
        }
    }
}