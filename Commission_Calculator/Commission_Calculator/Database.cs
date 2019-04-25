using System.Data;
using System.Data.SqlClient;

namespace Commission_Calculator
{
    public class Database
    {
        public static DataSet RetrieveData()
        {
            var connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Francesco\Desktop\GitHub\Commission_Calculator\Database\Sales.mdf;Integrated Security = True;";
            var query = @"SELECT * FROM Expenses";
            DataSet queryData = new DataSet();
            using (var conn = new SqlConnection(connection))
            {
                var dataAdapter = new SqlDataAdapter(query, conn);

                dataAdapter.Fill(queryData);
                return queryData;
            }

        }
    }
}
