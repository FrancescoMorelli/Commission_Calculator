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
        public Form1()
        {
            InitializeComponent();

        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            DataSet ds = Database.RetrieveRecords(txt_LoadDb.Text, comboBox_TableName.Text);

            dataGrid_Database.ReadOnly = true;
            dataGrid_Database.DataSource = ds.Tables[0];
        }

        private void btn_LoadDb_Click(object sender, EventArgs e)
        {
            txt_LoadDb.Text = Database.GetDatabasePath();
            PopulateBoxTable();

        }

        public void PopulateBoxTable()
        {
            DataSet tableDs = Database.RetrieveTables(txt_LoadDb.Text);

            comboBox_TableName.DataSource = tableDs.Tables[0];
            comboBox_TableName.DisplayMember = "TABLE_NAME";

            comboBox_TableName.Refresh();
        }
    }
}
