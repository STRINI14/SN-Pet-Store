namespace SN_Pet_Store
{
    partial class Dog_Pet_Care_Stock_Data
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
            this.SN_Pets_Dog_Pet_Care_Stock_DataSet = new SN_Pet_Store.SN_PetsDataSet1();
            this.dogCareStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dog_Care_StockTableAdapter = new SN_Pet_Store.SN_PetsDataSet1TableAdapters.Dog_Care_StockTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEnteredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateExpiringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SN_Pets_Dog_Pet_Care_Stock_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogCareStockBindingSource)).BeginInit();
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
            this.dataGridView1.DataSource = this.dogCareStockBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 230);
            this.dataGridView1.TabIndex = 0;
            // 
            // SN_Pets_Dog_Pet_Care_Stock_DataSet
            // 
            this.SN_Pets_Dog_Pet_Care_Stock_DataSet.DataSetName = "SN_PetsDataSet1";
            this.SN_Pets_Dog_Pet_Care_Stock_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dogCareStockBindingSource
            // 
            this.dogCareStockBindingSource.DataMember = "Dog_Care_Stock";
            this.dogCareStockBindingSource.DataSource = this.SN_Pets_Dog_Pet_Care_Stock_DataSet;
            // 
            // dog_Care_StockTableAdapter
            // 
            this.dog_Care_StockTableAdapter.ClearBeforeFill = true;
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
            // Dog_Pet_Care_Stock_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 230);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Dog_Pet_Care_Stock_Data";
            this.Text = "Dog_Pet_Care_Stock_Data";
            this.Load += new System.EventHandler(this.Dog_Pet_Care_Stock_Data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SN_Pets_Dog_Pet_Care_Stock_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogCareStockBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SN_PetsDataSet1 SN_Pets_Dog_Pet_Care_Stock_DataSet;
        private System.Windows.Forms.BindingSource dogCareStockBindingSource;
        private SN_PetsDataSet1TableAdapters.Dog_Care_StockTableAdapter dog_Care_StockTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEnteredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateExpiringDataGridViewTextBoxColumn;
    }
}