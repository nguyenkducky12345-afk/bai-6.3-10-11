using System.Data.SqlClient;

namespace ProjectManagement.DAL
{
    public class DatabaseAccess
    {
        protected SqlConnection GetConnection()
        {
            // Kết nối trực tiếp vào database ProjectTaskDB trên LocalDB của Visual Studio
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProjectTaskDB;Integrated Security=True;TrustServerCertificate=True;";

            return new SqlConnection(connString);
        }
    }
}