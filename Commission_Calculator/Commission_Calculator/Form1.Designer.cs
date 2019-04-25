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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Load = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Database)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_Database
            // 
            this.dataGrid_Database.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Database.Location = new System.Drawing.Point(12, 12);
            this.dataGrid_Database.Name = "dataGrid_Database";
            this.dataGrid_Database.RowTemplate.Height = 24;
            this.dataGrid_Database.Size = new System.Drawing.Size(663, 315);
            this.dataGrid_Database.TabIndex = 0;
            // 
            // comboBox_TableName
            // 
            this.comboBox_TableName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBox_TableName.FormattingEnabled = true;
            this.comboBox_TableName.Items.AddRange(new object[] {
            "SalesPerson",
            "Revenue",
            "Expenses"});
            this.comboBox_TableName.Location = new System.Drawing.Point(210, 359);
            this.comboBox_TableName.Name = "comboBox_TableName";
            this.comboBox_TableName.Size = new System.Drawing.Size(164, 28);
            this.comboBox_TableName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select table to display";
            // 
            // btn_Load
            // 
            this.btn_Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Load.Location = new System.Drawing.Point(400, 359);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(109, 28);
            this.btn_Load.TabIndex = 3;
            this.btn_Load.Text = "Load";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 619);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_TableName);
            this.Controls.Add(this.dataGrid_Database);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Load;
    }
}

