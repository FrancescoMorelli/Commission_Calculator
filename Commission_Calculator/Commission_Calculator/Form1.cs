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
            DataSet ds = Database.RetrieveData(comboBox_TableName.Text);

            dataGrid_Database.ReadOnly = true;
            dataGrid_Database.DataSource = ds.Tables[0];
        }
    }
}
