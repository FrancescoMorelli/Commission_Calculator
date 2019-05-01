namespace Commission_Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGrid_Database = new System.Windows.Forms.DataGridView();
            this.comboBox_TableName = new System.Windows.Forms.ComboBox();
            this.lbl_DisplayTable = new System.Windows.Forms.Label();
            this.btn_DisplayTable = new System.Windows.Forms.Button();
            this.lbl_LoadDb = new System.Windows.Forms.Label();
            this.txt_LoadDb = new System.Windows.Forms.TextBox();
            this.btn_LoadDb = new System.Windows.Forms.Button();
            this.btn_CalculateCommission = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Database)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_Database
            // 
            this.dataGrid_Database.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Database.Location = new System.Drawing.Point(12, 112);
            this.dataGrid_Database.Name = "dataGrid_Database";
            this.dataGrid_Database.RowTemplate.Height = 24;
            this.dataGrid_Database.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_Database.Size = new System.Drawing.Size(694, 315);
            this.dataGrid_Database.TabIndex = 0;
            this.dataGrid_Database.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGrid_Database_MouseClick);
            // 
            // comboBox_TableName
            // 
            this.comboBox_TableName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBox_TableName.FormattingEnabled = true;
            this.comboBox_TableName.Location = new System.Drawing.Point(225, 458);
            this.comboBox_TableName.Name = "comboBox_TableName";
            this.comboBox_TableName.Size = new System.Drawing.Size(255, 28);
            this.comboBox_TableName.TabIndex = 1;
            // 
            // lbl_DisplayTable
            // 
            this.lbl_DisplayTable.AutoSize = true;
            this.lbl_DisplayTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_DisplayTable.Location = new System.Drawing.Point(12, 458);
            this.lbl_DisplayTable.Name = "lbl_DisplayTable";
            this.lbl_DisplayTable.Size = new System.Drawing.Size(173, 20);
            this.lbl_DisplayTable.TabIndex = 2;
            this.lbl_DisplayTable.Text = "Select table to display";
            // 
            // btn_DisplayTable
            // 
            this.btn_DisplayTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_DisplayTable.Location = new System.Drawing.Point(538, 458);
            this.btn_DisplayTable.Name = "btn_DisplayTable";
            this.btn_DisplayTable.Size = new System.Drawing.Size(167, 29);
            this.btn_DisplayTable.TabIndex = 3;
            this.btn_DisplayTable.Text = "Display Table";
            this.btn_DisplayTable.UseVisualStyleBackColor = true;
            this.btn_DisplayTable.Click += new System.EventHandler(this.btn_DisplayTable_Click);
            // 
            // lbl_LoadDb
            // 
            this.lbl_LoadDb.AutoSize = true;
            this.lbl_LoadDb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_LoadDb.Location = new System.Drawing.Point(12, 64);
            this.lbl_LoadDb.Name = "lbl_LoadDb";
            this.lbl_LoadDb.Size = new System.Drawing.Size(184, 20);
            this.lbl_LoadDb.TabIndex = 4;
            this.lbl_LoadDb.Text = "Select database to load";
            // 
            // txt_LoadDb
            // 
            this.txt_LoadDb.Location = new System.Drawing.Point(231, 63);
            this.txt_LoadDb.Name = "txt_LoadDb";
            this.txt_LoadDb.ReadOnly = true;
            this.txt_LoadDb.Size = new System.Drawing.Size(273, 22);
            this.txt_LoadDb.TabIndex = 5;
            // 
            // btn_LoadDb
            // 
            this.btn_LoadDb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_LoadDb.Location = new System.Drawing.Point(539, 60);
            this.btn_LoadDb.Name = "btn_LoadDb";
            this.btn_LoadDb.Size = new System.Drawing.Size(167, 28);
            this.btn_LoadDb.TabIndex = 6;
            this.btn_LoadDb.Text = "Load Database";
            this.btn_LoadDb.UseVisualStyleBackColor = true;
            this.btn_LoadDb.Click += new System.EventHandler(this.btn_LoadDb_Click);
            // 
            // btn_CalculateCommission
            // 
            this.btn_CalculateCommission.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_CalculateCommission.Location = new System.Drawing.Point(269, 536);
            this.btn_CalculateCommission.Name = "btn_CalculateCommission";
            this.btn_CalculateCommission.Size = new System.Drawing.Size(167, 60);
            this.btn_CalculateCommission.TabIndex = 7;
            this.btn_CalculateCommission.Text = "Calculate Commission";
            this.btn_CalculateCommission.UseVisualStyleBackColor = true;
            this.btn_CalculateCommission.Click += new System.EventHandler(this.btn_CalculateCommission_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 608);
            this.Controls.Add(this.btn_CalculateCommission);
            this.Controls.Add(this.btn_LoadDb);
            this.Controls.Add(this.txt_LoadDb);
            this.Controls.Add(this.lbl_LoadDb);
            this.Controls.Add(this.btn_DisplayTable);
            this.Controls.Add(this.lbl_DisplayTable);
            this.Controls.Add(this.comboBox_TableName);
            this.Controls.Add(this.dataGrid_Database);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Commission Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Database)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_Database;
        private System.Windows.Forms.ComboBox comboBox_TableName;
        private System.Windows.Forms.Label lbl_DisplayTable;
        private System.Windows.Forms.Button btn_DisplayTable;
        private System.Windows.Forms.Label lbl_LoadDb;
        private System.Windows.Forms.TextBox txt_LoadDb;
        private System.Windows.Forms.Button btn_LoadDb;
        private System.Windows.Forms.Button btn_CalculateCommission;
    }
}

