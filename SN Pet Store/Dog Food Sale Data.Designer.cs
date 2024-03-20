namespace SN_Pet_Store
{
    partial class Dog_Food_Sale_Data
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
            this.SN_Pets_Dog_Food_Sale_DataSet = new SN_Pet_Store.SN_PetsDataSet2();
            this.dogFoodSaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dog_Food_SaleTableAdapter = new SN_Pet_Store.SN_PetsDataSet2TableAdapters.Dog_Food_SaleTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEnteredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SN_Pets_Dog_Food_Sale_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogFoodSaleBindingSource)).BeginInit();
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
            this.priceDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.amountDueDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dogFoodSaleBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(845, 222);
            this.dataGridView1.TabIndex = 0;
            // 
            // SN_Pets_Dog_Food_Sale_DataSet
            // 
            this.SN_Pets_Dog_Food_Sale_DataSet.DataSetName = "SN_PetsDataSet2";
            this.SN_Pets_Dog_Food_Sale_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dogFoodSaleBindingSource
            // 
            this.dogFoodSaleBindingSource.DataMember = "Dog_Food_Sale";
            this.dogFoodSaleBindingSource.DataSource = this.SN_Pets_Dog_Food_Sale_DataSet;
            // 
            // dog_Food_SaleTableAdapter
            // 
            this.dog_Food_SaleTableAdapter.ClearBeforeFill = true;
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
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "Discount";
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            // 
            // amountDueDataGridViewTextBoxColumn
            // 
            this.amountDueDataGridViewTextBoxColumn.DataPropertyName = "Amount_Due";
            this.amountDueDataGridViewTextBoxColumn.HeaderText = "Amount_Due";
            this.amountDueDataGridViewTextBoxColumn.Name = "amountDueDataGridViewTextBoxColumn";
            // 
            // Dog_Food_Sale_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 222);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Dog_Food_Sale_Data";
            this.Text = "Dog_Food_Sale_Data";
            this.Load += new System.EventHandler(this.Dog_Food_Sale_Data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SN_Pets_Dog_Food_Sale_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogFoodSaleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SN_PetsDataSet2 SN_Pets_Dog_Food_Sale_DataSet;
        private System.Windows.Forms.BindingSource dogFoodSaleBindingSource;
        private SN_PetsDataSet2TableAdapters.Dog_Food_SaleTableAdapter dog_Food_SaleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEnteredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDueDataGridViewTextBoxColumn;
    }
}