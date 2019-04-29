using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Commission_Calculator
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> dataCollected;

        public Form1()
        {
            InitializeComponent();
            btn_DisplayTable.Enabled = false;
            btn_CalculateCommission.Visible = false;
        }

        private void btn_LoadDb_Click(object sender, EventArgs e)
        {
            txt_LoadDb.Text = Database.GetDatabasePath();
            PopulateBoxTable();
            btn_DisplayTable.Enabled = true;
        }

        public void PopulateBoxTable()
        {
            DataSet tableDs = Database.RetrieveTables();

            comboBox_TableName.DataSource = tableDs.Tables[0];
            comboBox_TableName.DisplayMember = "TABLE_NAME";
            comboBox_TableName.Refresh();
        }

        private void btn_DisplayTable_Click(object sender, EventArgs e)
        {
            DataSet ds = Database.RetrieveRecords(comboBox_TableName.Text);

            dataGrid_Database.ReadOnly = true;
            dataGrid_Database.DataSource = ds.Tables[0];
            dataGrid_Database.MultiSelect = false;
            btn_CalculateCommission.Visible = true;
        }


        private void btn_CalculateCommission_Click(object sender, EventArgs e)
        {
            string employerId = dataGrid_Database.SelectedRows[0].Cells["EmployerId"].Value.ToString();

            dataCollected = Database.CollectPersonData(Convert.ToInt32(employerId));

            int profit = Calculator.CalculateCommission(dataCollected);

            if (profit > 0)
                MessageBox.Show("Profit is greater than 0");
            else
                MessageBox.Show("Profit is less than 0");
        }
    }
}
