namespace SN_Pet_Store
{
    partial class Cat_Food_Stock_Data
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
            this.sN_PetsDataSet8 = new SN_Pet_Store.SN_PetsDataSet8();
            this.catFoodStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cat_Food_StockTableAdapter = new SN_Pet_Store.SN_PetsDataSet8TableAdapters.Cat_Food_StockTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateExpiringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sN_PetsDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catFoodStockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.itemDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.dateExpiringDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.catFoodStockBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(485, 462);
            this.dataGridView1.TabIndex = 0;
            // 
            // sN_PetsDataSet8
            // 
            this.sN_PetsDataSet8.DataSetName = "SN_PetsDataSet8";
            this.sN_PetsDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // catFoodStockBindingSource
            // 
            this.catFoodStockBindingSource.DataMember = "Cat_Food_Stock";
            this.catFoodStockBindingSource.DataSource = this.sN_PetsDataSet8;
            // 
            // cat_Food_StockTableAdapter
            // 
            this.cat_Food_StockTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 43;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 55;
            // 
            // itemDataGridViewTextBoxColumn
            // 
            this.itemDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.itemDataGridViewTextBoxColumn.DataPropertyName = "Item";
            this.itemDataGridViewTextBoxColumn.HeaderText = "Item";
            this.itemDataGridViewTextBoxColumn.Name = "itemDataGridViewTextBoxColumn";
            this.itemDataGridViewTextBoxColumn.Width = 52;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 71;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.Width = 66;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 56;
            // 
            // dateExpiringDataGridViewTextBoxColumn
            // 
            this.dateExpiringDataGridViewTextBoxColumn.DataPropertyName = "Date_Expiring";
            this.dateExpiringDataGridViewTextBoxColumn.HeaderText = "Date_Expiring";
            this.dateExpiringDataGridViewTextBoxColumn.Name = "dateExpiringDataGridViewTextBoxColumn";
            this.dateExpiringDataGridViewTextBoxColumn.Width = 98;
            // 
            // Cat_Food_Stock_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 462);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Cat_Food_Stock_Data";
            this.Text = "Cat_Food_Stock_Data";
            this.Load += new System.EventHandler(this.Cat_Food_Stock_Data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sN_PetsDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catFoodStockBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SN_PetsDataSet8 sN_PetsDataSet8;
        private System.Windows.Forms.BindingSource catFoodStockBindingSource;
        private SN_PetsDataSet8TableAdapters.Cat_Food_StockTableAdapter cat_Food_StockTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateExpiringDataGridViewTextBoxColumn;
    }
}