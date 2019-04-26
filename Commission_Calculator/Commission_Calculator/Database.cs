using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Commission_Calculator
{
    public class Database
    {
        public static string GetDatabasePath()
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.InitialDirectory = "C:\\";
                openFile.Filter = "Database files (*.mdf) | *.mdf";

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    return openFile.FileName;
                }
                else
                    MessageBox.Show("File not found");
            }
            return null;
        }
        public static DataSet RetrieveRecords(string dbPath, string tableName)
        {
            var connection = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={dbPath};Integrated Security = True;";
            var query = $@"SELECT * FROM {tableName}";
            DataSet queryData = new DataSet();
            using (var conn = new SqlConnection(connection))
            {
                var dataAdapter = new SqlDataAdapter(query, conn);
                dataAdapter.Fill(queryData);
                return queryData;
            }
        }
        public static DataSet RetrieveTables(string dbPath)
        {
            var connection = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={dbPath};Integrated Security = True;";
            var query = $@"SELECT * FROM INFORMATION_SCHEMA.TABLES";

            DataSet queryTableData = new DataSet();

            using (var conn = new SqlConnection(connection))
            {
                var dataAdapter = new SqlDataAdapter(query, conn);

                dataAdapter.Fill(queryTableData);
                return queryTableData;
            }
        }
    }
}
