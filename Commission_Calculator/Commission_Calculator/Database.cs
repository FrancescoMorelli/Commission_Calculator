using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;

namespace Commission_Calculator
{
    public class Database
    {
        public static DataSet RetrieveData(string tableName)
        {
            var pathDb = Directory.GetParent(Convert.ToString(Directory.GetParent(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location))));
            
            var connection = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={pathDb}\Database\Sales.mdf;Integrated Security = True;";
            var query = $@"SELECT * FROM {tableName}";
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
