using System.Data.SqlClient;

namespace Library_MVC
{
    public class Dbconnection
    {
        SqlConnection connection = new SqlConnection(@"Server=localhost;Database=Library;Trusted_Connection=True;");
        public SqlConnection? Open_Connection()
        {
            try
            {
                connection.Open();
                return connection;
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error connecting to database, error message: " + e.Message);
                return null;
            }
        }

        public void Close_Connection()
        {
            connection.Close();
        }
    }
}
