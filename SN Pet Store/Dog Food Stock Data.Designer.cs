namespace SN_Pet_Store
{
    partial class Dog_Food_Stock_Data
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sN_Pets_Dog_Food_Stock_DataSet = new SN_Pet_Store.SN_Pets_Dog_Food_Stock_DataSet();
            this.dogFoodStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dog_Food_StockTableAdapter = new SN_Pet_Store.SN_Pets_Dog_Food_Stock_DataSetTableAdapters.Dog_Food_StockTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEnteredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateExpiringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sN_Pets_Dog_Food_Stock_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogFoodStockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.dateEnteredDataGridViewTextBoxColumn,
            this.itemDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.dateExpiringDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dogFoodStockBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(742, 260);
            this.dataGridView1.TabIndex = 0;
            // 
            // sN_Pets_Dog_Food_Stock_DataSet
            // 
            this.sN_Pets_Dog_Food_Stock_DataSet.DataSetName = "SN_Pets_Dog_Food_Stock_DataSet";
            this.sN_Pets_Dog_Food_Stock_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dogFoodStockBindingSource
            // 
            this.dogFoodStockBindingSource.DataMember = "Dog_Food_Stock";
            this.dogFoodStockBindingSource.DataSource = this.sN_Pets_Dog_Food_Stock_DataSet;
            // 
            // dog_Food_StockTableAdapter
            // 
            this.dog_Food_StockTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateEnteredDataGridViewTextBoxColumn
            // 
            this.dateEnteredDataGridViewTextBoxColumn.DataPropertyName = "Date_Entered";
            this.dateEnteredDataGridViewTextBoxColumn.HeaderText = "Date_Entered";
            this.dateEnteredDataGridViewTextBoxColumn.Name = "dateEnteredDataGridViewTextBoxColumn";
            // 
            // itemDataGridViewTextBoxColumn
            // 
            this.itemDataGridViewTextBoxColumn.DataPropertyName = "Item";
            this.itemDataGridViewTextBoxColumn.HeaderText = "Item";
            this.itemDataGridViewTextBoxColumn.Name = "itemDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // dateExpiringDataGridViewTextBoxColumn
            // 
            this.dateExpiringDataGridViewTextBoxColumn.DataPropertyName = "Date_Expiring";
            this.dateExpiringDataGridViewTextBoxColumn.HeaderText = "Date_Expiring";
            this.dateExpiringDataGridViewTextBoxColumn.Name = "dateExpiringDataGridViewTextBoxColumn";
            // 
            // Dog_Food_Stock_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 260);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Dog_Food_Stock_Data";
            this.Text = "Dog_Food_Stock_Data";
            this.Load += new System.EventHandler(this.Dog_Food_Stock_Data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sN_Pets_Dog_Food_Stock_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogFoodStockBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SN_Pets_Dog_Food_Stock_DataSet sN_Pets_Dog_Food_Stock_DataSet;
        private System.Windows.Forms.BindingSource dogFoodStockBindingSource;
        private SN_Pets_Dog_Food_Stock_DataSetTableAdapters.Dog_Food_StockTableAdapter dog_Food_StockTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEnteredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateExpiringDataGridViewTextBoxColumn;
    }
}