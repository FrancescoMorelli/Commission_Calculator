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

            btn_CalculateCommission.Visible = false;
            lbl_DisplayTable.Visible = false;
            comboBox_TableName.Visible = false;
            btn_DisplayTable.Visible = false;
        }

        private void btn_LoadDb_Click(object sender, EventArgs e)
        {
            txt_LoadDb.Text = Database.GetDatabasePath();
            PopulateBoxTable();

            lbl_DisplayTable.Visible = true;
            comboBox_TableName.Visible = true;
            btn_DisplayTable.Visible = true;
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
            try
            {
                string employerId = dataGrid_Database.SelectedRows[0].Cells["EmployerId"].Value.ToString();
                dataCollected = Database.CollectPersonData(Convert.ToInt32(employerId));
                float commissionPercentage = Calculator.CalculateCommission(dataCollected);

                if (commissionPercentage > 0)
                {
                    if (MessageBox.Show($"Commission percentage: {commissionPercentage}%\n Update employer record?", "Positive profit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Database.UpdateEmployerCommission(Convert.ToString(commissionPercentage), employerId);
                        MessageBox.Show("Record updated.");
                    }
                }
                else
                    MessageBox.Show($"Profit is less than 0, no commission calculated.");
            }

            catch (ArgumentException)
            {
                MessageBox.Show("Please select a valid record from Revenue or Expenses tables.");
            }
        }

        public void PopulateBoxTable()
        {
            DataSet tableDs = Database.RetrieveTables();

            comboBox_TableName.DataSource = tableDs.Tables[0];
            comboBox_TableName.DisplayMember = "TABLE_NAME";
            comboBox_TableName.Refresh();
        }

        private void dataGrid_Database_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (dataGrid_Database.SelectedRows[0].Displayed)
                {
                    if ((e.Button == MouseButtons.Right) && (dataGrid_Database.SelectedRows[0].Cells["Commission"].Selected))
                    {
                        ContextMenu contextMenuDataGrid = new ContextMenu();
                        contextMenuDataGrid.MenuItems.Add(new MenuItem("Delete Commission"));
                        contextMenuDataGrid.Show(dataGrid_Database, new Point(e.X, e.Y));

                        Database.UpdateEmployerCommission(null, dataGrid_Database.SelectedRows[0].Cells["Id"].Value.ToString());
                    }
                }
            }
            catch(Exception)
            { }
        }
    }
}
