namespace SN_Pet_Store
{
    partial class Bird_Food_Stock_Data
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
            this.sN_Pets_Bird_Food_Stock_DataSet = new SN_Pet_Store.SN_Pets_Bird_Food_Stock_DataSet();
            this.birdFoodStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bird_Food_StockTableAdapter = new SN_Pet_Store.SN_Pets_Bird_Food_Stock_DataSetTableAdapters.Bird_Food_StockTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateExpiringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sN_Pets_Bird_Food_Stock_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birdFoodStockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.itemDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.dateExpiringDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.birdFoodStockBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(917, 324);
            this.dataGridView1.TabIndex = 0;
            // 
            // sN_Pets_Bird_Food_Stock_DataSet
            // 
            this.sN_Pets_Bird_Food_Stock_DataSet.DataSetName = "SN_Pets_Bird_Food_Stock_DataSet";
            this.sN_Pets_Bird_Food_Stock_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // birdFoodStockBindingSource
            // 
            this.birdFoodStockBindingSource.DataMember = "Bird_Food_Stock";
            this.birdFoodStockBindingSource.DataSource = this.sN_Pets_Bird_Food_Stock_DataSet;
            // 
            // bird_Food_StockTableAdapter
            // 
            this.bird_Food_StockTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
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
            // Bird_Food_Stock_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 324);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Bird_Food_Stock_Data";
            this.Text = "Bird_Food_Stock_Data";
            this.Load += new System.EventHandler(this.Bird_Food_Stock_Data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sN_Pets_Bird_Food_Stock_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birdFoodStockBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SN_Pets_Bird_Food_Stock_DataSet sN_Pets_Bird_Food_Stock_DataSet;
        private System.Windows.Forms.BindingSource birdFoodStockBindingSource;
        private SN_Pets_Bird_Food_Stock_DataSetTableAdapters.Bird_Food_StockTableAdapter bird_Food_StockTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateExpiringDataGridViewTextBoxColumn;
    }
}