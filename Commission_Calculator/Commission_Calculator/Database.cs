using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Commission_Calculator
{
    public class Database
    {
        public static string DbPath { get; set; }

        public static string GetDatabasePath()
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.InitialDirectory = "C:\\";
                openFile.Filter = "Database files (*.mdf) | *.mdf";

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    DbPath = openFile.FileName;
                    return openFile.FileName;
                }
                else
                    MessageBox.Show("File not found");
            }
            return null;
        }

        public static DataSet RetrieveRecords(string tableName)
        {
            var connection = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={DbPath};Integrated Security = True;";
            var query = $@"SELECT * FROM {tableName}";
            DataSet queryData = new DataSet();
            using (var conn = new SqlConnection(connection))
            {
                var dataAdapter = new SqlDataAdapter(query, conn);
                dataAdapter.Fill(queryData);
                return queryData;
            }
        }

        public static DataSet RetrieveTables()
        {
            var connection = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={DbPath};Integrated Security = True;";
            var query = $@"SELECT * FROM INFORMATION_SCHEMA.TABLES";

            DataSet queryTableDataSet = new DataSet();

            using (var conn = new SqlConnection(connection))
            {
                var dataAdapter = new SqlDataAdapter(query, conn);
                dataAdapter.Fill(queryTableDataSet);
                return queryTableDataSet;
            }
        }

        public static Dictionary<string,string> CollectPersonData(int employerId)
        {
            var connection = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={DbPath};Integrated Security = True;";
            var query = $@"SELECT SalesPerson.Id, Revenue.MilkRevenue, Revenue.WaterRevenue, Revenue.CoffeeRevenue, Revenue.TeaRevenue, Expenses.MilkExpenses, Expenses.WaterExpenses, Expenses.CoffeeExpenses, Expenses.TeaExpenses
                           FROM SalesPerson
                           INNER JOIN Revenue ON {employerId}=Revenue.EmployerId
                           INNER JOIN Expenses ON {employerId}=Expenses.EmployerId;";

            DataSet queryPersonDataSet = new DataSet();
            Dictionary<string, string> employerRecords = new Dictionary<string, string>();

            using (var conn = new SqlConnection(connection))
            {
                var reader = new SqlDataAdapter(query, conn);
                reader.Fill(queryPersonDataSet);

                employerRecords.Add("EmployerId", queryPersonDataSet.Tables[0].Rows[0]["Id"].ToString());

                employerRecords.Add("MilkExpenses", queryPersonDataSet.Tables[0].Rows[0]["MilkExpenses"].ToString());
                employerRecords.Add("WaterExpenses", queryPersonDataSet.Tables[0].Rows[0]["WaterExpenses"].ToString());
                employerRecords.Add("CoffeeExpenses", queryPersonDataSet.Tables[0].Rows[0]["CoffeeExpenses"].ToString());
                employerRecords.Add("TeaExpenses", queryPersonDataSet.Tables[0].Rows[0]["TeaExpenses"].ToString());

                employerRecords.Add("MilkRevenue", queryPersonDataSet.Tables[0].Rows[0]["MilkRevenue"].ToString());
                employerRecords.Add("WaterRevenue", queryPersonDataSet.Tables[0].Rows[0]["WaterRevenue"].ToString());
                employerRecords.Add("CoffeeRevenue", queryPersonDataSet.Tables[0].Rows[0]["CoffeeRevenue"].ToString());
                employerRecords.Add("TeaRevenue", queryPersonDataSet.Tables[0].Rows[0]["TeaRevenue"].ToString());

                return employerRecords;
            }
        }
    }
}
