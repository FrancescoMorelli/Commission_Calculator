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
        public static string DbPath { get; private set; }
        public static string ConnectionString { get; private set; }

        public static string GetDatabasePath()
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.InitialDirectory = "C:\\";
                openFile.Filter = "Database files (*.mdf) | *.mdf";

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    DbPath = openFile.FileName;
                    ConnectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={DbPath};Integrated Security = True;";
                    return openFile.FileName;
                }
                else
                    MessageBox.Show("File not found.");
            }
            return null;
        }

        public static DataSet RetrieveRecords(string tableName)
        {
            var query = $@"SELECT * FROM {tableName}";
            DataSet queryData = new DataSet();
            using (var conn = new SqlConnection(ConnectionString))
            {
                var dataAdapter = new SqlDataAdapter(query, conn);
                dataAdapter.Fill(queryData);
                return queryData;
            }
        }

        public static DataSet RetrieveTables()
        {
            var query = $@"SELECT * FROM INFORMATION_SCHEMA.TABLES";

            DataSet queryTableDataSet = new DataSet();

            using (var conn = new SqlConnection(ConnectionString))
            {
                var dataAdapter = new SqlDataAdapter(query, conn);
                dataAdapter.Fill(queryTableDataSet);
                return queryTableDataSet;
            }
        }

        public static Dictionary<string, string> CollectPersonData(int employerId)
        {
            var query = $@"SELECT SalesPerson.Id, Revenue.MilkRevenue, Revenue.WaterRevenue, Revenue.CoffeeRevenue, Revenue.TeaRevenue, Expenses.MilkExpenses, Expenses.WaterExpenses, Expenses.CoffeeExpenses, Expenses.TeaExpenses
                           FROM SalesPerson
                           INNER JOIN Revenue ON {employerId}=Revenue.EmployerId
                           INNER JOIN Expenses ON {employerId}=Expenses.EmployerId;";

            DataSet queryPersonDataSet = new DataSet();
            Dictionary<string, string> employerRecords = new Dictionary<string, string>();

            using (var conn = new SqlConnection(ConnectionString))
            {
                try
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
                catch (SqlException)
                {
                    MessageBox.Show("Invalid columns name detected, wrong database displayed.");
                }
                return null;
            }
        }

        public static void UpdateEmployerCommission(string commissionPercentage, string employerId)
        {
            var query = $@"UPDATE SalesPerson SET Commission = '{commissionPercentage}' WHERE Id = {employerId};";

            using (var conn = new SqlConnection(ConnectionString))
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                conn.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}

